using System;
using System.Drawing;
using System.Windows.Forms;
using AllInOne.Logic;

namespace AllInOne.Forms
{
    public partial class MergeStringsForm : Form
    {
        public MergeStringsForm()
        {
            InitializeComponent();
            fromLabel.Text = Language.mergeFrom;
            toLabel.Text = Language.mergeTo;
            replaceCB.Text = Language.mergeWithReplace;
            this.Text = Language.mergeStrings;
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog select = new OpenFileDialog();
            select.Multiselect = false;
            select.InitialDirectory = Program.pathToBatchapktool + "\\_INPUT_APK";
            select.Filter = "strings.xml file|*.xml";
            if(select.ShowDialog()==DialogResult.OK)
            {
                switch(((Button)sender).Name)
                {
                    case "selectFromFileButton":
                        fromTBox.Text = select.FileName;
                        break;
                    case "selectToFileButton":
                        toTBox.Text = select.FileName;
                        break;
                }
            }
        }

        private void mergeButton_Click(object sender, EventArgs e)
        {
            if("".Equals(fromTBox.Text) || "".Equals(toTBox.Text)) { return; }
            Patcher.mainf.appendProgressTbox(Color.Blue, ":::::" + Language.log_merge_string + ":::::");
            Patcher.mergeXml(new string[] { fromTBox.Text }, toTBox.Text, replaceCB.Checked);
            //Patcher.mergeStrings(fromTBox.Text, toTBox.Text, replaceCB.Checked);
            Patcher.mainf.appendProgressTbox(Color.Red, ":::::" + Language.log_merge_string_done + ":::::");
            Close();
        }
    }
}
