using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using AllInOne.Logic;

namespace AllInOne.Forms
{
    public partial class InterestingPlacesForm : Form
    {
        private ColumnSorterAsc ascSorter;
        private List<Dictionary<string, Dictionary<int, string>>> places;
        public InterestingPlacesForm()
        {
            InitializeComponent();
            ascSorter = new ColumnSorterAsc();
            interestingPlacesListView.ListViewItemSorter = ascSorter;
            this.Text = Language.InterestingPlaces;
            filterLabel.Text = Language.filterLabel;
            caseSensCB.Text = Language.caseSens;
            ToolTip mytooltip = new ToolTip();
           // mytooltip.AutoPopDelay = 1000;
            mytooltip.InitialDelay = 1000;
            mytooltip.ReshowDelay = 500;
            mytooltip.ShowAlways = true;
            mytooltip.SetToolTip(interestingPlacesListView, Language.tooltip_double_click);
            
        }

        public static void EnableDoubleBuffered(Control control, bool enable)
        {
            var doubleBufferPropertyInfo = control.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            doubleBufferPropertyInfo.SetValue(control, enable, null);
        }

        public void LoadPlaces(List<Dictionary<string, Dictionary<int, string>>> places)
        {//словарь(путь к файлу, словарь(номер строки, место))
            List<ListViewItem> items = new List<ListViewItem>();
            foreach(Dictionary<string, Dictionary<int, string>> dict in places)
            {
                foreach(var filePathPair in dict)
                {
                    foreach(var placePair in filePathPair.Value)
                    {
                        items.Add(new ListViewItem(new string[] { placePair.Value, filePathPair.Key }));
                    }
                }
            }
            interestingPlacesListView.Items.AddRange(items.ToArray());
            this.places = places;
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (interestingPlacesListView.SelectedItems.Count > 0)
            {
                Patcher.openTextEditor(interestingPlacesListView.SelectedItems[0].SubItems[1].Text, getLineNumber(interestingPlacesListView.SelectedItems[0].SubItems[0].Text));
            }
        }

        private void interestingPlacesListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ascSorter.SortColumn = e.Column;
            interestingPlacesListView.Sort();
        }

        private int getLineNumber(string place)
        {
            int number = 0;
            foreach (Dictionary<string, Dictionary<int, string>> dict in places)
            {
                foreach (var filePathPair in dict)
                {
                    foreach (var placePair in filePathPair.Value)
                    {
                        if (placePair.Value.Equals(place)) { number = placePair.Key; }
                    }
                }
            }
            return number;
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
            if ("".Equals(filterTBox.Text)) { LoadPlaces(places); }
            List<ListViewItem> items = new List<ListViewItem>();
            foreach (Dictionary<string, Dictionary<int, string>> dict in places)
            {
                foreach (var filePathPair in dict)
                {
                    foreach (var placePair in filePathPair.Value)
                    {
                        if (caseSensCB.Checked)
                        {
                            if (placePair.Value.Contains(filterTBox.Text))
                            {
                                items.Add(new ListViewItem(new string[] { placePair.Value, filePathPair.Key }));
                            }
                        }
                        else
                        {
                            if (placePair.Value.ToLower().Contains(filterTBox.Text.ToLower()))
                            {
                                items.Add(new ListViewItem(new string[] { placePair.Value, filePathPair.Key }));
                            }
                        }
                    }
                }
            }
            interestingPlacesListView.Items.Clear();
            interestingPlacesListView.Items.AddRange(items.ToArray());
        }

        private void InterestingPlacesForm_Load(object sender, EventArgs e)
        {
            EnableDoubleBuffered(interestingPlacesListView, true);
        }
    }
}
