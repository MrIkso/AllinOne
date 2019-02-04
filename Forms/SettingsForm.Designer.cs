namespace AllInOne.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.api_key_textBox = new System.Windows.Forms.TextBox();
            this.replace_link_textBox = new System.Windows.Forms.TextBox();
            this.text_editor_textBox = new System.Windows.Forms.TextBox();
            this.asset_files_checkBox = new System.Windows.Forms.CheckBox();
            this.lib_files_checkBox = new System.Windows.Forms.CheckBox();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.AdsLinkLabel = new System.Windows.Forms.Label();
            this.TxtEditorLabel = new System.Windows.Forms.Label();
            this.TaskCountLabel = new System.Windows.Forms.Label();
            this.task_textBox = new System.Windows.Forms.TextBox();
            this.lang_Box = new System.Windows.Forms.ComboBox();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.TxtEditorOptions = new System.Windows.Forms.Label();
            this.open_txt_editor_btn = new System.Windows.Forms.Button();
            this.textEditorArgsComboBox = new System.Windows.Forms.ComboBox();
            this.del_debug_checkBox = new System.Windows.Forms.CheckBox();
            this.write_debug_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // api_key_textBox
            // 
            resources.ApplyResources(this.api_key_textBox, "api_key_textBox");
            this.api_key_textBox.Name = "api_key_textBox";
            // 
            // replace_link_textBox
            // 
            resources.ApplyResources(this.replace_link_textBox, "replace_link_textBox");
            this.replace_link_textBox.Name = "replace_link_textBox";
            // 
            // text_editor_textBox
            // 
            resources.ApplyResources(this.text_editor_textBox, "text_editor_textBox");
            this.text_editor_textBox.Name = "text_editor_textBox";
            // 
            // asset_files_checkBox
            // 
            resources.ApplyResources(this.asset_files_checkBox, "asset_files_checkBox");
            this.asset_files_checkBox.Name = "asset_files_checkBox";
            this.asset_files_checkBox.UseVisualStyleBackColor = true;
            this.asset_files_checkBox.CheckedChanged += new System.EventHandler(this.asset_files_checkBox_CheckedChanged);
            // 
            // lib_files_checkBox
            // 
            resources.ApplyResources(this.lib_files_checkBox, "lib_files_checkBox");
            this.lib_files_checkBox.Name = "lib_files_checkBox";
            this.lib_files_checkBox.UseVisualStyleBackColor = true;
            this.lib_files_checkBox.CheckedChanged += new System.EventHandler(this.lib_files_checkBox_CheckedChanged);
            // 
            // KeyLabel
            // 
            resources.ApplyResources(this.KeyLabel, "KeyLabel");
            this.KeyLabel.Name = "KeyLabel";
            // 
            // AdsLinkLabel
            // 
            resources.ApplyResources(this.AdsLinkLabel, "AdsLinkLabel");
            this.AdsLinkLabel.Name = "AdsLinkLabel";
            // 
            // TxtEditorLabel
            // 
            resources.ApplyResources(this.TxtEditorLabel, "TxtEditorLabel");
            this.TxtEditorLabel.Name = "TxtEditorLabel";
            // 
            // TaskCountLabel
            // 
            resources.ApplyResources(this.TaskCountLabel, "TaskCountLabel");
            this.TaskCountLabel.Name = "TaskCountLabel";
            // 
            // task_textBox
            // 
            resources.ApplyResources(this.task_textBox, "task_textBox");
            this.task_textBox.Name = "task_textBox";
            this.task_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.task_textBox_KeyPress);
            // 
            // lang_Box
            // 
            this.lang_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lang_Box.FormattingEnabled = true;
            resources.ApplyResources(this.lang_Box, "lang_Box");
            this.lang_Box.Name = "lang_Box";
            this.lang_Box.Sorted = true;
            // 
            // LanguageLabel
            // 
            resources.ApplyResources(this.LanguageLabel, "LanguageLabel");
            this.LanguageLabel.Name = "LanguageLabel";
            // 
            // close_btn
            // 
            resources.ApplyResources(this.close_btn, "close_btn");
            this.close_btn.Name = "close_btn";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.save_btn, "save_btn");
            this.save_btn.Name = "save_btn";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.Save_Click);
            // 
            // TxtEditorOptions
            // 
            resources.ApplyResources(this.TxtEditorOptions, "TxtEditorOptions");
            this.TxtEditorOptions.Name = "TxtEditorOptions";
            // 
            // open_txt_editor_btn
            // 
            this.open_txt_editor_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.open_txt_editor_btn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.open_txt_editor_btn, "open_txt_editor_btn");
            this.open_txt_editor_btn.Name = "open_txt_editor_btn";
            this.open_txt_editor_btn.UseVisualStyleBackColor = true;
            this.open_txt_editor_btn.Click += new System.EventHandler(this.open_txt_editor_btn_Click);
            // 
            // textEditorArgsComboBox
            // 
            this.textEditorArgsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textEditorArgsComboBox.FormattingEnabled = true;
            this.textEditorArgsComboBox.Items.AddRange(new object[] {
            resources.GetString("textEditorArgsComboBox.Items"),
            resources.GetString("textEditorArgsComboBox.Items1"),
            resources.GetString("textEditorArgsComboBox.Items2")});
            resources.ApplyResources(this.textEditorArgsComboBox, "textEditorArgsComboBox");
            this.textEditorArgsComboBox.Name = "textEditorArgsComboBox";
            this.textEditorArgsComboBox.Sorted = true;
            // 
            // del_debug_checkBox
            // 
            resources.ApplyResources(this.del_debug_checkBox, "del_debug_checkBox");
            this.del_debug_checkBox.Name = "del_debug_checkBox";
            this.del_debug_checkBox.UseVisualStyleBackColor = true;
            this.del_debug_checkBox.CheckedChanged += new System.EventHandler(this.del_debug_checkBox_CheckedChanged);
            // 
            // write_debug_checkBox
            // 
            resources.ApplyResources(this.write_debug_checkBox, "write_debug_checkBox");
            this.write_debug_checkBox.Name = "write_debug_checkBox";
            this.write_debug_checkBox.UseVisualStyleBackColor = true;
            this.write_debug_checkBox.CheckedChanged += new System.EventHandler(this.write_debug_checkBox_CheckedChanged);
            // 
            // SettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.del_debug_checkBox);
            this.Controls.Add(this.api_key_textBox);
            this.Controls.Add(this.write_debug_checkBox);
            this.Controls.Add(this.replace_link_textBox);
            this.Controls.Add(this.textEditorArgsComboBox);
            this.Controls.Add(this.AdsLinkLabel);
            this.Controls.Add(this.task_textBox);
            this.Controls.Add(this.TaskCountLabel);
            this.Controls.Add(this.open_txt_editor_btn);
            this.Controls.Add(this.TxtEditorOptions);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.LanguageLabel);
            this.Controls.Add(this.TxtEditorLabel);
            this.Controls.Add(this.lib_files_checkBox);
            this.Controls.Add(this.asset_files_checkBox);
            this.Controls.Add(this.text_editor_textBox);
            this.Controls.Add(this.lang_Box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox api_key_textBox;
        private System.Windows.Forms.TextBox replace_link_textBox;
        private System.Windows.Forms.TextBox text_editor_textBox;
        // private System.Windows.Forms.CheckBox debug_checkBox;
        private System.Windows.Forms.CheckBox asset_files_checkBox;
        private System.Windows.Forms.CheckBox lib_files_checkBox;
        //private System.Windows.Forms.Label DebugLabel;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.Label AdsLinkLabel;
        private System.Windows.Forms.Label TxtEditorLabel;
        private System.Windows.Forms.Label TaskCountLabel;
        private System.Windows.Forms.TextBox task_textBox;
        private System.Windows.Forms.ComboBox lang_Box;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label TxtEditorOptions;
        private System.Windows.Forms.Button open_txt_editor_btn;
        private System.Windows.Forms.ComboBox textEditorArgsComboBox;
        private System.Windows.Forms.CheckBox del_debug_checkBox;
        private System.Windows.Forms.CheckBox write_debug_checkBox;
    }
}