using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using AllInOne.Logic;
using AllInOne.Logic.Util;

namespace AllInOne.Forms
{

    public partial class MainForm : Form
    {
        private bool isDisabledCheckedChanged;
        public static int eggs;
        public string version = "7.3";
        OpenFileDialog openFileDialog = new OpenFileDialog();

        public MainForm()
        {
            this.isDisabledCheckedChanged = false;
            this.InitializeComponent();
            //DateTime buildDate = new FileInfo(Assembly.GetExecutingAssembly().Location).LastWriteTime;
            //Более правильный вариант
            Version Version = Assembly.GetExecutingAssembly().GetName().Version;
            DateTime buildDate = new DateTime(2000, 1, 1).AddDays(Version.Build).AddSeconds(Version.Revision * 2);
            this.lblBuild.Text = buildDate.ToString();
            this.lblVersion.Text = version;
            if (!Program.standalone)
            {
                appinfoPanel.Visible = false;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            eggs = 0;
            base.Location = Properties.Settings.Default.WindowLocation;
            Size windowSize = Properties.Settings.Default.WindowSize;
            base.Size = Properties.Settings.Default.WindowSize;
            base.WindowState = Properties.Settings.Default.WindowState;
            // this.LoadBoxValues();
            this.UpdateFormLanguage();
            LoadSettings();
            KeyPreview = true;
            defaultCombobox();
            //this.openFolderButton.Visible = Program.standalone;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //XmlDocument xmlDocument = new XmlDocument();
            //xmlDocument.Load(Program.pathToMyPluginDir + "\\box.xml");
            //XmlNode xmlNode = xmlDocument.SelectSingleNode("root");
            //foreach (object obj in xmlNode.SelectSingleNode("box"))
            //{
            //    XmlNode xmlNode2 = (XmlNode)obj;
            //    string value = xmlNode2.Attributes[0].Value;
            //    if (value == "AddToastMessage")
            //    {
            //        xmlNode2.InnerText = this.toastMessageTBox.Text;
            //    }
            //}
            //XmlNode xmlNode3 = xmlNode.SelectSingleNode("replace");
            //xmlNode3.RemoveAll();
            //foreach (object obj2 in this.replaceGBox.Controls)
            //{
            //    if (obj2 is TextBox)
            //    {
            //        XmlNode xmlNode4 = xmlDocument.CreateElement("item");
            //        XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("name");
            //        xmlAttribute.Value = ((TextBox)obj2).Name;
            //        xmlNode4.Attributes.Append(xmlAttribute);
            //        xmlNode4.InnerText = ((TextBox)obj2).Text;
            //        xmlNode3.AppendChild(xmlNode4);
            //    }
            //}
            //xmlDocument.Save(Program.pathToMyPluginDir + "\\box.xml");
            if (base.WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.WindowSize = base.Size;
                Properties.Settings.Default.WindowLocation = base.Location;
            }
            else
            {
                Properties.Settings.Default.WindowSize = base.RestoreBounds.Size;
            }
            //   SaveBoxValues();
            SaveSettings();
            Properties.Settings.Default.WindowState = base.WindowState;
            Properties.Settings.Default.Save();
        }

        #region LoadSettings
        public void LoadSettings()
        {
            Dictionary<string, string> values = new Dictionary<string, string>();
            if (File.Exists(Program.pathToMyPluginDir + "\\all_values.txt"))
            {
                var lines = File.ReadAllLines(Program.pathToMyPluginDir + "\\all_values.txt");
                foreach (var s in lines)
                {
                    if (s.IndexOf("#") > 0)
                    {
                        values[s.Substring(0, s.IndexOf('#'))] = s.Substring(s.IndexOf('#') + 1);
                    }
                }
            }
            foreach (string file in Directory.GetFiles(Program.pathToMyPluginDir + "\\deleteRes", "*.xml"))
            {
                deleteLangsCBox.Items.Add(Path.GetFileName(file));
            }

            if (deleteLangsCBox.Items.Count > 0)
            {
                deleteLangsCBox.Text = deleteLangsCBox.Items[0].ToString();
            }

            foreach (string file in Directory.GetFiles(Program.pathToMyPluginDir + "\\sensors", "*.xml"))
            {
                blockSensorsCBox.Items.Add(Path.GetFileName(file));
            }
            if (blockSensorsCBox.Items.Count > 0)
            {
                blockSensorsCBox.Text = blockSensorsCBox.Items[0].ToString();
            }

            Recurs(this, null, values, false);

        }
        #endregion

        #region SaveSettings
        // public void SaveSettings()
        public void SaveSettings()
        {
            Dictionary<string, string> values = new Dictionary<string, string>();
            Recurs(this, null, values, true);
            var str = new System.Text.StringBuilder();
            foreach (var v in values)
            {
                str.AppendLine(v.Key + "#" + v.Value);
            }
            progressTbox.Text = "";

            File.WriteAllText(Program.pathToMyPluginDir + "\\all_values.txt", str.ToString());
        }
        #endregion

        #region Recurs
        void Recurs(Control root, string path, Dictionary<string, string> values, bool save)
        {
            foreach (Control ctr in root.Controls)
            {
                string full = path + "/" + ctr.Name;
                Console.WriteLine(ctr.GetType().Name + ": " + full);

                if (save)
                {
                    string val = null;
                    if (ctr is CheckBox _CheckBox) val = _CheckBox.Checked ? "1" : "0";
                    if (ctr is ComboBox _ComboBox) val = _ComboBox.Text + "";
                    if (ctr is TextBox _TextBox) val = _TextBox.Text;
                    if (ctr is TextBox)
                    {
                        progressTbox.Text = "";
                    }
                    if (val != null)
                        values[full] = val;
                }
                else
                {
                    if (values.TryGetValue(full, out var val))
                    {
                        try
                        {
                            if (ctr is CheckBox _CheckBox) _CheckBox.Checked = val == "1";
                            if (ctr is ComboBox _ComboBox) _ComboBox.Text = val;
                            if (ctr is TextBox _TextBox) _TextBox.Text = val;
                        }
                        catch { }
                    }
                }

                Recurs(ctr, full, values, save);
            }

        }
        #endregion

        public void appendProgressTbox(Color color, string line)
        {
            int i = progressTbox.SelectionStart;
            if (progressTbox.InvokeRequired)
            {
                progressTbox.Invoke(new Action(() =>
                {
                    if ("".Equals(progressTbox.Text))
                    {
                        progressTbox.Text = line;//";
                        progressTbox.SelectionStart = i;
                        progressTbox.SelectionLength = line.Length + 1;
                        progressTbox.SelectionColor = color;
                        progressTbox.SelectionStart = progressTbox.Text.Length;
                    }
                    else
                    {
                        progressTbox.AppendText("\r\n" + line);
                        progressTbox.SelectionStart = i;
                        progressTbox.SelectionLength = line.Length + 1;
                        progressTbox.SelectionColor = color;
                        progressTbox.SelectionStart = progressTbox.Text.Length;
                    }
                }));
            }
            else
            {
                if ("".Equals(progressTbox.Text))
                {
                    progressTbox.Text = line;
                    progressTbox.SelectionStart = i;
                    progressTbox.SelectionLength = line.Length + 1;
                    progressTbox.SelectionColor = color;
                    progressTbox.SelectionStart = progressTbox.Text.Length;
                }
                else
                {
                    progressTbox.AppendText("\r\n" + line);
                    progressTbox.SelectionStart = i;
                    progressTbox.SelectionLength = line.Length + 1;
                    progressTbox.SelectionColor = color;
                    progressTbox.SelectionStart = progressTbox.Text.Length;
                }
            }

        }
        public void LoadBoxValues()
        {//Convert.ToBoolean("false");
            XmlDocument doc = new XmlDocument();
            doc.Load(Program.pathToMyPluginDir + "\\box.xml");
            XmlNode root = doc.SelectSingleNode("root");
            XmlNode settings = root.SelectSingleNode("box");
            XmlNode replaceItems = root.SelectSingleNode("replace");
            XmlNode menu = root.SelectSingleNode("menu");


            foreach (XmlNode settingsItem in settings)
            {
                switch (settingsItem.Attributes[0].Value)
                {
                    case "AddToastMessage":
                        toastMessageTBox.Text = settingsItem.InnerText;
                        break;
                }
            }

            foreach (var control in replaceGBox.Controls)
            {
                if (control is TextBox)
                {
                    foreach (XmlNode replaceItem in replaceItems.SelectNodes("item"))
                    {
                        if (!((TextBox)control).Name.Equals(replaceItem.Attributes[0].Value)) { continue; }

                        ((TextBox)control).Text = replaceItem.InnerText;
                        break;
                    }
                }
            }
            Dictionary<int, string[]> order = new Dictionary<int, string[]>();
            foreach (XmlNode menuitem in menu)
            {
                if (!menuitem.Attributes["position"].Value.Equals(""))
                {
                    order.Add(int.Parse(menuitem.Attributes["position"].Value), new string[]
                    {
                        menuitem.Attributes["checked"].Value, menuitem.InnerText
                    });
                }
            }

            List<KeyValuePair<int, string[]>> sortedOrder = order.ToList();
            sortedOrder.Sort((pair1, pair2) => pair1.Key.CompareTo(pair2.Key));

            foreach (TabPage tabpage in this.mainTabControl.TabPages)
            {
                foreach (var pair in sortedOrder)
                {//разобраться с аналитикой и ее чекбоксами
                    ((CheckBox)this.mainTabControl.Controls.Find(pair.Value[1], true)[0]).Checked = Convert.ToBoolean(pair.Value[0]);
                }
            }

            foreach (string file in Directory.GetFiles(Program.pathToMyPluginDir + "\\deleteRes", "*.xml"))
            {
                deleteLangsCBox.Items.Add(Path.GetFileName(file));
            }

            if (deleteLangsCBox.Items.Count > 0)
            {
                deleteLangsCBox.Text = deleteLangsCBox.Items[0].ToString();
            }

            foreach (string file in Directory.GetFiles(Program.pathToMyPluginDir + "\\sensors", "*.xml"))
            {
                blockSensorsCBox.Items.Add(Path.GetFileName(file));
            }
            if (blockSensorsCBox.Items.Count > 0)
            {
                blockSensorsCBox.Text = blockSensorsCBox.Items[0].ToString();
            }
        }
        //public void LoadBoxValues()
        //{
        //    XmlDocument xmlDocument = new XmlDocument();
        //    xmlDocument.Load(Program.pathToMyPluginDir + "\\box.xml");
        //    XmlNode xmlNode = xmlDocument.SelectSingleNode("root");
        //    XmlNode xmlNode2 = xmlNode.SelectSingleNode("box");
        //    XmlNode xmlNode3 = xmlNode.SelectSingleNode("replace");
        //    XmlNode xmlNode4 = xmlNode.SelectSingleNode("menu");
        //    foreach (object obj in xmlNode2)
        //    {
        //        XmlNode xmlNode5 = (XmlNode)obj;
        //        string value = xmlNode5.Attributes[0].Value;
        //        if (value == "AddToastMessage")
        //        {
        //            this.toastMessageTBox.Text = xmlNode5.InnerText;
        //        }
        //    }
        //    foreach (TextBox textBox in this.replaceGBox.Controls.OfType<TextBox>())
        //    {
        //        foreach (object obj2 in xmlNode3.SelectNodes("item"))
        //        {
        //            XmlNode xmlNode6 = (XmlNode)obj2;
        //            if (textBox.Name.Equals(xmlNode6.Attributes[0].Value))
        //            {
        //                textBox.Text = xmlNode6.InnerText;
        //                break;
        //            }
        //        }
        //    }
        //    Dictionary<int, string[]> dictionary = new Dictionary<int, string[]>();
        //    foreach (object obj3 in xmlNode4)
        //    {
        //        XmlNode xmlNode7 = (XmlNode)obj3;
        //        if (!xmlNode7.Attributes["position"].Value.Equals(""))
        //        {
        //            dictionary.Add(int.Parse(xmlNode7.Attributes["position"].Value), new string[]
        //            {
        //        xmlNode7.Attributes["checked"].Value,
        //        xmlNode7.InnerText
        //            });
        //        }
        //    }
        //    List<KeyValuePair<int, string[]>> list = dictionary.ToList<KeyValuePair<int, string[]>>();
        //    list.Sort((KeyValuePair<int, string[]> pair1, KeyValuePair<int, string[]> pair2) => pair1.Key.CompareTo(pair2.Key));
        //    foreach (TabPage tabpage in this.mainTabControl.TabPages)
        //    {
        //        foreach (KeyValuePair<int, string[]> keyValuePair in list)
        //        {
        //            ((CheckBox)this.mainTabControl.Controls.Find(keyValuePair.Value[1], true)[0]).Checked = Convert.ToBoolean(keyValuePair.Value[0]);
        //        }
        //    }
        //    foreach (string path in Directory.GetFiles(Program.pathToMyPluginDir + "\\deleteRes", "*.xml"))
        //    {
        //        this.deleteLangsCBox.Items.Add(Path.GetFileName(path));
        //    }
        //    if (this.deleteLangsCBox.Items.Count > 0)
        //    {
        //        this.deleteLangsCBox.Text = this.deleteLangsCBox.Items[0].ToString();
        //    }
        //    foreach (string path2 in Directory.GetFiles(Program.pathToMyPluginDir + "\\sensors", "*.xml"))
        //    {
        //        this.blockSensorsCBox.Items.Add(Path.GetFileName(path2));
        //    }
        //    if (this.blockSensorsCBox.Items.Count > 0)
        //    {
        //        this.blockSensorsCBox.Text = this.blockSensorsCBox.Items[0].ToString();
        //    }
        //}

        public void SaveBoxValues()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Program.pathToMyPluginDir + "\\box.xml");
            XmlNode root = doc.SelectSingleNode("root");
            XmlNode menu = root.SelectSingleNode("menu");
            menu.RemoveAll();
            Dictionary<int, string> order = new Dictionary<int, string>();
            int pos = 1;
            foreach (ListViewItem item in orderLv.Items)
            {
                if (item.Text.Contains(Language.plugin_delete_antianalytics))
                {
                    if (analyticActivityCB.Checked)
                    {
                        order.Add(pos, analyticActivityCB.Text);
                        pos++;
                    }
                    if (analyticServiceCB.Checked)
                    {
                        order.Add(pos, analyticServiceCB.Text);
                        pos++;
                    }
                    if (analyticLinksCB.Checked)
                    {
                        order.Add(pos, analyticLinksCB.Text);
                        pos++;
                    }
                    if (analyticFirebaseCB.Checked)
                    {
                        order.Add(pos, analyticFirebaseCB.Text);
                        pos++;
                    }
                    if (analyticReceiverCB.Checked)
                    {
                        order.Add(pos, analyticReceiverCB.Text);
                        pos++;
                    }
                    if (analyticLayoutCB.Checked)
                    {
                        order.Add(pos, analyticLayoutCB.Text);
                        pos++;
                    }
                    if (analyticMethodCB.Checked)
                    {
                        order.Add(pos, analyticMethodCB.Text);
                        pos++;
                    }
                }
                else
                {
                    order.Add(pos, item.Text);
                    pos++;
                }
            }
            List<CheckBox> checkboxes = new List<CheckBox>();
            GetChildren(mainTabControl, checkboxes);
            foreach (CheckBox checkBox in checkboxes)
            {
                XmlNode tmp = doc.CreateElement("menuitem");
                tmp.InnerText = checkBox.Name;
                XmlAttribute attr = doc.CreateAttribute("checked");
                attr.Value = checkBox.Checked.ToString();
                tmp.Attributes.Append(attr);
                attr = doc.CreateAttribute("position");
                attr.Value = "";
                foreach (var pair in order)
                {
                    if (pair.Value.Contains(checkBox.Text))
                    {
                        attr.Value = pair.Key.ToString();
                        break;
                    }
                }
                tmp.Attributes.Append(attr);
                menu.AppendChild(tmp);
            }
            doc.Save(Program.pathToMyPluginDir + "\\box.xml");
        }

