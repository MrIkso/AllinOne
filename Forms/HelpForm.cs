using System;
using System.IO;
using System.Windows.Forms;
using AllInOne.Logic;

namespace AllInOne.Forms
{
    public partial class HelpForm : Form
	{
		public HelpForm()
		{
			this.InitializeComponent();
		}
		private void frmHelp_Load(object sender, EventArgs e)
		{
			try
			{
				this.richTxtHelp.LoadFile(Program.pathToMyPluginDir + "//help.rtf", RichTextBoxStreamType.RichText);
				this.richTxtHelp.SelectAll();
				this.richTxtHelp.SelectionIndent = 12;
				this.richTxtHelp.DeselectAll();
			}
			catch (IOException ex)
			{
                MessageBox.Show(ex.Message, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
                this.richTxtHelp.Text = ex.Message;
			}
		}

        private void richTxtHelp_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }
}
