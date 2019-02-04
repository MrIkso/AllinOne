namespace AllInOne.Forms
{
    partial class LayoutIdsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LayoutIdsForm));
            this.idsButtonHide = new System.Windows.Forms.Button();
            this.idsListView = new System.Windows.Forms.ListView();
            this.idNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uncheckAllButton = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.caseSensCB = new System.Windows.Forms.CheckBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.filterTBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idsButtonHide
            // 
            this.idsButtonHide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idsButtonHide.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.idsButtonHide.Location = new System.Drawing.Point(813, 10);
            this.idsButtonHide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idsButtonHide.Name = "idsButtonHide";
            this.idsButtonHide.Size = new System.Drawing.Size(100, 28);
            this.idsButtonHide.TabIndex = 1;
            this.idsButtonHide.Text = "OK";
            this.idsButtonHide.UseVisualStyleBackColor = true;
            // 
            // idsListView
            // 
            this.idsListView.CheckBoxes = true;
            this.idsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idNameColumn,
            this.typeColumn,
            this.fileColumn});
            this.idsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idsListView.FullRowSelect = true;
            this.idsListView.GridLines = true;
            this.idsListView.Location = new System.Drawing.Point(0, 0);
            this.idsListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idsListView.MultiSelect = false;
            this.idsListView.Name = "idsListView";
            this.idsListView.Size = new System.Drawing.Size(1019, 508);
            this.idsListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.idsListView.TabIndex = 2;
            this.idsListView.UseCompatibleStateImageBehavior = false;
            this.idsListView.View = System.Windows.Forms.View.Details;
            this.idsListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.idsListView_ColumnClick);
            this.idsListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.idsListView_ItemChecked);
            this.idsListView.DoubleClick += new System.EventHandler(this.idsListView_DoubleClick);
            // 
            // idNameColumn
            // 
            this.idNameColumn.Text = "ID";
            this.idNameColumn.Width = 149;
            // 
            // typeColumn
            // 
            this.typeColumn.Text = "Type";
            this.typeColumn.Width = 201;
            // 
            // fileColumn
            // 
            this.fileColumn.Text = "File";
            this.fileColumn.Width = 392;
            // 
            // uncheckAllButton
            // 
            this.uncheckAllButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uncheckAllButton.Location = new System.Drawing.Point(532, 10);
            this.uncheckAllButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uncheckAllButton.Name = "uncheckAllButton";
            this.uncheckAllButton.Size = new System.Drawing.Size(153, 28);
            this.uncheckAllButton.TabIndex = 3;
            this.uncheckAllButton.Text = "Снять все метки";
            this.uncheckAllButton.UseVisualStyleBackColor = true;
            this.uncheckAllButton.Click += new System.EventHandler(this.uncheckAllButton_Click);
            // 
            // countLabel
            // 
            this.countLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(4, 15);
            this.countLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(28, 17);
            this.countLabel.TabIndex = 4;
            this.countLabel.Text = "0/0";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.countLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.uncheckAllButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.filterTBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.idsButtonHide, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1017, 48);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.caseSensCB);
            this.panel2.Controls.Add(this.filterLabel);
            this.panel2.Location = new System.Drawing.Point(105, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 40);
            this.panel2.TabIndex = 7;
            // 
            // caseSensCB
            // 
            this.caseSensCB.AutoSize = true;
            this.caseSensCB.Location = new System.Drawing.Point(4, 22);
            this.caseSensCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.caseSensCB.Name = "caseSensCB";
            this.caseSensCB.Size = new System.Drawing.Size(156, 21);
            this.caseSensCB.TabIndex = 6;
            this.caseSensCB.Text = "Учитывать регистр";
            this.caseSensCB.UseVisualStyleBackColor = true;
            this.caseSensCB.CheckedChanged += new System.EventHandler(this.caseSensCB_CheckedChanged);
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(4, 4);
            this.filterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(63, 17);
            this.filterLabel.TabIndex = 5;
            this.filterLabel.Text = "Фильтр:";
            // 
            // filterTBox
            // 
            this.filterTBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.filterTBox.Location = new System.Drawing.Point(308, 13);
            this.filterTBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filterTBox.Name = "filterTBox";
            this.filterTBox.Size = new System.Drawing.Size(195, 22);
            this.filterTBox.TabIndex = 6;
            this.filterTBox.TextChanged += new System.EventHandler(this.filterTBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 508);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 50);
            this.panel1.TabIndex = 6;
            // 
            // layoutIdsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 558);
            this.Controls.Add(this.idsListView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(761, 399);
            this.Name = "layoutIdsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список всех id в layout";
            this.Load += new System.EventHandler(this.layoutIdsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button idsButtonHide;
        private System.Windows.Forms.ListView idsListView;
        private System.Windows.Forms.ColumnHeader idNameColumn;
        private System.Windows.Forms.ColumnHeader typeColumn;
        private System.Windows.Forms.ColumnHeader fileColumn;
        private System.Windows.Forms.Button uncheckAllButton;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.TextBox filterTBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox caseSensCB;
    }
}