        public void ClearBoxValues()
        {
            this.isDisabledCheckedChanged = true;
            List<CheckBox> checkboxes = new List<CheckBox>();
            List<TextBox> textBoxes = new List<TextBox>();
            List<ComboBox> comboBoxes = new List<ComboBox>();
            GetChildren<CheckBox>(mainTabControl, checkboxes);
            GetChildren<TextBox>(mainTabControl, textBoxes);
            GetChildren<ComboBox>(mainTabControl, comboBoxes);
            foreach (CheckBox checkBox in checkboxes)
            {
                checkBox.Checked = false;
            }
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = "";
                textBox.Enabled = false;
            }
            foreach (ComboBox comboBox in comboBoxes)
            {
                comboBox.SelectedIndex = 0;
                comboBox.Enabled = false;
            }
            this.progressTbox.Text = "";
            this.orderLv.Items.Clear();
            this.isDisabledCheckedChanged = false;
        }

        public void UpdateFormLanguage()
        {
            Text = Language.plugin_name + " [" + Program.ApkDir + "]";
            deleteGBox.Text = Language.plugin_delete;
            analyticGBox.Text = Language.plugin_delete_antianalytics;
            analyticActivityCB.Text = Language.analActivity;
            analyticFirebaseCB.Text = Language.analFirebase;
            analyticLayoutCB.Text = Language.analLayout;
            analyticLinksCB.Text = Language.analLinks;
            analyticMethodCB.Text = Language.analMethod;
            analyticReceiverCB.Text = Language.analReceiver;
            analyticServiceCB.Text = Language.analService;
            themesGBox.Text = Language.plugin_themes;
            themesDCB.Text = Language.plugin_themes_d;
            themesLCB.Text = Language.plugin_themes_l;
            googleMapsCB.Text = Language.googleMapsRepair;
            saveCheckboxButton.Text = Language.saveCheckboxes;
            internetCB.Text = Language.plugin_delete_internet;
            emulatorCB.Text = Language.plugin_delete_emulator;
            locationCB.Text = Language.plugin_delete_location;
            gmsCB.Text = Language.plugin_delete_gms;
            allToastsCB.Text = Language.plugin_delete_toast;
            installerGBox.Text = Language.plugin_inst;
            licenseGBox.Text = Language.plugin_license;
            signatureGBox.Text = Language.plugin_signcheck;
            binSignatureCB.Text = Language.plugin_signcheck_binsign;
            binSignatureInstallerCB.Text = Language.plugin_signcheck_binsignInst;
            allManualCB.Text = Language.plugin_replace_all_man;
            allAutoCB.Text = Language.plugin_replace_all_auto;
            timeCB.Text = Language.plugin_replace_time;
            splashGBox.Text = Language.plugin_splash;
            splashInstallCB.Text = Language.plugin_splash_inst;
            splashRemoveCB.Text = Language.plugin_splash_rem;
            otherGBox.Text = Language.plugin_other;
            installLocationCB.Text = Language.plugin_other_instlocation;
            orderLv.Columns[0].Text = Language.plugin_order_patches;
            installLocationCBox.Items.Clear();
            installLocationCBox.Items.AddRange(new object[]
            {
                "auto",
                Language.instloc_extern,
                Language.instloc_intern
            });
            minSdkCB.Text = Language.plugin_other_minsdk;
            addToastCB.Text = Language.plugin_other_toastfr;
            collectStringsButton.Text = Language.plugin_other_collectstrings;
            rootCheckCB.Text = Language.plugin_other_root;
            addSaveCB.Text = Language.plugin_other_addsave;
            fullscreenCB.Text = Language.plugin_other_fullscreen;
            hideIconCB.Text = Language.plugin_other_hide;
            visibleIconCB.Text = Language.plugin_other_visible;
            mockLocationCB.Text = Language.plugin_other_mockloc;
            dexCB.Text = Language.plugin_other_dex;
            mainTab.Text = Language.tab_main;
            toolsTab.Text = Language.tools;
            clearAll.Text = Language.clearButtonText;
            startButton.Text = Language.startQueue;
            addDebugInfoButton.Text = Language.addDebugInfo;
            helpSmaliButton.Text = Language.helpSmaliButtonText;
            noUpdateCB.Text = Language.noUpdate;
            autostartCB.Text = Language.deleteAutoStart;
            reflectionLogCB.Text = Language.refLog;
            remDebugInfoButton.Text = Language.remDebugInfo;
            openFolderButton.Text = Language.openFolder;
            authorLabel.Text = Language.author;
            versionLabel.Text = Language.version;

            taskCountLabel.Text = Language.inProcess + " [0]";
            hideIdsButton.Text = Language.listOfAllIds;
            interestingPlacesButton.Text = Language.InterestingPlaces;
            mergeStringsButton.Text = Language.mergeStrings;
            deleteResourcesCB.Text = Language.deleteRes;
            cloneCB.Text = Language.cloneApk;
            replaceGBox.Text = Language.plugin_replace;
            blockSensorsCB.Text = Language.blockSensors;
            btnSettings.Text = Language.settings;
            authorLabel2.Text = Language.authorLabel2;
            authorLabel3.Text = Language.authorLabel3;
            buildDateLabel.Text = Language.buildDate;
            mainTabPage.Text = Language.mainTabPage;
            replaceTabPage.Text = Language.replaceTabPage;
            screenshotCB.Text = Language.plugin_other_screenshot_secure;
            backKillCB.Text = Language.plugin_other_back_kill;
            backKillCBox.Items.Clear();
            backKillCBox.Items.AddRange(new object[]
            {
                Language.plugin_other_back_kill_double_tap,
                Language.plugin_other_back_kill_long_tap,
                Language.plugin_other_back_kill_one_click
            });
            tg_link.Text = Language.Link;
            tg_label.Text = Language.tg_label;
            fix18_9CB.Text = Language.plugin_other_fix_18_9;
            //
            maskCB.Text = Language.plugin_other_mask_app;
            unpackfileCB.Text = Language.plugin_other_unpack_file;
            screenOrientationCB.Text = Language.plugin_other_screen_orientation;
            screenOrientationCBox.Items.Clear();
            screenOrientationCBox.Items.AddRange(new object[]
            {
                Language.plugin_other_auto_screen_orientation,
                Language.plugin_other_landscape_screen_orientation,
                Language.plugin_other_portrait_screen_orientation
            });
            fix_auth_fb_vkCB.Text = Language.plugin_other_fix_auth_fb_vk;
            add_permissionCB.Text = Language.plugin_other_add_permission;
            add_permissionCBox.Items.Clear();
            add_permissionCBox.Items.AddRange(new object[]
            {
                Language.plugin_other_add_permission_memory,
                Language.plugin_other_add_permission_read_contact,
                Language.plugin_other_add_permission_camera,
                Language.plugin_other_add_permission_location,
                Language.plugin_other_add_permission_read_SMS,
                Language.plugin_other_add_permission_phone,
                Language.plugin_other_add_permission_calendar
            });
            res_cruptBtn.Text = Language.res_crupt;
            add_modDialogCB.Text = Language.plugin_other_add_mod_dialog;
            mask_nameLbl.Text = Language.mask_name_label;
            mask_icon_patchLbl.Text = Language.mask_icon_patch_label;
            splash_image_patchLbl.Text = Language.splash_image_patch_label;
            folder_unpackLbl.Text = Language.folder_unpack_label;
            file_unpackLbl.Text = Language.file_unpack_label;
            mod_linkLbl.Text = Language.mod_link_label;
            mod_image_nameLbl.Text = Language.mod_image_name_label;
            mod_change_log_nameLbl.Text = Language.mod_change_log_name_label;
            color_editorBtn.Text = Language.tools_color_editor;
            asmto_hexBtn.Text = Language.tools_ams_to_hex;
            check_protectBtn.Text = Language.tools_check_protect;
            mergeDexBtn.Text = Language.tools_merge_dex;
            IconGB.Text = Language.icon;
            fixcolorstartupCB.Text = Language.plugin_other_fix_color_startup;
            color_startupLbl.Text = Language.color_startup_label;
            disabledozeCB.Text = Language.plugin_other_disable_doze;
        }

        public void addOrRemLVi(string text, string tag)
        {
            bool flag = true;
            foreach (object obj in this.orderLv.Items)
            {
                ListViewItem listViewItem = (ListViewItem)obj;
                if (listViewItem.Text.EndsWith(text))
                {
                    this.orderLv.Items.Remove(listViewItem);
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                ListViewItem listViewItem2 = new ListViewItem(text);
                listViewItem2.Tag = tag;
                this.orderLv.Items.Add(listViewItem2);
            }
        }

        public void disableEnableReplace(CheckBox sender, bool tbEnable)
        {
            foreach (var control in replaceGBox.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Enabled = tbEnable;
                }
                else if (control is CheckBox)
                {
                    if (((CheckBox)control).Name.Equals("allAutoCB") || ((CheckBox)control).Name.Equals("allManualCB"))
                    {
                        continue;
                    }

                    ((CheckBox)control).Checked = false;
                    ((CheckBox)control).Enabled = !sender.Checked;
                }
            }
        }

        private void analytics_CheckedChanged(object sender, EventArgs e)
        {
            if (isDisabledCheckedChanged) { return; }

            bool add = true;
            foreach (ListViewItem item in orderLv.Items)
            {
                if (item.Text.EndsWith(Language.plugin_delete_antianalytics))
                {
                    if (!analyticActivityCB.Checked && !analyticFirebaseCB.Checked && !analyticLayoutCB.Checked && !analyticLinksCB.Checked && !analyticMethodCB.Checked && !analyticReceiverCB.Checked && !analyticServiceCB.Checked)
                    {
                        orderLv.Items.Remove(item);
                    }
                    add = false;
                    break;
                }
            }

            if (add)
            {
                ListViewItem tmp = new ListViewItem(Language.plugin_delete_antianalytics);
                tmp.Tag = "StartAntiReklalytics";
                orderLv.Items.Add(tmp);
            }
        }

        private void themes_CheckedChanged(object sender, EventArgs e)
        {
            if (isDisabledCheckedChanged) { return; }

            isDisabledCheckedChanged = true;

            CheckBox cb = (CheckBox)sender;
            switch (cb.Name)
            {
                case "themesDHMACB":
                    addOrRemLVi(cb.Text, "darkLightDHMAPatch");
                    break;
                case "themesDCB":
                    addOrRemLVi(cb.Text, "darkLightDPatch");
                    break;
                case "themesLHMACB":
                    addOrRemLVi(cb.Text, "darkLightLHMAPatch");
                    break;
                case "themesLCB":
                    addOrRemLVi(cb.Text, "darkLightLPatch");
                    break;
            }

            foreach (var control in themesGBox.Controls)
            {
                if (!((CheckBox)sender).Name.Equals(((CheckBox)control).Name))
                {
                    ((CheckBox)control).Checked = false;
                    foreach (ListViewItem item in orderLv.Items)
                    {
                        if (item.Text.EndsWith(((CheckBox)control).Text))
                        {
                            orderLv.Items.Remove(item);
                            break;
                        }
                    }
                }
            }
            isDisabledCheckedChanged = false;
        }

        private void uni_CheckedChanged(object sender, EventArgs e)
        {
            if (isDisabledCheckedChanged) { return; }

            CheckBox cb = (CheckBox)sender;
            switch (cb.Name)
            {
                case "accountCB":
                    addOrRemLVi(Language.plugin_replace + ": " + cb.Text, "AccountPatch");
                    accountTBox.Enabled = accountCB.Checked;
                    break;
                case "addSaveCB":
                    addOrRemLVi(Language.plugin_other + ": " + Language.plugin_other_addsave, "AddSavePatch");
                    break;
                case "addToastCB":
                    addOrRemLVi(Language.plugin_other + ": " + Language.plugin_other_toastfr, "toastFirstRunPatch");
                    toastMessageTBox.Enabled = addToastCB.Checked;
                    break;
                case "allAutoCB":
                    addOrRemLVi(Language.plugin_replace + ": " + Language.plugin_replace_all_auto, "dawrepAllAuto");
                    allManualCB.Checked = false;
                    allManualCB.Enabled = !allManualCB.Enabled;
                    disableEnableReplace((CheckBox)sender, false);
                    break;
                case "allManualCB":
                    addOrRemLVi(Language.plugin_replace + ": " + Language.plugin_replace_all_man, "dawrepAllManual");
                    allAutoCB.Checked = false;
                    allAutoCB.Enabled = !allAutoCB.Enabled;
                    disableEnableReplace((CheckBox)sender, cb.Checked);
                    break;
                case "androidIdCB":
                    addOrRemLVi(Language.plugin_replace + ": " + cb.Text, "AndroidIdPatch");
                    androidIdTBox.Enabled = androidIdCB.Checked;
                    break;
                case "autostartCB":
                    addOrRemLVi(Language.plugin_delete + ": " + Language.deleteAutoStart, "deleteAutostart");
                    break;
                case "binSignatureCB":
                    addOrRemLVi(Language.plugin_signcheck + ": " + Language.plugin_signcheck_binsign, "SignatureBinPatch");
                    isDisabledCheckedChanged = true;
                    foreach (ListViewItem item in orderLv.Items)
                    {
                        if (item.Text.EndsWith(binSignatureInstallerCB.Text))
                        {
                            orderLv.Items.Remove(item);
                            break;
                        }
                    }
                    binInstallerCBox.Enabled = false;
                    binSignatureInstallerCB.Checked = false;

                    isDisabledCheckedChanged = false;
                    break;
                case "binSignatureInstallerCB":
                    addOrRemLVi(Language.plugin_signcheck + ": " + Language.plugin_signcheck_binsignInst, "SignanureBinInstallerPatch");
                    isDisabledCheckedChanged = true;

                    foreach (ListViewItem item in orderLv.Items)
                    {
                        if (item.Text.EndsWith(binSignatureCB.Text))
                        {
                            orderLv.Items.Remove(item);
                            break;
                        }
                    }
                    binInstallerCBox.Enabled = binSignatureInstallerCB.Checked;
                    binSignatureCB.Checked = false;

                    isDisabledCheckedChanged = false;
                    break;
                case "bluetoothAddressCB":
                    addOrRemLVi(Language.plugin_replace + ": " + cb.Text, "BluetoothAddressPatch");
                    bluetoothAddressTBox.Enabled = bluetoothAddressCB.Checked;
                    break;
                case "bluetoothMacAddressCB":
                    addOrRemLVi(Language.plugin_replace + ": " + cb.Text, "BluetoothMacPatch");
                    bluetoothMacTBox.Enabled = bluetoothMacAddressCB.Checked;
                    break;
                case "boardCB":
                    addOrRemLVi(Language.plugin_replace + ": " + cb.Text, "BoardPatch");
                    boardTBox.Enabled = boardCB.Checked;
                    break;
                case "brandCB":
                    addOrRemLVi(Language.plugin_replace + ": " + cb.Text, "BrandPatch");
                    brandTBox.Enabled = brandCB.Checked;
                    break;
                case "bssidCB":
                    addOrRemLVi(Language.plugin_replace + ": " + cb.Text, "BssidPatch");
                    bssidTBox.Enabled = bssidCB.Checked;
                    break;
                /*case "collectStringsCB":
                    addOrRemLVi(Language.plugin_other + ": " + Language.plugin_other_collectstrings, "collectAllStrings");
                    break;*/
                case "deviceCB":
                    addOrRemLVi(Language.plugin_replace + ": " + cb.Text, "DevicePatch");
                    deviceTBox.Enabled = deviceCB.Checked;
                    break;
                case "deviceIdCB":
                    addOrRemLVi(Language.plugin_replace + ": " + cb.Text, "DeviceIdPatch");
                    deviceIdTBox.Enabled = deviceIdCB.Checked;
                    break;
                case "dexCB":
                    addOrRemLVi(Language.plugin_other + ": " + Language.plugin_other_dex, "DexExtractPatch");
                    break;
                case "emulatorCB":
                    addOrRemLVi(Language.plugin_delete + ": " + Language.plugin_delete_emulator, "EmulatorPatch");
                    break;
                case "fullscreenCB":
                    addOrRemLVi(Language.plugin_other + ": " + Language.plugin_other_fullscreen, "FullscreenPatch");
                    break;
                //case "gbannerCb":
                //addOrRemLVi(Language.plugin_delete + ": " + Language.plugin_delete_googlebanner, "GoogleBannerPatch");
                //break;
                case "gmsCB":
                    addOrRemLVi(Language.plugin_delete + ": " + Language.plugin_delete_gms, "GoogleServicesAddictionPatch");
                    break;
                case "googleMapsCB":
                    addOrRemLVi(Language.plugin_other + ": " + Language.googleMapsRepair, "RepairGoogleMaps");
                    break;
                case "gpsCB":
                    addOrRemLVi(Language.plugin_replace + ": " + cb.Text, "gpsPatch");
                    gpsLatitudeTBox.Enabled = gpsCB.Checked;
                    gpsLongitudeTBox.Enabled = gpsCB.Checked;
                    break;
                case "hideIconCB":
                    addOrRemLVi(Language.plugin_other + ": " + Language.plugin_other_hideicon, "hideIconPatch");
                    isDisabledCheckedChanged = true;
                    foreach (ListViewItem item in orderLv.Items)
                    {
                        if (item.Text.Contains(Language.plugin_other + ": " + Language.plugin_other_visibleicon))
                        {
                            orderLv.Items.Remove(item);
                            break;
                        }
                    }
                    visibleIconCB.Checked = false;
                    isDisabledCheckedChanged = false;
                    break;
                case "visibleIconCB":
                    addOrRemLVi(Language.plugin_other + ": " + Language.plugin_other_visibleicon, "visibleIconPatch");
                    isDisabledCheckedChanged = true;
                    foreach (ListViewItem item in orderLv.Items)
                    {
                        if (item.Text.Contains(Language.plugin_other + ": " + Language.plugin_other_hideicon))
                        {
                            orderLv.Items.Remove(item);
                            break;
                        }
                    }
                    hideIconCB.Checked = false;
                    isDisabledCheckedChanged = false;
                    break;
                case "installerAmazonCB":
                    addOrRemLVi(Language.plugin_inst + ": " + cb.Text, "InstallerAmazonPatch");
                    isDisabledCheckedChanged = true;
                    foreach (ListViewItem item in orderLv.Items)
                    {
                        if (item.Text.Contains(Language.plugin_inst + " Google"))
                        {
                            orderLv.Items.Remove(item);
                            break;
                        }
                    }
                    installerGoogleCB.Checked = false;
                    isDisabledCheckedChanged = false;
                    break;
                case "installerGoogleCB":
                    addOrRemLVi(Language.plugin_inst + ": " + cb.Text, "InstallerGooglePatch");
                    isDisabledCheckedChanged = true;
                    foreach (ListViewItem item in orderLv.Items)
                    {
                        if (item.Text.Contains(Language.plugin_inst + " Amazon"))
                        {
                            orderLv.Items.Remove(item);
                            break;
                        }
                    }
                    installerAmazonCB.Checked = false;
                    isDisabledCheckedChanged = false;
                    break;
                case "installLocationCB":
                    addOrRemLVi(Language.plugin_other + ": " + Language.plugin_other_instlocation, "installLocationPatch");
                    installLocationCBox.Enabled = installLocationCB.Checked;
                    break;
                case "internetCB":
                    addOrRemLVi(Language.plugin_delete + ": " + Language.plugin_delete_internet, "noInternetPatch");
                    break;
                case "ipCB":
                    addOrRemLVi(Language.plugin_replace + ": " + cb.Text, "IpPatch");
                    ipTBox.Enabled = ipCB.Checked;
                    break;
                case "licenseAmazonCB":
                    addOrRemLVi(Language.plugin_license + ": " + cb.Text, "LicenseAmazonPatch");
                    isDisabledCheckedChanged = true;
                    foreach (ListViewItem item in orderLv.Items)
                    {
                        if (item.Text.Contains(Language.plugin_license + " Google"))
                        {
                            orderLv.Items.Remove(item);
                            break;
                        }
                    }
                    licenseGoogleCB.Checked = false;
                    isDisabledCheckedChanged = false;
                    break;
                case "licenseGoogleCB":
                    addOrRemLVi(Language.plugin_license + ": " + cb.Text, "LicenseGooglePatch");
                    isDisabledCheckedChanged = true;
                    foreach (ListViewItem item in orderLv.Items)
                    {
                        if (item.Text.Contains(Language.plugin_license + " Amazon"))
                        {
                            orderLv.Items.Remove(item);
                            break;
                        }
                    }
                    licenseAmazonCB.Checked = false;
                    isDisabledCheckedChanged = false;
                    break;
                case "locationCB":
                    addOrRemLVi(Language.plugin_delete + ": " + Language.plugin_delete_location, "noLocationPatch");
                    break;
                case "manufacturerCB":
                    addOrRemLVi(Language.plugin_replace + ": " + cb.Text, "ManufacturerPatch");
                    manufacturerTBox.Enabled = manufacturerCB.Checked;
                    break;
                case "minSdkCB":
                    addOrRemLVi(Language.plugin_other + ": " + Language.plugin_other_minsdk, "changeMinSdkPatch");
                    minSdkCBox.Enabled = minSdkCB.Checked;
                    break;
                case "mockLocationCB":
                    addOrRemLVi(Language.plugin_other + ": " + Language.plugin_other_mockloc, "mockLocationPatch");
                    break;
                case "reflectionLogCB":
                    addOrRemLVi(Language.plugin_other + ": " + Language.refLog, "refLoggingPatch");
                    break;
                case "modelCB":
                    addOrRemLVi(Language.plugin_replace + ": " + cb.Text, "ModelPatch");
                    modelTBox.Enabled = modelCB.Checked;
                    break;
                case "noUpdateCB":
                    addOrRemLVi(Language.plugin_other + ": " + cb.Text, "disableAutoUpdate");
                    break;
                case "operatorCB":
                    addOrRemLVi(Language.plugin_replace + ": " + cb.Text, "OperatorPatch");
                    operatorTBox.Enabled = operatorCB.Checked;
                    break;
                case "operatorNameCB":
                    addOrRemLVi(Language.plugin_replace + ": " + cb.Text, "OperatorNamePatch");
                    operatorNameTBox.Enabled = operatorNameCB.Checked;
                    break;
                case "productCB":
                    addOrRemLVi(Language.plugin_replace + ": " + cb.Text, "ProductPatch");
                    productTBox.Enabled = productCB.Checked;
                    break;
                /*case "allReceiversCB":
                    addOrRemLVi(Language.plugin_delete + ": " + Language.plugin_delete_receiver, "ReceiverPatch");
                    break;*/
                case "rootCheckCB":
                    addOrRemLVi(Language.plugin_other + ": " + Language.plugin_other_root, "RootPatch");
                    break;
                case "serialCB":
                    addOrRemLVi(Language.plugin_replace + ": " + cb.Text, "SerialPatch");
                    serialTBox.Enabled = serialCB.Checked;
                    break;
                case "simSerialNumberCB":
                    addOrRemLVi(Language.plugin_replace + ": " + cb.Text, "SimSerialNumberPatch");
                    simSerialNumberTBox.Enabled = simSerialNumberCB.Checked;
                    break;
                case "splashInstallCB":
                    addOrRemLVi(Language.plugin_splash + ": " + Language.plugin_splash_inst, "splashInstallPatch");
                    isDisabledCheckedChanged = true;
                    foreach (ListViewItem item in orderLv.Items)
                    {
                        if (item.Text.Contains(Language.plugin_splash + ": " + Language.plugin_splash_rem))
                        {
                            orderLv.Items.Remove(item);
                            break;
                        }
                    }
                    splashRemoveCB.Checked = false;
                    isDisabledCheckedChanged = false;
                    splash_image_patchTBox.Enabled = splashInstallCB.Checked;
                    open_btn_image.Enabled = splashInstallCB.Checked;
                    break;
                case "splashRemoveCB":
                    addOrRemLVi(Language.plugin_splash + ": " + Language.plugin_splash_rem, "splashRemovePatch");
                    isDisabledCheckedChanged = true;
                    foreach (ListViewItem item in orderLv.Items)
                    {
                        if (item.Text.Contains(Language.plugin_splash + ": " + Language.plugin_splash_inst))
                        {
                            orderLv.Items.Remove(item);
                            break;
                        }
                    }
                    splashInstallCB.Checked = false;
                    isDisabledCheckedChanged = false;
                    break;
                case "subscriberIdCB":
                    addOrRemLVi(Language.plugin_replace + ": " + cb.Text, "SubscriberIdPatch");
                    subscriderIdTBox.Enabled = subscriberIdCB.Checked;
                    break;
                case "timeCB":
                    addOrRemLVi(Language.plugin_replace + ": " + cb.Text, "timeStopPatch");
                    timeTBox.Enabled = timeCB.Checked;
                    break;
                case "allToastsCB":
                    addOrRemLVi(Language.plugin_delete + ": " + Language.plugin_delete_toast, "DeleteToastsPatch");
                    break;
                case "wifiMacAddressCB":
                    addOrRemLVi(Language.plugin_replace + ": " + cb.Text, "WifiMacPatch");
                    wifiMacTBox.Enabled = wifiMacAddressCB.Checked;
                    break;
                case "countryIsoCB":
                    addOrRemLVi(Language.plugin_replace + ": " + cb.Text, "CountryIsoPatch");
                    countryIsoTBox.Enabled = countryIsoCB.Checked;
                    break;
                case "deleteResourcesCB":
                    addOrRemLVi(Language.plugin_delete + ": " + cb.Text, "deleteResourcesPatch");
                    deleteLangsCBox.Enabled = deleteResourcesCB.Checked;
                    break;
                case "cloneCB":
                    addOrRemLVi(Language.plugin_other + ": " + cb.Text, "cloneApkPatch");
                    cloneTBox.Enabled = cloneCB.Checked;
                    break;
                case "blockSensorsCB"://blockSensorsPatch
                    addOrRemLVi(Language.plugin_other + ": " + cb.Text, "blockSensorsPatch");
                    blockSensorsCBox.Enabled = blockSensorsCB.Checked;
                    break;
                case "deviceNameCB":
                    addOrRemLVi(Language.plugin_replace + ": " + cb.Text, "DeviceNamePatch");
                    deviceNameTBox.Enabled = deviceNameCB.Checked;
                    break;
                case "idCB":
                    addOrRemLVi(Language.plugin_replace + ": " + cb.Text, "IDPatch");
                    idTBox.Enabled = idCB.Checked;
                    break;
                case "imeiCB":
                    addOrRemLVi(Language.plugin_replace + ": " + cb.Text, "IMEIPatch");
                    imeiTBox.Enabled = imeiCB.Checked;
                    break;
                case "screenshotCB":
                    addOrRemLVi(Language.plugin_other + ": " + Language.plugin_other_screenshot_secure, "screenshotPatch");
                    break;
                case "backKillCB":
                    addOrRemLVi(Language.plugin_other + ": " + Language.plugin_other_back_kill, "backKillPatch");
                    backKillCBox.Enabled = backKillCB.Checked;
                    break;
                case "fix18_9CB":
                    addOrRemLVi(Language.plugin_other + ": " + Language.plugin_other_fix_18_9, "fix_18_9Patch");
                    break;
                case "maskCB":
                    addOrRemLVi(Language.plugin_other + ": " + Language.plugin_other_mask_app, "mask_appPatch");
                    mask_nameTBox.Enabled = maskCB.Checked;
                    mask_icon_patchTBox.Enabled = maskCB.Checked;
                    open_btn.Enabled = maskCB.Checked;
                    break;
                case "unpackfileCB":
                    addOrRemLVi(Language.plugin_other + ": " + Language.plugin_other_unpack_file, "unpackfilePatch");
                    folder_unpackTBox.Enabled = unpackfileCB.Checked;
                    file_unpackTBox.Enabled = unpackfileCB.Checked;
                    break;
                case "screenOrientationCB":
                    addOrRemLVi(Language.plugin_other + ": " + Language.plugin_other_screen_orientation, "screenOrientationPatch");
                    screenOrientationCBox.Enabled = screenOrientationCB.Checked;
                    break;
                case "fix_auth_fb_vkCB":
                    addOrRemLVi(Language.plugin_other + ": " + Language.plugin_other_fix_auth_fb_vk, "fix_auth_fb_vkPatch");
                    break;
                case "add_permissionCB":
                    addOrRemLVi(Language.plugin_other + ": " + Language.plugin_other_add_permission, "add_permissionPatch");
                    add_permissionCBox.Enabled = add_permissionCB.Checked;
                    break;
                case "add_modDialogCB":
                    addOrRemLVi(Language.plugin_other + ": " + Language.plugin_other_add_mod_dialog, "add_modDialogPatch");
                    mod_linkTBox.Enabled = add_modDialogCB.Checked;
                    mod_image_nameTBox.Enabled = add_modDialogCB.Checked;
                    mod_changelog_nameTBox.Enabled = add_modDialogCB.Checked;
                    break;
                case "fixcolorstartupCB":
                    addOrRemLVi(Language.plugin_other + ": " + Language.plugin_other_fix_color_startup, "FixWhiteStartupPatch");
                    colorTBox.Enabled = fixcolorstartupCB.Checked;
                    break;
                case "disabledozeCB":
                    addOrRemLVi(Language.plugin_other + ": " + Language.plugin_other_disable_doze, "disabledozePatch");
                    break;
            }
        }

        private void orderLv_ItemDrag(object sender, ItemDragEventArgs e)
        {
            this.orderLv.DoDragDrop(this.orderLv.SelectedItems[0], DragDropEffects.Move);
        }

        private void orderLv_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void orderLv_DragDrop(object sender, DragEventArgs e)
        {
            ListViewItem dragItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));

            Point ptc = orderLv.PointToClient(new Point(e.X, e.Y));
            ListViewItem insertItem = orderLv.GetItemAt(ptc.X, ptc.Y);

            if (insertItem == null) { return; }
            int insertItemIndex = insertItem.Index;
            int dragItemIndex = dragItem.Index;

            orderLv.Items.Remove(dragItem);
            if (insertItemIndex == -1)
            {
                orderLv.Items.Insert(0, dragItem);
            }
            else
            {
                orderLv.Items.Insert(insertItemIndex, dragItem);
            }
        }

        //public static void ClearControls(Control c)
        //{

        //    foreach (Control Ctrl in c.Controls)
        //    {
        //        //Console.WriteLine(Ctrl.GetType().ToString());
        //        //MessageBox.Show ( (Ctrl.GetType().ToString())) ;
        //        switch (Ctrl.GetType().ToString())

        //        {
        //            case "System.Windows.Forms.CheckBox":
        //                ((CheckBox)Ctrl).Checked = false;
        //                break;

        //            case "System.Windows.Forms.TextBox":
        //                ((TextBox)Ctrl).Text = "";
        //                break;

        //            case "System.Windows.Forms.RichTextBox":
        //                ((RichTextBox)Ctrl).Text = "";
        //                break;

        //            case "System.Windows.Forms.ComboBox":
        //                ((ComboBox)Ctrl).SelectedIndex = -1;
        //                break;

        //            case "System.Windows.Forms.MaskedTextBox":

        //                ((MaskedTextBox)Ctrl).Text = "";
        //                break;

        //            default:
        //                if (Ctrl.Controls.Count > 0)
        //                    ClearControls(Ctrl);
        //                break;

        //        }

        //    }
        //}

        private void clearBoxes_Click(object sender, EventArgs e)
        {
            ClearBoxValues();
        }

        private static void GetChildren<T>(Control aParent, List<T> aList) where T : Control
        {
            aList.AddRange(aParent.Controls.OfType<T>());
            foreach (Control c in aParent.Controls)
            {
                GetChildren<T>(c, aList);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (orderLv.Items.Count == 0) { return; }

            new Task(() =>
            {
                if (Settings.deleteDebug)
                {
                    Utils.DelDebugLogFile();

                }

                if ("".Equals(Program.processApkPath))
                {
                    MessageBox.Show(Language.openFolderError, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] dirs;

                if (Program.processApkPath.EndsWith("_INPUT_APK"))
                {
                    dirs = Directory.GetDirectories(Program.processApkPath);
                }
                else
                {
                    if (!Directory.Exists(Program.processApkPath))
                    {
                        MessageBox.Show(Program.processApkPath + Language.errorMsgNotExist, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    dirs = new string[] { Program.processApkPath };
                }
                if (dirs.Length == 0)
                {
                    MessageBox.Show(Language.emptyInputApk, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //==========
                Stopwatch watch = new Stopwatch();
                watch.Start();

                foreach (ListViewItem item in orderLv.Items)
                {
                    item.BackColor = Color.SkyBlue;
                    foreach (string path in dirs)
                    {
                        appendProgressTbox(Color.Blue, item.Text + " (" + Patcher.TrimPathToInput(path) + ")");

                        //запуск метода по его имени
                        MethodInfo mInfo = typeof(Patcher).GetMethod(item.Tag.ToString());
                        ParameterExpression param = Expression.Parameter(typeof(string), path);
                        MethodCallExpression mExpr = Expression.Call(mInfo, param);
                        Expression<Action<string>> lambdaAct = Expression.Lambda<Action<string>>(mExpr, new ParameterExpression[] { param });
                        Action<string> patch = lambdaAct.Compile();
                        patch(path);
                    }
                    item.BackColor = Color.GreenYellow;
                }
                watch.Stop();
                appendProgressTbox(Color.Red, ":::::" + Language.orderDone + " (" + String.Format("{0:00}:{1:00}:{2:00}.{3:00}", watch.Elapsed.Hours, watch.Elapsed.Minutes, watch.Elapsed.Seconds, watch.Elapsed.Milliseconds / 10) + ")" + ":::::");
                MessageBox.Show(Language.orderDone + " (" + String.Format("{0:00}:{1:00}:{2:00}.{3:00}", watch.Elapsed.Hours, watch.Elapsed.Minutes, watch.Elapsed.Seconds, watch.Elapsed.Milliseconds / 10) + ")", Language.orderDone, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }).Start();
            //==========
        }

        private void helpSmaliButton_Click(object sender, EventArgs e)
        {
            if ("".Equals(Program.processApkPath))
            {
                MessageBox.Show(Language.openFolderError, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            new Task(() =>
            {
                string[] dirs;
                if (Program.processApkPath.EndsWith("_INPUT_APK"))
                {
                    dirs = Directory.GetDirectories(Program.processApkPath);
                }
                else
                {
                    if (!Directory.Exists(Program.processApkPath))
                    {
                        MessageBox.Show(Program.processApkPath + Language.errorMsgNotExist, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    dirs = new string[] { Program.processApkPath };
                }
                foreach (string path in dirs)
                {
                    Patcher.addSecondaryInfo(path);
                }
            }).Start();
        }

        private void addDebugInfoButton_Click(object sender, EventArgs e)
        {
            if ("".Equals(Program.processApkPath))
            {
                MessageBox.Show(Language.openFolderError, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            new Task(() =>
            {
                string[] dirs;
                if (Program.processApkPath.EndsWith("_INPUT_APK"))
                {
                    dirs = Directory.GetDirectories(Program.processApkPath);
                }
                else
                {
                    if (!Directory.Exists(Program.processApkPath))
                    {
                        MessageBox.Show(Program.processApkPath + Language.errorMsgNotExist, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    dirs = new string[] { Program.processApkPath };
                }
                foreach (string path in dirs)
                {
                    Patcher.addDebugInfo(path);
                }
            }).Start();
        }

        private void linkLabelAutor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://4pda.ru/forum/index.php?showuser=1921586");
        }

        private void linkLabelAutor2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://4pda.ru/forum/index.php?showuser=7932053");
        }

        private void yanMoneyLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://money.yandex.ru/to/410012549752425");
        }

        private void new_author2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://4pda.ru/forum/index.php?showuser=6390713");
        }

        private void tg_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://t.me/ClubModApk");
        }

        private void remDebugInfoButton_Click(object sender, EventArgs e)
        {
            if ("".Equals(Program.processApkPath))
            {
                MessageBox.Show(Language.openFolderError, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            new Task(() =>
            {
                string[] dirs;
                if (Program.processApkPath.EndsWith("_INPUT_APK"))
                {
                    dirs = Directory.GetDirectories(Program.processApkPath);
                }
                else
                {
                    if (!Directory.Exists(Program.processApkPath))
                    {
                        MessageBox.Show(Program.processApkPath + Language.errorMsgNotExist, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    dirs = new string[] { Program.processApkPath };
                }
                foreach (string path in dirs)
                {
                    Patcher.remDebugInfo(path);
                }
            }).Start();
        }

        private void saveCheckboxButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
            //return;
            //  SaveBoxValues();
        }

        private void openFoldersButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = Program.pathToBatchapktool + "\\_INPUT_APK\\";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                Program.ApkDir = selectedPath.Substring(selectedPath.LastIndexOf("\\") + 1, selectedPath.Length - selectedPath.LastIndexOf("\\") - 1);
                Program.processApkPath = folderBrowserDialog.SelectedPath;
                this.Text = Language.plugin_name + " [" + Program.ApkDir + "]";
                Patcher.getAppInfo(Program.processApkPath);
            }
        }

        private void collectStringsButton_Click(object sender, EventArgs e)
        {
            if ("".Equals(Program.processApkPath))
            {
                MessageBox.Show(Language.openFolderError, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            new Task(() =>
            {
                string[] dirs;

                if (Program.processApkPath.EndsWith("_INPUT_APK"))
                {
                    dirs = Directory.GetDirectories(Program.processApkPath);
                }
                else
                {
                    if (!Directory.Exists(Program.processApkPath))
                    {
                        MessageBox.Show(Program.processApkPath + Language.errorMsgNotExist, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    dirs = new string[] { Program.processApkPath };
                }
                if (dirs.Length == 0)
                {
                    MessageBox.Show(Language.emptyInputApk, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (string path in dirs)
                {
                    Patcher.collectAllStrings(path);
                }
            }).Start();
        }

        private void hideIdsButton_Click(object sender, EventArgs e)
        {
            if ("".Equals(Program.processApkPath))
            {
                MessageBox.Show(Language.openFolderError, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            new Task(() =>
            {
                LayoutIdsForm form = new LayoutIdsForm();
                List<Dictionary<string, Dictionary<string, string>>> ids = new List<Dictionary<string, Dictionary<string, string>>>();
                string[] dirs;

                if (Program.processApkPath.EndsWith("_INPUT_APK"))
                {
                    dirs = Directory.GetDirectories(Program.processApkPath);
                }
                else
                {
                    if (!Directory.Exists(Program.processApkPath))
                    {
                        MessageBox.Show(Program.processApkPath + Language.errorMsgNotExist, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    dirs = new string[] { Program.processApkPath };
                }
                if (dirs.Length == 0)
                {
                    MessageBox.Show(Language.emptyInputApk, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (string path in dirs)
                {
                    ids.Add(Patcher.getAllIds(path));
                }

                if (ids.Count == 0) { return; }

                form.loadIds(ids);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //MessageBox.Show(form.getChecked().Count.ToString());//
                    //получил список id, которые надо скрыть
                    Patcher.hideAllChecked(form.getChecked());
                }
            }).Start();
        }

        private void interestingPlacesButton_Click(object sender, EventArgs e)
        {
            if ("".Equals(Program.processApkPath))
            {
                MessageBox.Show(Language.openFolderError, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            new Task(() =>
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                appendProgressTbox(Color.Green, ":::::" + Language.log_interesing_placed + ":::::");
                InterestingPlacesForm form = new InterestingPlacesForm();
                List<Dictionary<string, Dictionary<int, string>>> places = new List<Dictionary<string, Dictionary<int, string>>>();
                string[] dirs;

                if (Program.processApkPath.EndsWith("_INPUT_APK"))
                {
                    dirs = Directory.GetDirectories(Program.processApkPath);
                }
                else
                {
                    if (!Directory.Exists(Program.processApkPath))
                    {
                        MessageBox.Show(Program.processApkPath + Language.errorMsgNotExist, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    dirs = new string[] { Program.processApkPath };
                }
                if (dirs.Length == 0)
                {
                    MessageBox.Show(Language.emptyInputApk, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (string path in dirs)
                {
                    places.Add(Patcher.findInterestingPlaces(path));
                }

                if (places.Count == 0) { return; }

                form.LoadPlaces(places);
                // appendProgressTbox(":::::Search Interesing Places has started: Done!!!:::::");
                appendProgressTbox(Color.Red, ":::::" + Language.log_interesing_done + " (" + String.Format("{0:00}:{1:00}:{2:00}.{3:00}", watch.Elapsed.Hours, watch.Elapsed.Minutes, watch.Elapsed.Seconds, watch.Elapsed.Milliseconds / 10) + ")" + ":::::");
                form.ShowDialog();
            }).Start();

        }

        private void mergeStringsButton_Click(object sender, EventArgs e)
        {
            new MergeStringsForm().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Language.debug_message_height + base.Size.Height.ToString() + Language.debug_message_width + base.Size.Width.ToString(), Language.debug_message);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000;   // Turn off WS_CLIPCHILDREN
                return parms;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            new HelpForm().ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (new SettingsForm().ShowDialog() == DialogResult.OK)
            {
                RestartMessage();
            }
        }

        private void RestartMessage()
        {
            DialogResult result = MessageBox.Show(
                         Language.plugin_restart_message, Language.plugin_restart,
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
            if (result == DialogResult.OK)
                //Start a new instance of the current program
                Process.Start(Application.ExecutablePath);
            //close the current application process
            Process.GetCurrentProcess().Kill();
        }

        private void Changelog_btn_Click(object sender, EventArgs e)
        {
            new ChangelogForm().ShowDialog();
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            // OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "*.png|*.png|*.jpg|.*jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                mask_icon_patchTBox.Text = openFileDialog.FileName;
            }
        }

        private void res_cruptBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "*.apk|*.apk";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                new Task(() =>
                 {
                     string ApkPatch = openFileDialog.FileName;
                     Patcher.resCrupt(ApkPatch);
                 }).Start();
            }
        }

        private void eggs_picture_Click(object sender, EventArgs e)
        {
            if (eggs == 11)
            {
                MessageBox.Show("Осталось 12 кликов.");
            }
            if (eggs == 21)
            {
                MessageBox.Show("Осталось 3 клика.");
            }
            if (eggs != 24)
            {
                eggs++;
                return;
            }
            MessageBox.Show("Поздравляю! Вы обнаружили пасхалку!");
            if (eggs == 24)
            {
                res_cruptBtn.Visible = true;
                obfuscate_lib_btn.Visible = true;
            }
            eggs = 0;
        }

        private void open_btn_image_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "*.png|*.png|*.jpg|.*jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                splash_image_patchTBox.Text = openFileDialog.FileName;
            }
        }

        private void obfuscate_lib_btn_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "*.so|*.so";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string SoPatch = openFileDialog.FileName;
                Patcher.LibObfuscated(SoPatch);
            }
        }

        private void color_editorBtn_Click(object sender, EventArgs e)
        {
            //    //new ColorEditor().Show();
            if ("".Equals(Program.processApkPath))
            {
                MessageBox.Show(Language.openFolderError, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            new Task(() =>
            {
                ColorEditorForm form = new ColorEditorForm();
                List<Dictionary<string, Dictionary<string, string>>> color = new List<Dictionary<string, Dictionary<string, string>>>();
                string[] dirs;

                if (Program.processApkPath.EndsWith("_INPUT_APK"))
                {
                    dirs = Directory.GetDirectories(Program.processApkPath);
                }
                else
                {
                    if (!Directory.Exists(Program.processApkPath))
                    {
                        MessageBox.Show(Program.processApkPath + Language.errorMsgNotExist, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    dirs = new string[] { Program.processApkPath };
                }
                if (dirs.Length == 0)
                {
                    MessageBox.Show(Language.emptyInputApk, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (string path in dirs)
                {
                    color.Add(Patcher.getAllColors(path));
                }

                if (color.Count == 0) { return; }

                form.loadColors(color);
                form.ShowDialog();
            }).Start();
        }

        private void asmto_hexBtn_Click(object sender, EventArgs e)
        {
            new AsmToHexArmForm().ShowDialog();
        }

        private void check_protectBtn_Click(object sender, EventArgs e)
        {
            //      new CheckProtect().ShowDialog();
            if ("".Equals(Program.processApkPath))
            {
                MessageBox.Show(Language.openFolderError, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // new Task(() =>
            // {
            //     Stopwatch watch = new Stopwatch();
            //     watch.Start();
            //     appendProgressTbox(Color.FromArgb(0, 160, 176), ":::::" + Language.log_interesing_placed + ":::::");
            //     string[] dirs;
            ////     CheckProtect check = new CheckProtect();
            //     if (Program.processApkPath.EndsWith("_INPUT_APK"))
            //     {
            //         dirs = Directory.GetDirectories(Program.processApkPath);
            //     }
            //     else
            //     {
            //         if (!Directory.Exists(Program.processApkPath))
            //         {
            //             MessageBox.Show(Program.processApkPath + Language.errorMsgNotExist, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //             return;
            //         }
            //         dirs = new string[] { Program.processApkPath };
            //     }
            //     if (dirs.Length == 0)
            //     {
            //         MessageBox.Show(Language.emptyInputApk, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //         return;
            //     }
            //     foreach (string path in dirs)
            //     {

            //     }
            //     string d = Program.processApkPath;

            //    // check.checkProtect(d);
            //       //  check.ShowDialog();
            // }).Start();
            new CheckProtectForm().ShowDialog();
        }

        //горячие клавиши
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)//Ctrl+S Настройки
            {
                btnSettings_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.F1)//F1 Помощь
            {
                btnHelp_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.N)//Ctrl+N Начало патчинга
            {
                startButton_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.O)//Ctrl+O Открытие проэекта
            {
                openFoldersButton_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.X)//Ctrl+X Закрытие патчера
            {
                this.Close();
                e.SuppressKeyPress = true;
            }
        }

        private void progressTbox_TextChanged(object sender, EventArgs e)
        {
            //автопрокрутка ричтекстбокса при наполнении его текстом
            progressTbox.SelectionStart = progressTbox.Text.Length;
            progressTbox.ScrollToCaret();
        }

        private void mergeDexBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Dex File|*.dex";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var dx = string.Join(" ", openFileDialog.FileNames);
                Patcher.mergeDex(dx, Path.GetDirectoryName(openFileDialog.FileName));
            }
        }

        //значения комбоксов по-умолчанию
        private void defaultCombobox()
        {
            deleteLangsCBox.SelectedIndex = 0;
            binInstallerCBox.SelectedIndex = 0;
            installLocationCBox.SelectedIndex = 0;
            minSdkCBox.SelectedIndex = 0;
            blockSensorsCBox.SelectedIndex = 0;
            backKillCBox.SelectedIndex = 0;
            screenOrientationCBox.SelectedIndex = 0;
            add_permissionCBox.SelectedIndex = 0;
        }

        private void smali_colorBtn_Click(object sender, EventArgs e)
        {
            new SmaliColorForm().Show();
        }
    }
}
