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
            this.richTxtHelp = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTxtHelp
            // 
            this.richTxtHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtHelp.Location = new System.Drawing.Point(0, 0);
            this.richTxtHelp.Margin = new System.Windows.Forms.Padding(40, 4, 4, 4);
            this.richTxtHelp.Name = "richTxtHelp";
            this.richTxtHelp.ReadOnly = true;
            this.richTxtHelp.Size = new System.Drawing.Size(1067, 852);
            this.richTxtHelp.TabIndex = 0;
            this.richTxtHelp.Text = "";
            this.richTxtHelp.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTxtHelp_LinkClicked);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 852);
            this.Controls.Add(this.richTxtHelp);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(527, 235);
            this.Name = "HelpForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AllInOne Help";
            this.Load += new System.EventHandler(this.frmHelp_Load);
            this.ResumeLayout(false);

        }

        // Token: 0x04000029 RID: 41
        private global::System.ComponentModel.IContainer components;

        // Token: 0x0400002A RID: 42
        private global::System.Windows.Forms.RichTextBox richTxtHelp;
    }
}
