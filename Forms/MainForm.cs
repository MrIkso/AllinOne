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
using AllInOne.Forms;
using AllInOne.Logic;

namespace AllInOne.Forms
{

    public partial class MainForm : Form
    {
        private bool isDisabledCheckedChanged;
        public string version = "7.0b3";

        public MainForm()
        {
            this.isDisabledCheckedChanged = false;
            this.InitializeComponent();
            DateTime buildDate = new FileInfo(Assembly.GetExecutingAssembly().Location).LastWriteTime;
            //Несработал этот метод
            //Version version = Assembly.GetExecutingAssembly().GetName().Version;
            //DateTime buildDate = new DateTime(2000, 1, 1).AddDays(version.Build).AddSeconds(version.Revision * 2);
            this.lblBuild.Text = buildDate.ToString();
            this.lblVersion.Text = version;
            if (!Program.standalone)
            {
                this.openFolderButton.Visible = false;
                this.orderLv.Height = 336;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            base.Location = Properties.Settings.Default.WindowLocation;
            Size windowSize = Properties.Settings.Default.WindowSize;
            base.Size = Properties.Settings.Default.WindowSize;
            base.WindowState = Properties.Settings.Default.WindowState;
            this.LoadBoxValues();
            this.UpdateFormLanguage();
            this.openFolderButton.Visible = Program.standalone;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(Program.pathToMyPluginDir + "\\box.xml");
            XmlNode xmlNode = xmlDocument.SelectSingleNode("root");
            foreach (object obj in xmlNode.SelectSingleNode("box"))
            {
                XmlNode xmlNode2 = (XmlNode)obj;
                string value = xmlNode2.Attributes[0].Value;
                if (value == "AddToastMessage")
                {
                    xmlNode2.InnerText = this.toastMessageTBox.Text;
                }
            }
            XmlNode xmlNode3 = xmlNode.SelectSingleNode("replace");
            xmlNode3.RemoveAll();
            foreach (object obj2 in this.replaceGBox.Controls)
            {
                if (obj2 is TextBox)
                {
                    XmlNode xmlNode4 = xmlDocument.CreateElement("item");
                    XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("name");
                    xmlAttribute.Value = ((TextBox)obj2).Name;
                    xmlNode4.Attributes.Append(xmlAttribute);
                    xmlNode4.InnerText = ((TextBox)obj2).Text;
                    xmlNode3.AppendChild(xmlNode4);
                }
            }
            xmlDocument.Save(Program.pathToMyPluginDir + "\\box.xml");
            if (base.WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.WindowSize = base.Size;
                Properties.Settings.Default.WindowLocation = base.Location;
            }
            else
            {
                Properties.Settings.Default.WindowSize = base.RestoreBounds.Size;
            }
            Properties.Settings.Default.WindowState = base.WindowState;
            Properties.Settings.Default.Save();
        }

        //#region LoadSettings
        //public void LoadSettings()
        //{
        //    Dictionary<string, string> values = new Dictionary<string, string>();
        //    if (System.IO.File.Exists("Settings.txt"))
        //    {
        //       var lines= System.IO.File.ReadAllLines("Settings.txt");
        //        foreach (var s in lines)
        //        {
        //            if (s.IndexOf("#") > 0)
        //            {
        //                values[s.Substring(0, s.IndexOf('#'))]= s.Substring(s.IndexOf('#') + 1);
        //            }
        //        }
        //    }
        //    Recurs(this,null, values,false);

        //}
        //#endregion

        //#region SaveSettings
        //public void SaveSettings()
        //{
        //    Dictionary<string, string> values = new Dictionary<string, string>();
        //    Recurs(this, null, values, true);
        //    System.Text.StringBuilder str = new System.Text.StringBuilder();
        //    foreach (var v in values)
        //    {
        //        str.AppendLine(v.Key + "#" + v.Value);
        //    }

        //    System.IO.File.WriteAllText("Settings.txt", str.ToString());
        //}
        //#endregion

        //#region Recurs
        //void Recurs(Control root, string path, Dictionary<string, string> values, bool save)
        //{
        //    foreach (Control ctr in root.Controls)
        //    {
        //        string full = path + "/" + ctr.Name;
        //        Console.WriteLine(ctr.GetType().Name + ": " + full);

        //        if (save)
        //        {
        //            string val = null;
        //            if (ctr is CheckBox _CheckBox) val = _CheckBox.Checked ? "1" : "0";
        //            if (ctr is ComboBox _ComboBox) val = _ComboBox.Text+"";
        //            if (ctr is TextBox _TextBox) val = _TextBox.Text;
        //            if (val != null)
        //                values[full] = val;
        //        }
        //        else
        //        {
        //            if (values.TryGetValue(full, out var val))
        //            {
        //                try
        //                {
        //                    if (ctr is CheckBox _CheckBox) _CheckBox.Checked = val == "1";
        //                    if (ctr is ComboBox _ComboBox) _ComboBox.Text = val;
        //                    if (ctr is TextBox _TextBox) _TextBox.Text = val;
        //                }
        //                catch { }
        //            }
        //        }

        //        Recurs(ctr, full, values, save);
        //    }

        //}
        //#endregion

        public void appendProgressTbox(string line)
        {
            if (progressTbox.InvokeRequired)
            {
                progressTbox.Invoke(new Action(() =>
                {
                    if ("".Equals(progressTbox.Text))
                    {
                        progressTbox.Text = line;
                    }
                    else
                    {
                        progressTbox.AppendText("\r\n" + line);
                    }
                }));
            }
            else
            {
                if ("".Equals(progressTbox.Text))
                {
                    progressTbox.Text = line;
                }
                else
                {
                    progressTbox.AppendText("\r\n" + line);
                }
            }

        }

        public void LoadBoxValues()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(Program.pathToMyPluginDir + "\\box.xml");
            XmlNode xmlNode = xmlDocument.SelectSingleNode("root");
            XmlNode xmlNode2 = xmlNode.SelectSingleNode("box");
            XmlNode xmlNode3 = xmlNode.SelectSingleNode("replace");
            XmlNode xmlNode4 = xmlNode.SelectSingleNode("menu");
            foreach (object obj in xmlNode2)
            {
                XmlNode xmlNode5 = (XmlNode)obj;
                string value = xmlNode5.Attributes[0].Value;
                if (value == "AddToastMessage")
                {
                    this.toastMessageTBox.Text = xmlNode5.InnerText;
                }
            }
            foreach (TextBox textBox in this.replaceGBox.Controls.OfType<TextBox>())
            {
                foreach (object obj2 in xmlNode3.SelectNodes("item"))
                {
                    XmlNode xmlNode6 = (XmlNode)obj2;
                    if (textBox.Name.Equals(xmlNode6.Attributes[0].Value))
                    {
                        textBox.Text = xmlNode6.InnerText;
                        break;
                    }
                }
            }
            Dictionary<int, string[]> dictionary = new Dictionary<int, string[]>();
            foreach (object obj3 in xmlNode4)
            {
                XmlNode xmlNode7 = (XmlNode)obj3;
                if (!xmlNode7.Attributes["position"].Value.Equals(""))
                {
                    dictionary.Add(int.Parse(xmlNode7.Attributes["position"].Value), new string[]
                    {
                xmlNode7.Attributes["checked"].Value,
                xmlNode7.InnerText
                    });
                }
            }
            List<KeyValuePair<int, string[]>> list = dictionary.ToList<KeyValuePair<int, string[]>>();
            list.Sort((KeyValuePair<int, string[]> pair1, KeyValuePair<int, string[]> pair2) => pair1.Key.CompareTo(pair2.Key));
            foreach (TabPage tabpage in this.mainTabControl.TabPages)
            {
                foreach (KeyValuePair<int, string[]> keyValuePair in list)
                {
                    ((CheckBox)this.mainTabControl.Controls.Find(keyValuePair.Value[1], true)[0]).Checked = Convert.ToBoolean(keyValuePair.Value[0]);
                }
            }
            foreach (string path in Directory.GetFiles(Program.pathToMyPluginDir + "\\deleteRes", "*.xml"))
            {
                this.deleteLangsCBox.Items.Add(Path.GetFileName(path));
            }
            if (this.deleteLangsCBox.Items.Count > 0)
            {
                this.deleteLangsCBox.Text = this.deleteLangsCBox.Items[0].ToString();
            }
            foreach (string path2 in Directory.GetFiles(Program.pathToMyPluginDir + "\\sensors", "*.xml"))
            {
                this.blockSensorsCBox.Items.Add(Path.GetFileName(path2));
            }
            if (this.blockSensorsCBox.Items.Count > 0)
            {
                this.blockSensorsCBox.Text = this.blockSensorsCBox.Items[0].ToString();
            }
        }

