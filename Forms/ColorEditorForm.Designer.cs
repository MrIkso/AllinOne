namespace AllInOne.Forms
{
    partial class ColorEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorEditorForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.greenTBox = new System.Windows.Forms.TextBox();
            this.scltColorlbl = new System.Windows.Forms.Label();
            this.red_lbl = new System.Windows.Forms.Label();
            this.hexTBox = new System.Windows.Forms.TextBox();
            this.green_lbl = new System.Windows.Forms.Label();
            this.hexlbl = new System.Windows.Forms.Label();
            this.blue_label = new System.Windows.Forms.Label();
            this.select_color = new System.Windows.Forms.Label();
            this.redTBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.blueTBox = new System.Windows.Forms.TextBox();
            this.slctBtn = new System.Windows.Forms.Button();
            this.alpha_lbl = new System.Windows.Forms.Label();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.alphaTBox = new System.Windows.Forms.TextBox();
            this.colorsListView = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.color_hexColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.colorsListView);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1071, 704);
            this.mainPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.greenTBox);
            this.panel1.Controls.Add(this.scltColorlbl);
            this.panel1.Controls.Add(this.red_lbl);
            this.panel1.Controls.Add(this.hexTBox);
            this.panel1.Controls.Add(this.green_lbl);
            this.panel1.Controls.Add(this.hexlbl);
            this.panel1.Controls.Add(this.blue_label);
            this.panel1.Controls.Add(this.select_color);
            this.panel1.Controls.Add(this.redTBox);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.blueTBox);
            this.panel1.Controls.Add(this.slctBtn);
            this.panel1.Controls.Add(this.alpha_lbl);
            this.panel1.Controls.Add(this.colorPanel);
            this.panel1.Controls.Add(this.alphaTBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(499, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 704);
            this.panel1.TabIndex = 16;
            // 
            // greenTBox
            // 
            this.greenTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greenTBox.Location = new System.Drawing.Point(58, 37);
            this.greenTBox.Name = "greenTBox";
            this.greenTBox.ReadOnly = true;
            this.greenTBox.Size = new System.Drawing.Size(117, 22);
            this.greenTBox.TabIndex = 5;
            // 
            // scltColorlbl
            // 
            this.scltColorlbl.AutoSize = true;
            this.scltColorlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scltColorlbl.Location = new System.Drawing.Point(6, 149);
            this.scltColorlbl.Name = "scltColorlbl";
            this.scltColorlbl.Size = new System.Drawing.Size(145, 17);
            this.scltColorlbl.TabIndex = 15;
            this.scltColorlbl.Text = "Selected Color Name:";
            // 
            // red_lbl
            // 
            this.red_lbl.AutoSize = true;
            this.red_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.red_lbl.Location = new System.Drawing.Point(6, 9);
            this.red_lbl.Name = "red_lbl";
            this.red_lbl.Size = new System.Drawing.Size(38, 17);
            this.red_lbl.TabIndex = 1;
            this.red_lbl.Text = "Red:";
            // 
            // hexTBox
            // 
            this.hexTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hexTBox.Location = new System.Drawing.Point(58, 119);
            this.hexTBox.Name = "hexTBox";
            this.hexTBox.ReadOnly = true;
            this.hexTBox.Size = new System.Drawing.Size(117, 22);
            this.hexTBox.TabIndex = 14;
            // 
            // green_lbl
            // 
            this.green_lbl.AutoSize = true;
            this.green_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.green_lbl.Location = new System.Drawing.Point(6, 37);
            this.green_lbl.Name = "green_lbl";
            this.green_lbl.Size = new System.Drawing.Size(52, 17);
            this.green_lbl.TabIndex = 2;
            this.green_lbl.Text = "Green:";
            // 
            // hexlbl
            // 
            this.hexlbl.AutoSize = true;
            this.hexlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hexlbl.Location = new System.Drawing.Point(6, 119);
            this.hexlbl.Name = "hexlbl";
            this.hexlbl.Size = new System.Drawing.Size(36, 17);
            this.hexlbl.TabIndex = 13;
            this.hexlbl.Text = "Hex:";
            // 
            // blue_label
            // 
            this.blue_label.AutoSize = true;
            this.blue_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blue_label.Location = new System.Drawing.Point(6, 65);
            this.blue_label.Name = "blue_label";
            this.blue_label.Size = new System.Drawing.Size(40, 17);
            this.blue_label.TabIndex = 3;
            this.blue_label.Text = "Blue:";
            // 
            // select_color
            // 
            this.select_color.AutoSize = true;
            this.select_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.select_color.Location = new System.Drawing.Point(157, 149);
            this.select_color.Name = "select_color";
            this.select_color.Size = new System.Drawing.Size(47, 17);
            this.select_color.TabIndex = 12;
            this.select_color.Text = "value";
            // 
            // redTBox
            // 
            this.redTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redTBox.Location = new System.Drawing.Point(58, 9);
            this.redTBox.Name = "redTBox";
            this.redTBox.ReadOnly = true;
            this.redTBox.Size = new System.Drawing.Size(117, 22);
            this.redTBox.TabIndex = 4;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(137, 180);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(101, 36);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Visible = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // blueTBox
            // 
            this.blueTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blueTBox.Location = new System.Drawing.Point(58, 65);
            this.blueTBox.Name = "blueTBox";
            this.blueTBox.ReadOnly = true;
            this.blueTBox.Size = new System.Drawing.Size(117, 22);
            this.blueTBox.TabIndex = 6;
            // 
            // slctBtn
            // 
            this.slctBtn.Location = new System.Drawing.Point(9, 180);
            this.slctBtn.Name = "slctBtn";
            this.slctBtn.Size = new System.Drawing.Size(101, 36);
            this.slctBtn.TabIndex = 10;
            this.slctBtn.Text = "Select Color";
            this.slctBtn.UseVisualStyleBackColor = true;
            this.slctBtn.Click += new System.EventHandler(this.slctBtn_Click);
            // 
            // alpha_lbl
            // 
            this.alpha_lbl.AutoSize = true;
            this.alpha_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alpha_lbl.Location = new System.Drawing.Point(6, 91);
            this.alpha_lbl.Name = "alpha_lbl";
            this.alpha_lbl.Size = new System.Drawing.Size(48, 17);
            this.alpha_lbl.TabIndex = 7;
            this.alpha_lbl.Text = "Alpha:";
            // 
            // colorPanel
            // 
            this.colorPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorPanel.Location = new System.Drawing.Point(200, 9);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(361, 132);
            this.colorPanel.TabIndex = 9;
            // 
            // alphaTBox
            // 
            this.alphaTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alphaTBox.Location = new System.Drawing.Point(58, 91);
            this.alphaTBox.Name = "alphaTBox";
            this.alphaTBox.ReadOnly = true;
            this.alphaTBox.Size = new System.Drawing.Size(117, 22);
            this.alphaTBox.TabIndex = 8;
            // 
            // colorsListView
            // 
            this.colorsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.color_hexColumn,
            this.fileColumn});
            this.colorsListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.colorsListView.GridLines = true;
            this.colorsListView.Location = new System.Drawing.Point(0, 0);
            this.colorsListView.MultiSelect = false;
            this.colorsListView.Name = "colorsListView";
            this.colorsListView.Size = new System.Drawing.Size(499, 704);
            this.colorsListView.TabIndex = 0;
            this.colorsListView.UseCompatibleStateImageBehavior = false;
            this.colorsListView.View = System.Windows.Forms.View.Details;
            this.colorsListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.colorsListView_ColumnClick);
            this.colorsListView.SelectedIndexChanged += new System.EventHandler(this.colorsListView_SelectedIndexChanged);
            this.colorsListView.DoubleClick += new System.EventHandler(this.colorsListView_DoubleClick);
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 147;
            // 
            // color_hexColumn
            // 
            this.color_hexColumn.Text = "Color in Hex";
            this.color_hexColumn.Width = 128;
            // 
            // fileColumn
            // 
            this.fileColumn.Text = "File";
            this.fileColumn.Width = 182;
            // 
            // ColorEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 704);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ColorEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Editor";
            this.Load += new System.EventHandler(this.ColorEditor_Load);
            this.mainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ListView colorsListView;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader color_hexColumn;
        private System.Windows.Forms.ColumnHeader fileColumn;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.TextBox alphaTBox;
        private System.Windows.Forms.Label alpha_lbl;
        private System.Windows.Forms.TextBox blueTBox;
        private System.Windows.Forms.TextBox greenTBox;
        private System.Windows.Forms.TextBox redTBox;
        private System.Windows.Forms.Label blue_label;
        private System.Windows.Forms.Label green_lbl;
        private System.Windows.Forms.Label red_lbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button slctBtn;
        private System.Windows.Forms.Label select_color;
        private System.Windows.Forms.TextBox hexTBox;
        private System.Windows.Forms.Label hexlbl;
        private System.Windows.Forms.Label scltColorlbl;
        private System.Windows.Forms.Panel panel1;
    }
}