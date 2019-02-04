namespace AllInOne.Forms
{
    partial class InterestingPlacesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterestingPlacesForm));
            this.interestingPlacesListView = new System.Windows.Forms.ListView();
            this.placeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.filterLabel = new System.Windows.Forms.Label();
            this.filterTBox = new System.Windows.Forms.TextBox();
            this.caseSensCB = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // interestingPlacesListView
            // 
            this.interestingPlacesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.placeColumn,
            this.fileColumn});
            this.interestingPlacesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.interestingPlacesListView.FullRowSelect = true;
            this.interestingPlacesListView.GridLines = true;
            this.interestingPlacesListView.Location = new System.Drawing.Point(0, 0);
            this.interestingPlacesListView.MultiSelect = false;
            this.interestingPlacesListView.Name = "interestingPlacesListView";
            this.interestingPlacesListView.Size = new System.Drawing.Size(736, 390);
            this.interestingPlacesListView.TabIndex = 0;
            this.interestingPlacesListView.UseCompatibleStateImageBehavior = false;
            this.interestingPlacesListView.View = System.Windows.Forms.View.Details;
            this.interestingPlacesListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.interestingPlacesListView_ColumnClick);
            this.interestingPlacesListView.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // placeColumn
            // 
            this.placeColumn.Text = "Text";
            this.placeColumn.Width = 195;
            // 
            // fileColumn
            // 
            this.fileColumn.Text = "File";
            this.fileColumn.Width = 520;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 26);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.filterLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.filterTBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.caseSensCB, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(736, 26);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // filterLabel
            // 
            this.filterLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(3, 6);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(50, 13);
            this.filterLabel.TabIndex = 0;
            this.filterLabel.Text = "Фильтр:";
            // 
            // filterTBox
            // 
            this.filterTBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.filterTBox.Location = new System.Drawing.Point(76, 3);
            this.filterTBox.Name = "filterTBox";
            this.filterTBox.Size = new System.Drawing.Size(175, 20);
            this.filterTBox.TabIndex = 1;
            this.filterTBox.TextChanged += new System.EventHandler(this.filterTBox_TextChanged);
            // 
            // caseSensCB
            // 
            this.caseSensCB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.caseSensCB.AutoSize = true;
            this.caseSensCB.Location = new System.Drawing.Point(260, 4);
            this.caseSensCB.Name = "caseSensCB";
            this.caseSensCB.Size = new System.Drawing.Size(124, 17);
            this.caseSensCB.TabIndex = 2;
            this.caseSensCB.Text = "Учитывать регистр";
            this.caseSensCB.UseVisualStyleBackColor = true;
            this.caseSensCB.CheckedChanged += new System.EventHandler(this.caseSensCB_CheckedChanged);
            // 
            // InterestingPlacesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 416);
            this.Controls.Add(this.interestingPlacesListView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(575, 333);
            this.Name = "InterestingPlacesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Интересные места";
            this.Load += new System.EventHandler(this.InterestingPlacesForm_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView interestingPlacesListView;
        private System.Windows.Forms.ColumnHeader placeColumn;
        private System.Windows.Forms.ColumnHeader fileColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.TextBox filterTBox;
        private System.Windows.Forms.CheckBox caseSensCB;
    }
}