        public void SaveBoxValues()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(Program.pathToMyPluginDir + "\\box.xml");
            XmlNode xmlNode = xmlDocument.SelectSingleNode("root").SelectSingleNode("menu");
            xmlNode.RemoveAll();
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            int num = 0;
            foreach (object obj in this.orderLv.Items)
            {
                ListViewItem listViewItem = (ListViewItem)obj;
                if (listViewItem.Text.Contains(Language.plugin_delete_antianalytics))
                {
                    if (this.analyticActivityCB.Checked)
                    {
                        dictionary.Add(num, this.analyticActivityCB.Text);
                        num++;
                    }
                    if (this.analyticServiceCB.Checked)
                    {
                        dictionary.Add(num, this.analyticServiceCB.Text);
                        num++;
                    }
                    if (this.analyticLinksCB.Checked)
                    {
                        dictionary.Add(num, this.analyticLinksCB.Text);
                        num++;
                    }
                    if (this.analyticFirebaseCB.Checked)
                    {
                        dictionary.Add(num, this.analyticFirebaseCB.Text);
                        num++;
                    }
                    if (this.analyticReceiverCB.Checked)
                    {
                        dictionary.Add(num, this.analyticReceiverCB.Text);
                        num++;
                    }
                    if (this.analyticLayoutCB.Checked)
                    {
                        dictionary.Add(num, this.analyticLayoutCB.Text);
                        num++;
                    }
                    if (this.analyticMethodCB.Checked)
                    {
                        dictionary.Add(num, this.analyticMethodCB.Text);
                        num++;
                    }
                }
                else
                {
                    dictionary.Add(num, listViewItem.Text);
                    num++;
                }
            }
            List<CheckBox> checkboxes = new List<CheckBox>();
            GetChildren<CheckBox>(mainTabControl, checkboxes);
            foreach (CheckBox checkBox in checkboxes)
            {
                XmlNode xmlNode2 = xmlDocument.CreateElement("menuitem");
                xmlNode2.InnerText = checkBox.Name;
                XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("checked");
                xmlAttribute.Value = checkBox.Checked.ToString();
                xmlNode2.Attributes.Append(xmlAttribute);
                xmlAttribute = xmlDocument.CreateAttribute("position");
                xmlAttribute.Value = "";
                foreach (KeyValuePair<int, string> keyValuePair in dictionary)
                {
                    string[] array = keyValuePair.Value.Split(new char[]
                    {
                        ':'
                    });
                    if (string.Compare((array.Count<string>() == 1) ? array[0].Trim() : array[1].Trim(), checkBox.Text) == 0)
                    {
                        xmlAttribute.Value = keyValuePair.Key.ToString();
                        break;
                    }
                }
                xmlNode2.Attributes.Append(xmlAttribute);
                xmlNode.AppendChild(xmlNode2);


            }
            xmlDocument.Save(Program.pathToMyPluginDir + "\\box.xml");
        }

