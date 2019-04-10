namespace AllInOne.Forms
{
    partial class SmaliColorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmaliColorForm));
            this.colorPanel = new System.Windows.Forms.Panel();
            this.toHexBtn = new System.Windows.Forms.Button();
            this.smali_valueTB = new System.Windows.Forms.TextBox();
            this.hex_valueTB = new System.Windows.Forms.TextBox();
            this.hex_value1TB = new System.Windows.Forms.TextBox();
            this.toSmaliBtn = new System.Windows.Forms.Button();
            this.smali_value1TB = new System.Windows.Forms.TextBox();
            this.smali_valueLB = new System.Windows.Forms.Label();
            this.hex_valueLB = new System.Windows.Forms.Label();
            this.hex_value1LB = new System.Windows.Forms.Label();
            this.smali_value1LB = new System.Windows.Forms.Label();
            this.previewLb = new System.Windows.Forms.Label();
            this.colorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorPanel
            // 
            this.colorPanel.Controls.Add(this.previewLb);
            this.colorPanel.Location = new System.Drawing.Point(343, 12);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(200, 188);
            this.colorPanel.TabIndex = 0;
            // 
            // toHexBtn
            // 
            this.toHexBtn.Location = new System.Drawing.Point(109, 65);
            this.toHexBtn.Name = "toHexBtn";
            this.toHexBtn.Size = new System.Drawing.Size(88, 39);
            this.toHexBtn.TabIndex = 0;
            this.toHexBtn.Text = "To Hex";
            this.toHexBtn.UseVisualStyleBackColor = true;
            this.toHexBtn.Click += new System.EventHandler(this.toHexBtn_Click);
            // 
            // smali_valueTB
            // 
            this.smali_valueTB.Location = new System.Drawing.Point(12, 37);
            this.smali_valueTB.Name = "smali_valueTB";
            this.smali_valueTB.Size = new System.Drawing.Size(100, 22);
            this.smali_valueTB.TabIndex = 0;
            // 
            // hex_valueTB
            // 
            this.hex_valueTB.Location = new System.Drawing.Point(189, 37);
            this.hex_valueTB.Name = "hex_valueTB";
            this.hex_valueTB.Size = new System.Drawing.Size(100, 22);
            this.hex_valueTB.TabIndex = 1;
            // 
            // hex_value1TB
            // 
            this.hex_value1TB.Location = new System.Drawing.Point(12, 131);
            this.hex_value1TB.Name = "hex_value1TB";
            this.hex_value1TB.Size = new System.Drawing.Size(100, 22);
            this.hex_value1TB.TabIndex = 2;
            // 
            // toSmaliBtn
            // 
            this.toSmaliBtn.Location = new System.Drawing.Point(109, 159);
            this.toSmaliBtn.Name = "toSmaliBtn";
            this.toSmaliBtn.Size = new System.Drawing.Size(88, 39);
            this.toSmaliBtn.TabIndex = 3;
            this.toSmaliBtn.Text = "To Smali";
            this.toSmaliBtn.UseVisualStyleBackColor = true;
            this.toSmaliBtn.Click += new System.EventHandler(this.toSmaliBtn_Click);
            // 
            // smali_value1TB
            // 
            this.smali_value1TB.Location = new System.Drawing.Point(189, 131);
            this.smali_value1TB.Name = "smali_value1TB";
            this.smali_value1TB.Size = new System.Drawing.Size(100, 22);
            this.smali_value1TB.TabIndex = 4;
            // 
            // smali_valueLB
            // 
            this.smali_valueLB.AutoSize = true;
            this.smali_valueLB.Location = new System.Drawing.Point(9, 12);
            this.smali_valueLB.Name = "smali_valueLB";
            this.smali_valueLB.Size = new System.Drawing.Size(86, 17);
            this.smali_valueLB.TabIndex = 0;
            this.smali_valueLB.Text = "Smali Value:";
            // 
            // hex_valueLB
            // 
            this.hex_valueLB.AutoSize = true;
            this.hex_valueLB.Location = new System.Drawing.Point(186, 12);
            this.hex_valueLB.Name = "hex_valueLB";
            this.hex_valueLB.Size = new System.Drawing.Size(76, 17);
            this.hex_valueLB.TabIndex = 5;
            this.hex_valueLB.Text = "Hex Value:";
            // 
            // hex_value1LB
            // 
            this.hex_value1LB.AutoSize = true;
            this.hex_value1LB.Location = new System.Drawing.Point(12, 111);
            this.hex_value1LB.Name = "hex_value1LB";
            this.hex_value1LB.Size = new System.Drawing.Size(76, 17);
            this.hex_value1LB.TabIndex = 6;
            this.hex_value1LB.Text = "Hex Value:";
            // 
            // smali_value1LB
            // 
            this.smali_value1LB.AutoSize = true;
            this.smali_value1LB.Location = new System.Drawing.Point(186, 111);
            this.smali_value1LB.Name = "smali_value1LB";
            this.smali_value1LB.Size = new System.Drawing.Size(86, 17);
            this.smali_value1LB.TabIndex = 7;
            this.smali_value1LB.Text = "Smali Value:";
            // 
            // previewLb
            // 
            this.previewLb.AutoSize = true;
            this.previewLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.previewLb.Location = new System.Drawing.Point(68, 67);
            this.previewLb.Name = "previewLb";
            this.previewLb.Size = new System.Drawing.Size(88, 25);
            this.previewLb.TabIndex = 6;
            this.previewLb.Text = "Preview";
            // 
            // SmaliColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 212);
            this.Controls.Add(this.smali_value1LB);
            this.Controls.Add(this.hex_value1LB);
            this.Controls.Add(this.hex_valueLB);
            this.Controls.Add(this.smali_valueLB);
            this.Controls.Add(this.smali_value1TB);
            this.Controls.Add(this.toSmaliBtn);
            this.Controls.Add(this.hex_value1TB);
            this.Controls.Add(this.hex_valueTB);
            this.Controls.Add(this.smali_valueTB);
            this.Controls.Add(this.toHexBtn);
            this.Controls.Add(this.colorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SmaliColorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smali Color";
            this.colorPanel.ResumeLayout(false);
            this.colorPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Button toHexBtn;
        private System.Windows.Forms.TextBox smali_valueTB;
        private System.Windows.Forms.TextBox hex_valueTB;
        private System.Windows.Forms.TextBox hex_value1TB;
        private System.Windows.Forms.Button toSmaliBtn;
        private System.Windows.Forms.TextBox smali_value1TB;
        private System.Windows.Forms.Label smali_valueLB;
        private System.Windows.Forms.Label hex_valueLB;
        private System.Windows.Forms.Label hex_value1LB;
        private System.Windows.Forms.Label smali_value1LB;
        private System.Windows.Forms.Label previewLb;
    }
}