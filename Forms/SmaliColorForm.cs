using System;
using System.Drawing;
using System.Windows.Forms;
using AllInOne.Logic.Util;

namespace AllInOne.Forms
{
    public partial class SmaliColorForm : Form
    {
        public SmaliColorForm()
        {
            InitializeComponent();
        }

        private void toHexBtn_Click(object sender, EventArgs e)
        {
            hex_valueTB.Text = Utils.convertSmaliColorToHex(smali_valueTB.Text);
            colorPanel.BackColor = ColorTranslator.FromHtml("#" + hex_valueTB.Text);
        }

        private void toSmaliBtn_Click(object sender, EventArgs e)
        {
            smali_value1TB.Text = Utils.convertHexColorToSmali(hex_value1TB.Text);
            colorPanel.BackColor = ColorTranslator.FromHtml("#" + hex_value1TB.Text);
        }
    }
}