        public void ClearBoxValues()
        {
            //ClearControls(mainTabControl);
            this.isDisabledCheckedChanged = true;
            List<CheckBox> checkboxes = new List<CheckBox>();
            List<TextBox> textBoxes = new List<TextBox>();
            List<ComboBox> comboBoxes = new List<ComboBox>();
            GetChildren<CheckBox>(mainTabControl, checkboxes);
            GetChildren<TextBox>(mainTabControl, textBoxes);
            GetChildren<ComboBox>(mainTabControl, comboBoxes);
            //checkboxes.ForEach(ch => ch.Checked = false);
            //textBoxes.ForEach(tb => tb.Text = "");
            //foreach (Control control in GetChildTextBoxes<CheckBox>(groupBox))
            //{

            // TextBox textBox;
            // ComboBox comboBox;

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
            this.Text = Language.plugin_name + " [" + Program.ApkDir + "]";
            this.deleteGBox.Text = Language.plugin_delete;
            this.analyticGBox.Text = Language.plugin_delete_antianalytics;
            this.analyticActivityCB.Text = Language.analActivity;
            this.analyticFirebaseCB.Text = Language.analFirebase;
            this.analyticLayoutCB.Text = Language.analLayout;
            this.analyticLinksCB.Text = Language.analLinks;
            this.analyticMethodCB.Text = Language.analMethod;
            this.analyticReceiverCB.Text = Language.analReceiver;
            this.analyticServiceCB.Text = Language.analService;
            this.themesGBox.Text = Language.plugin_themes;
            this.themesDCB.Text = Language.plugin_themes_d;
            this.themesLCB.Text = Language.plugin_themes_l;
            this.googleMapsCB.Text = Language.googleMapsRepair;
            this.saveCheckboxButton.Text = Language.saveCheckboxes;
            this.internetCB.Text = Language.plugin_delete_internet;
            this.emulatorCB.Text = Language.plugin_delete_emulator;
            this.locationCB.Text = Language.plugin_delete_location;
            this.gmsCB.Text = Language.plugin_delete_gms;
            this.allToastsCB.Text = Language.plugin_delete_toast;
            this.installerGBox.Text = Language.plugin_inst;
            this.licenseGBox.Text = Language.plugin_license;
            this.signatureGBox.Text = Language.plugin_signcheck;
            this.binSignatureCB.Text = Language.plugin_signcheck_binsign;
            this.binSignatureInstallerCB.Text = Language.plugin_signcheck_binsignInst;
            this.allManualCB.Text = Language.plugin_replace_all_man;
            this.allAutoCB.Text = Language.plugin_replace_all_auto;
            this.timeCB.Text = Language.plugin_replace_time;
            this.splashGBox.Text = Language.plugin_splash;
            this.splashInstallCB.Text = Language.plugin_splash_inst;
            this.splashRemoveCB.Text = Language.plugin_splash_rem;
            this.otherGBox.Text = Language.plugin_other;
            this.installLocationCB.Text = Language.plugin_other_instlocation;
            this.orderLv.Columns[0].Text = Language.plugin_order_patches;
            this.installLocationCBox.Items.Clear();
            this.installLocationCBox.Items.AddRange(new object[]
            {
                "auto",
                Language.instloc_extern,
                Language.instloc_intern
            });
            this.minSdkCB.Text = Language.plugin_other_minsdk;
            this.addToastCB.Text = Language.plugin_other_toastfr;
            this.collectStringsButton.Text = Language.plugin_other_collectstrings;
            this.rootCheckCB.Text = Language.plugin_other_root;
            this.addSaveCB.Text = Language.plugin_other_addsave;
            this.fullscreenCB.Text = Language.plugin_other_fullscreen;
            this.hideIconCB.Text = Language.plugin_other_hideicon;
            this.mockLocationCB.Text = Language.plugin_other_mockloc;
            this.dexCB.Text = Language.plugin_other_dex;
            this.mainTab.Text = Language.tab_main;
            this.toolsTab.Text = Language.tools;
            this.clearAll.Text = Language.clearButtonText;
            this.startButton.Text = Language.startQueue;
            this.addDebugInfoButton.Text = Language.addDebugInfo;
            this.helpSmaliButton.Text = Language.helpSmaliButtonText;
            this.noUpdateCB.Text = Language.noUpdate;
            this.autostartCB.Text = Language.deleteAutoStart;
            this.reflectionLogCB.Text = Language.refLog;
            this.remDebugInfoButton.Text = Language.remDebugInfo;
            this.openFolderButton.Text = Language.openFolder;
            this.authorLabel.Text = Language.author;
            this.versionLabel.Text = Language.version;
            this.donateLabel.Text = Language.donate;
            this.yandexMoneyLabel.Text = Language.yandexMoney;
            this.yanMoneyLink.Text = Language.Link;
            this.taskCountLabel.Text = Language.inProcess + " [0]";
            this.hideIdsButton.Text = Language.listOfAllIds;
            this.interestingPlacesButton.Text = Language.InterestingPlaces;
            this.mergeStringsButton.Text = Language.mergeStrings;
            this.deleteResourcesCB.Text = Language.deleteRes;
            this.cloneCB.Text = Language.cloneApk;
            this.replaceGBox.Text = Language.plugin_replace;
            this.blockSensorsCB.Text = Language.blockSensors;
            this.btnSettings.Text = Language.settings;
            this.authorLabel2.Text = Language.authorLabel2;
            this.authorLabel3.Text = Language.authorLabel3;
            this.buildDateLabel.Text = Language.buildDate;
            this.mainTabPage.Text = Language.mainTabPage;
            this.replaceTabPage.Text = Language.replaceTabPage;
            this.screenshotCB.Text = Language.plugin_other_screenshot_secure;
            this.backKillCB.Text = Language.plugin_other_back_kill;
            this.backKillCBox.Items.Clear();
            this.backKillCBox.Items.AddRange(new object[]
            {
                Language.plugin_other_back_kill_double_tap,
                Language.plugin_other_back_kill_long_tap,
                Language.plugin_other_back_kill_one_click
            });
            //this.btnHelp.Text = Language.helpbutton;

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
            foreach (object obj in this.replaceGBox.Controls)
            {
                if (obj is TextBox)
                {
                    ((TextBox)obj).Enabled = tbEnable;
                }
                else if (obj is CheckBox && !((CheckBox)obj).Name.Equals("allAutoCB") && !((CheckBox)obj).Name.Equals("allManualCB"))
                {
                    ((CheckBox)obj).Checked = false;
                    ((CheckBox)obj).Enabled = !sender.Checked;
                }
            }
        }

