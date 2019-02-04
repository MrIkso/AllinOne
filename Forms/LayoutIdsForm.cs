using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using AllInOne.Logic;

namespace AllInOne.Forms
{
    public partial class LayoutIdsForm : Form
    {
        private ColumnSorterAsc ascSorter;
        private List<Dictionary<string, Dictionary<string, string>>> ids;
        public LayoutIdsForm()
        {
            InitializeComponent();
            ascSorter = new ColumnSorterAsc();
            idsListView.ListViewItemSorter = ascSorter;

            idsButtonHide.Text = Language.hideSelected;
            uncheckAllButton.Text = Language.uncheckAllCheckboxes;
            filterLabel.Text = Language.filterLabel;
            caseSensCB.Text = Language.caseSens;
            this.Text = Language.listOfAllIds;
        }

        public static void EnableDoubleBuffered(Control control, bool enable)
        {
            var doubleBufferPropertyInfo = control.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            doubleBufferPropertyInfo.SetValue(control, enable, null);
        }

        public void loadIds(List<Dictionary<string, Dictionary<string, string>>> ids)
        {
            List<ListViewItem> items = new List<ListViewItem>();

            foreach (Dictionary<string, Dictionary<string, string>> dict in ids)
            {
                foreach(var filepathPair in dict)
                {
                    foreach(var idPair in filepathPair.Value)
                    {
                        items.Add(new ListViewItem(new string[] { idPair.Key, idPair.Value, filepathPair.Key }));
                    }
                }
            }
            idsListView.Items.AddRange(items.ToArray());
            countLabel.Text = idsListView.CheckedItems.Count.ToString() + "/" + idsListView.Items.Count.ToString();
            this.ids = ids;
        }

        public Dictionary<string, Dictionary<string, string>> getChecked()
        {//словарь(путь, словарь(ид, тип))
            Dictionary<string, Dictionary<string, string>> result = new Dictionary<string, Dictionary<string, string>>();

            foreach(ListViewItem checkedItem in idsListView.CheckedItems)
            {
                if(result.ContainsKey(checkedItem.SubItems[2].Text))
                {
                    result[checkedItem.SubItems[2].Text].Add(checkedItem.SubItems[0].Text, checkedItem.SubItems[1].Text);
                }
                else
                {
                    result.Add(checkedItem.SubItems[2].Text, new Dictionary<string, string>() { { checkedItem.SubItems[0].Text, checkedItem.SubItems[1].Text } });
                }
            }
            return result;
        }

        private void uncheckAllButton_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in idsListView.CheckedItems)
            {
                item.Checked = false;
            }
        }

        private void idsListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            countLabel.Text = idsListView.CheckedItems.Count.ToString() + "/" + idsListView.Items.Count.ToString();
        }

        private void idsListView_DoubleClick(object sender, EventArgs e)
        {
            if(idsListView.SelectedItems.Count>0)
            {
                idsListView.SelectedItems[0].Checked = !idsListView.SelectedItems[0].Checked;
                
                Patcher.openTextEditor(idsListView.SelectedItems[0].SubItems[2].Text, Patcher.getLineNumberInFile(idsListView.SelectedItems[0].SubItems[2].Text, "android:id=\"@id/"+idsListView.SelectedItems[0].SubItems[0].Text));
            }
        }

        private void idsListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ascSorter.SortColumn = e.Column;
            idsListView.Sort();
        }

        private void filterTBox_TextChanged(object sender, EventArgs e)
        {
            myTextChanged();
        }

        private void caseSensCB_CheckedChanged(object sender, EventArgs e)
        {
            myTextChanged();
        }

        private void myTextChanged()
        {
            if ("".Equals(filterTBox.Text)) { loadIds(ids); }

            List<ListViewItem> items = new List<ListViewItem>();

            foreach (Dictionary<string, Dictionary<string, string>> dict in ids)
            {
                foreach (var filepathPair in dict)
                {
                    foreach (var idPair in filepathPair.Value)
                    {
                        if (caseSensCB.Checked)
                        {
                            if (idPair.Key.Contains(filterTBox.Text))
                            {
                                items.Add(new ListViewItem(new string[] { idPair.Key, idPair.Value, filepathPair.Key }));
                            }
                        }
                        else
                        {
                            if (idPair.Key.ToLower().Contains(filterTBox.Text.ToLower()))
                            {
                                items.Add(new ListViewItem(new string[] { idPair.Key, idPair.Value, filepathPair.Key }));
                            }
                        }
                    }
                }
            }
            idsListView.Items.Clear();
            idsListView.Items.AddRange(items.ToArray());
            countLabel.Text = idsListView.CheckedItems.Count.ToString() + "/" + idsListView.Items.Count.ToString();
        }

        private void layoutIdsForm_Load(object sender, EventArgs e)
        {
            EnableDoubleBuffered(idsListView, true);
        }
    }
}
