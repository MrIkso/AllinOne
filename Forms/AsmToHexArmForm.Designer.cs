namespace AllInOne.Forms
{
    partial class AsmToHexArmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsmToHexArmForm));
            this.pseudocode_lbl = new System.Windows.Forms.Label();
            this.arm_hexLbl = new System.Windows.Forms.Label();
            this.thumb_textLbl = new System.Windows.Forms.Label();
            this.tips = new System.Windows.Forms.Label();
            this.resultGBox = new System.Windows.Forms.GroupBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.ArmTbox = new System.Windows.Forms.TextBox();
            this.thumbTBox = new System.Windows.Forms.TextBox();
            this.pseudocodeTbox = new System.Windows.Forms.TextBox();
            this.convert_btn = new System.Windows.Forms.Button();
            this.resultGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pseudocode_lbl
            // 
            this.pseudocode_lbl.AutoSize = true;
            this.pseudocode_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pseudocode_lbl.Location = new System.Drawing.Point(13, 13);
            this.pseudocode_lbl.Name = "pseudocode_lbl";
            this.pseudocode_lbl.Size = new System.Drawing.Size(130, 18);
            this.pseudocode_lbl.TabIndex = 0;
            this.pseudocode_lbl.Text = "Asm Pseudocode:";
            // 
            // arm_hexLbl
            // 
            this.arm_hexLbl.AutoSize = true;
            this.arm_hexLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arm_hexLbl.Location = new System.Drawing.Point(58, 106);
            this.arm_hexLbl.Name = "arm_hexLbl";
            this.arm_hexLbl.Size = new System.Drawing.Size(69, 18);
            this.arm_hexLbl.TabIndex = 1;
            this.arm_hexLbl.Text = "Arm Hex:";
            // 
            // thumb_textLbl
            // 
            this.thumb_textLbl.AutoSize = true;
            this.thumb_textLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thumb_textLbl.Location = new System.Drawing.Point(69, 36);
            this.thumb_textLbl.Name = "thumb_textLbl";
            this.thumb_textLbl.Size = new System.Drawing.Size(58, 18);
            this.thumb_textLbl.TabIndex = 2;
            this.thumb_textLbl.Text = "Thumb:";
            // 
            // tips
            // 
            this.tips.AutoSize = true;
            this.tips.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tips.Location = new System.Drawing.Point(69, 190);
            this.tips.Name = "tips";
            this.tips.Size = new System.Drawing.Size(31, 18);
            this.tips.TabIndex = 3;
            this.tips.Text = "tips";
            // 
            // resultGBox
            // 
            this.resultGBox.Controls.Add(this.clearBtn);
            this.resultGBox.Controls.Add(this.ArmTbox);
            this.resultGBox.Controls.Add(this.thumbTBox);
            this.resultGBox.Controls.Add(this.thumb_textLbl);
            this.resultGBox.Controls.Add(this.tips);
            this.resultGBox.Controls.Add(this.arm_hexLbl);
            this.resultGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultGBox.Location = new System.Drawing.Point(16, 99);
            this.resultGBox.Name = "resultGBox";
            this.resultGBox.Size = new System.Drawing.Size(511, 233);
            this.resultGBox.TabIndex = 4;
            this.resultGBox.TabStop = false;
            this.resultGBox.Text = "Result";
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearBtn.Location = new System.Drawing.Point(400, 82);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(111, 36);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clear_Click);
            // 
            // ArmTbox
            // 
            this.ArmTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArmTbox.Location = new System.Drawing.Point(136, 106);
            this.ArmTbox.Multiline = true;
            this.ArmTbox.Name = "ArmTbox";
            this.ArmTbox.ReadOnly = true;
            this.ArmTbox.Size = new System.Drawing.Size(258, 80);
            this.ArmTbox.TabIndex = 8;
            // 
            // thumbTBox
            // 
            this.thumbTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thumbTBox.Location = new System.Drawing.Point(136, 20);
            this.thumbTBox.Multiline = true;
            this.thumbTBox.Name = "thumbTBox";
            this.thumbTBox.ReadOnly = true;
            this.thumbTBox.Size = new System.Drawing.Size(258, 80);
            this.thumbTBox.TabIndex = 7;
            // 
            // pseudocodeTbox
            // 
            this.pseudocodeTbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pseudocodeTbox.Location = new System.Drawing.Point(149, 13);
            this.pseudocodeTbox.Multiline = true;
            this.pseudocodeTbox.Name = "pseudocodeTbox";
            this.pseudocodeTbox.Size = new System.Drawing.Size(258, 80);
            this.pseudocodeTbox.TabIndex = 5;
            // 
            // convert_btn
            // 
            this.convert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.convert_btn.Location = new System.Drawing.Point(413, 32);
            this.convert_btn.Name = "convert_btn";
            this.convert_btn.Size = new System.Drawing.Size(114, 36);
            this.convert_btn.TabIndex = 6;
            this.convert_btn.Text = "Convert";
            this.convert_btn.UseVisualStyleBackColor = true;
            this.convert_btn.Click += new System.EventHandler(this.convert_Click);
            // 
            // AsmToHexArm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 336);
            this.Controls.Add(this.convert_btn);
            this.Controls.Add(this.pseudocodeTbox);
            this.Controls.Add(this.resultGBox);
            this.Controls.Add(this.pseudocode_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AsmToHexArm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asm to HEX Arm Converter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AsmToHexArm_FormClosing);
            this.Load += new System.EventHandler(this.AsmToHexArm_Load);
            this.resultGBox.ResumeLayout(false);
            this.resultGBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pseudocode_lbl;
        private System.Windows.Forms.Label arm_hexLbl;
        private System.Windows.Forms.Label thumb_textLbl;
        private System.Windows.Forms.Label tips;
        private System.Windows.Forms.GroupBox resultGBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox ArmTbox;
        private System.Windows.Forms.TextBox thumbTBox;
        private System.Windows.Forms.TextBox pseudocodeTbox;
        private System.Windows.Forms.Button convert_btn;
    }
}