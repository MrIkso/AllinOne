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
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("Changelog.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
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

    }
}
