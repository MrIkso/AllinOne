namespace AllInOne.Forms
{
    // Token: 0x02000005 RID: 5
    public partial class HelpForm : global::System.Windows.Forms.Form
    {
        // Token: 0x0600001A RID: 26 RVA: 0x0000215D File Offset: 0x0000035D
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x0600001B RID: 27 RVA: 0x00004518 File Offset: 0x00002718
        private void InitializeComponent()
        {
            this.richTxtHelp = new global::System.Windows.Forms.RichTextBox();
            base.SuspendLayout();
            this.richTxtHelp.Dock = global::System.Windows.Forms.DockStyle.Fill;
            this.richTxtHelp.Location = new global::System.Drawing.Point(0, 0);
            this.richTxtHelp.Margin = new global::System.Windows.Forms.Padding(30, 3, 3, 3);
            this.richTxtHelp.Name = "richTxtHelp";
            this.richTxtHelp.ReadOnly = true;
            this.richTxtHelp.Size = new global::System.Drawing.Size(800, 692);
            this.richTxtHelp.TabIndex = 0;
            this.richTxtHelp.Text = "";
            base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
            base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new global::System.Drawing.Size(800, 692);
            base.Controls.Add(this.richTxtHelp);
            this.MinimumSize = new global::System.Drawing.Size(400, 200);
            base.Name = "frmHelp";
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AllInOne Help";
            base.Load += new global::System.EventHandler(this.frmHelp_Load);
            base.ResumeLayout(false);
        }

        // Token: 0x04000029 RID: 41
        private global::System.ComponentModel.IContainer components;

        // Token: 0x0400002A RID: 42
        private global::System.Windows.Forms.RichTextBox richTxtHelp;
    }
}