        private void analytics_CheckedChanged(object sender, EventArgs e)
        {
            if (this.isDisabledCheckedChanged)
            {
                return;
            }
            bool flag = true;
            foreach (object obj in this.orderLv.Items)
            {
                ListViewItem listViewItem = (ListViewItem)obj;
                if (listViewItem.Text.EndsWith(Language.plugin_delete_antianalytics))
                {
                    if (!this.analyticActivityCB.Checked && !this.analyticFirebaseCB.Checked && !this.analyticLayoutCB.Checked && !this.analyticLinksCB.Checked && !this.analyticMethodCB.Checked && !this.analyticReceiverCB.Checked && !this.analyticServiceCB.Checked)
                    {
                        this.orderLv.Items.Remove(listViewItem);
                    }
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                ListViewItem listViewItem2 = new ListViewItem(Language.plugin_delete_antianalytics);
                listViewItem2.Tag = "StartAntiReklalytics";
                this.orderLv.Items.Add(listViewItem2);
            }
        }

        private void themes_CheckedChanged(object sender, EventArgs e)
        {
            if (this.isDisabledCheckedChanged)
            {
                return;
            }
            this.isDisabledCheckedChanged = true;
            CheckBox checkBox = (CheckBox)sender;
            string name = checkBox.Name;
            if (!(name == "themesDHMACB"))
            {
                if (!(name == "themesDCB"))
                {
                    if (!(name == "themesLHMACB"))
                    {
                        if (name == "themesLCB")
                        {
                            this.addOrRemLVi(checkBox.Text, "darkLightLPatch");
                        }
                    }
                    else
                    {
                        this.addOrRemLVi(checkBox.Text, "darkLightLHMAPatch");
                    }
                }
                else
                {
                    this.addOrRemLVi(checkBox.Text, "darkLightDPatch");
                }
            }
            else
            {
                this.addOrRemLVi(checkBox.Text, "darkLightDHMAPatch");
            }
            foreach (object obj in this.themesGBox.Controls)
            {
                if (!((CheckBox)sender).Name.Equals(((CheckBox)obj).Name))
                {
                    ((CheckBox)obj).Checked = false;
                    foreach (object obj2 in this.orderLv.Items)
                    {
                        ListViewItem listViewItem = (ListViewItem)obj2;
                        if (listViewItem.Text.EndsWith(((CheckBox)obj).Text))
                        {
                            this.orderLv.Items.Remove(listViewItem);
                            break;
                        }
                    }
                }
            }
            this.isDisabledCheckedChanged = false;
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
            ListViewItem listViewItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
            Point point = this.orderLv.PointToClient(new Point(e.X, e.Y));
            ListViewItem itemAt = this.orderLv.GetItemAt(point.X, point.Y);
            if (itemAt == null)
            {
                return;
            }
            int index = itemAt.Index;
            int index2 = listViewItem.Index;
            this.orderLv.Items.Remove(listViewItem);
            if (index == -1)
            {
                this.orderLv.Items.Insert(0, listViewItem);
                return;
            }
            this.orderLv.Items.Insert(index, listViewItem);
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
                    Patcher.DelDebugLogFile();

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
                        appendProgressTbox(item.Text + " (" + Patcher.TrimPathToInput(path) + ")");

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
                appendProgressTbox(":::::" + Language.orderDone + " (" + String.Format("{0:00}:{1:00}:{2:00}.{3:00}", watch.Elapsed.Hours, watch.Elapsed.Minutes, watch.Elapsed.Seconds, watch.Elapsed.Milliseconds / 10) + ")" + ":::::");
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
            //SaveSettings();
            //return;
            SaveBoxValues();
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
                appendProgressTbox(":::::" + Language.log_interesing_placed + ":::::");
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
                appendProgressTbox(":::::" + Language.log_interesing_done + " (" + String.Format("{0:00}:{1:00}:{2:00}.{3:00}", watch.Elapsed.Hours, watch.Elapsed.Minutes, watch.Elapsed.Seconds, watch.Elapsed.Milliseconds / 10) + ")" + ":::::");
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
                CreateParams createParams = base.CreateParams;
                createParams.Style &= -33554433;
                return createParams;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            new HelpForm().ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (
            new SettingsForm().ShowDialog() == DialogResult.OK)

            {
                RestartMessage();
                // this.UpdateFormLanguage();
                //this.Refresh();
                // MainForm_Load(null, EventArgs.Empty);
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


    }
}
