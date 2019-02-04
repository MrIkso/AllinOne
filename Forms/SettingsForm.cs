using AllInOne.Logic;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace AllInOne.Forms
{
    public partial class SettingsForm : Form
    {
        public static bool assets_files;
        public static bool lib_files;
        public static bool write_debug;
        public static bool delete_debug;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
           
                XmlDocument doc = new XmlDocument();
                doc.Load(Program.pathToMyPluginDir + "\\settings.xml");
                XmlNode root = doc.SelectSingleNode("root");
                XmlNode settings = root.SelectSingleNode("settings");

                for (int i = 0; i < settings.ChildNodes.Count; i++)
                {
                    XmlNode settingsItem = settings.ChildNodes[i];
                    if (settingsItem.NodeType == XmlNodeType.Comment) { continue; }
                    if (settingsItem.Attributes.Count == 0)
                        continue;

                    switch (settingsItem.Attributes[0].Value)
                    {
                        case "GoogleMapsApiKey":
                            settingsItem.InnerText = this.api_key_textBox.Text;
                            break;
                        case "ReplaceLinksTo":
                            settingsItem.InnerText = this.replace_link_textBox.Text;
                            break;
                        case "textEditorPath":
                            settingsItem.InnerText = this.text_editor_textBox.Text;
                            break;
                        case "taskCount":
                            settingsItem.InnerText = this.task_textBox.Text;
                            break;
                        case "textEditorArgs":
                        settingsItem.InnerText = this.textEditorArgsComboBox.Text;
                       // settingsItem.InnerText = this.text_editor_args_textBox.Text;
                            break;
                        case "searchAssetsFiles":
                            settingsItem.InnerText = assets_files.ToString();
                            break;
                        case "searchLibFiles":
                            settingsItem.InnerText = lib_files.ToString();
                            break;
                    case "debug":
                        settingsItem.InnerText = write_debug.ToString();
                        break;
                    case "delDebugLog":
                        settingsItem.InnerText = delete_debug.ToString();
                        break;
                    case "language":

                            if (this.lang_Box.SelectedIndex >= 0)
                            {
                                settingsItem.InnerText = this.lang_Box.Items[this.lang_Box.SelectedIndex].ToString();
                            }

                            string selectedState = lang_Box.SelectedItem.ToString();
                            break;
                    }
                doc.Save(Program.pathToMyPluginDir + "\\settings.xml");
               // RestartMessage();

                }
           
            //Language.Load(Settings.language);
            //Settings.Load();
            //this.UpdateFormLanguage();
            //Close();
        }
    
      
        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
                LoadSettings();
                UpdateFormLanguage();
        }

        private void write_debug_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            SettingsForm.write_debug = write_debug_checkBox.Checked;
        }

        private void del_debug_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            SettingsForm.delete_debug = del_debug_checkBox.Checked;
        }

        private void asset_files_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            SettingsForm.assets_files = asset_files_checkBox.Checked;
        }

        private void lib_files_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            SettingsForm.lib_files = lib_files_checkBox.Checked;
        }

        private void task_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void open_txt_editor_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "*.exe|*.exe";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                text_editor_textBox.Text = openFileDialog.FileName;
            }
        }

        public void LoadSettings()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Program.pathToMyPluginDir + "\\settings.xml");
            XmlNode root = doc.SelectSingleNode("root");
            XmlNode settings = root.SelectSingleNode("settings");

            foreach (XmlNode settingsItem in settings)
            {
                if (settingsItem.NodeType == XmlNodeType.Comment) { continue; }
                switch (settingsItem.Attributes[0].Value)
                {
                case "GoogleMapsApiKey":
                    this.api_key_textBox.Text = settingsItem.InnerText;
                    break;
                case "ReplaceLinksTo":
                    this.replace_link_textBox.Text = settingsItem.InnerText;
                    break;
                case "textEditorPath":
                    this.text_editor_textBox.Text = settingsItem.InnerText;
                    break;
                case "taskCount":
                    this.task_textBox.Text = settingsItem.InnerText;
                    break;
                case "textEditorArgs":
                        this.textEditorArgsComboBox.Text = settingsItem.InnerText;
                    break;
                case "searchAssetsFiles":
                    this.asset_files_checkBox.Checked = Boolean.Parse(settingsItem.InnerText);
                    break;
                case "searchLibFiles":
                    this.lib_files_checkBox.Checked = Boolean.Parse(settingsItem.InnerText);
                    break;
               case "debug":
                   this.write_debug_checkBox.Checked = Boolean.Parse(settingsItem.InnerText);
                   break;
               case "delDebugLog":
                    this.del_debug_checkBox.Checked = Boolean.Parse(settingsItem.InnerText);
                    break;
                case "language":
                   {
                   int ind = 0;

                     foreach (string path in Directory.GetFiles(Program.pathToMyPluginDir + "\\language", "*.xml"))
                     {
                        if (settingsItem.InnerText == Path.GetFileNameWithoutExtension(path))
                            ind = this.lang_Box.Items.Count;
                            this.lang_Box.Items.Add(Path.GetFileNameWithoutExtension(path));

                     }
                       bool flag = this.lang_Box.Items.Count > 0;
                       if (flag)
                       {
                                this.lang_Box.SelectedIndex = ind;
                       }
                   }
                    break;

                }
            }
        }

        public void UpdateFormLanguage()
        {
            Text = Language.settings;
          //  save_btn.Name = Language.save_button;
            close_btn.Text = Language.closeSettings_button;
            KeyLabel.Text = Language.mapskey;
            AdsLinkLabel.Text = Language.adslink;
            TxtEditorLabel.Text = Language.texteditorpatch;
            TaskCountLabel.Text = Language.tskcount;
            TxtEditorOptions.Text = Language.texteditoroptions;
            asset_files_checkBox.Text = Language.search_asset;
            lib_files_checkBox.Text = Language.search_lib;
            write_debug_checkBox.Text = Language.writeDebug;
            del_debug_checkBox.Text = Language.deleteDebug;
            LanguageLabel.Text = Language.language;
        }  
    }
}
