using System;
using System.IO;
using System.Windows.Forms;
using AllInOne.Logic;

namespace AllInOne.Forms
{
    public partial class ChangelogForm : Form
    {
        public ChangelogForm()
        {
            InitializeComponent();
            try
            { 
                using (StreamReader sr = new StreamReader(Program.pathToMyPluginDir + "//Changelog.txt"))
                {
                    String line = sr.ReadToEnd();
                    changelogBox.Text = line;
                } 
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
                changelogBox.Text = ex.Message;
            }
        }

        private void changelogBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }
}
