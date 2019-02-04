namespace AllInOne.Forms
{
    partial class MergeStringsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MergeStringsForm));
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromTBox = new System.Windows.Forms.TextBox();
            this.toTBox = new System.Windows.Forms.TextBox();
            this.replaceCB = new System.Windows.Forms.CheckBox();
            this.mergeButton = new System.Windows.Forms.Button();
            this.selectFromFileButton = new System.Windows.Forms.Button();
            this.selectToFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(12, 9);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(46, 13);
            this.fromLabel.TabIndex = 0;
            this.fromLabel.Text = "Откуда:";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(24, 38);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(34, 13);
            this.toLabel.TabIndex = 1;
            this.toLabel.Text = "Куда:";
            // 
            // fromTBox
            // 
            this.fromTBox.Location = new System.Drawing.Point(64, 6);
            this.fromTBox.Name = "fromTBox";
            this.fromTBox.Size = new System.Drawing.Size(379, 20);
            this.fromTBox.TabIndex = 2;
            // 
            // toTBox
            // 
            this.toTBox.Location = new System.Drawing.Point(64, 35);
            this.toTBox.Name = "toTBox";
            this.toTBox.Size = new System.Drawing.Size(379, 20);
            this.toTBox.TabIndex = 3;
            // 
            // replaceCB
            // 
            this.replaceCB.AutoSize = true;
            this.replaceCB.Location = new System.Drawing.Point(64, 65);
            this.replaceCB.Name = "replaceCB";
            this.replaceCB.Size = new System.Drawing.Size(131, 17);
            this.replaceCB.TabIndex = 4;
            this.replaceCB.Text = "С заменой перевода";
            this.replaceCB.UseVisualStyleBackColor = true;
            // 
            // mergeButton
            // 
            this.mergeButton.Location = new System.Drawing.Point(368, 61);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(75, 23);
            this.mergeButton.TabIndex = 5;
            this.mergeButton.Text = "OK";
            this.mergeButton.UseVisualStyleBackColor = true;
            this.mergeButton.Click += new System.EventHandler(this.mergeButton_Click);
            // 
            // selectFromFileButton
            // 
            this.selectFromFileButton.Location = new System.Drawing.Point(449, 3);
            this.selectFromFileButton.Name = "selectFromFileButton";
            this.selectFromFileButton.Size = new System.Drawing.Size(23, 23);
            this.selectFromFileButton.TabIndex = 6;
            this.selectFromFileButton.Text = "...";
            this.selectFromFileButton.UseVisualStyleBackColor = true;
            this.selectFromFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // selectToFileButton
            // 
            this.selectToFileButton.Location = new System.Drawing.Point(449, 33);
            this.selectToFileButton.Name = "selectToFileButton";
            this.selectToFileButton.Size = new System.Drawing.Size(23, 23);
            this.selectToFileButton.TabIndex = 7;
            this.selectToFileButton.Text = "...";
            this.selectToFileButton.UseVisualStyleBackColor = true;
            this.selectToFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // mergeStringsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 90);
            this.Controls.Add(this.selectToFileButton);
            this.Controls.Add(this.selectFromFileButton);
            this.Controls.Add(this.mergeButton);
            this.Controls.Add(this.replaceCB);
            this.Controls.Add(this.toTBox);
            this.Controls.Add(this.fromTBox);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mergeStringsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перенос перевода из одного strings.xml в другой";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.TextBox fromTBox;
        private System.Windows.Forms.TextBox toTBox;
        private System.Windows.Forms.CheckBox replaceCB;
        private System.Windows.Forms.Button mergeButton;
        private System.Windows.Forms.Button selectFromFileButton;
        private System.Windows.Forms.Button selectToFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}