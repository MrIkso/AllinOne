using AllInOne.Logic;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using System.Globalization;
using Cyotek.Windows.Forms;
using System.IO;

namespace AllInOne.Forms
{
    public partial class ColorEditorForm : Form
    {
        private ColumnSorterAsc ascSorter;
        private List<Dictionary<string, Dictionary<string, string>>> color;
        public List<ListViewItem> items = new List<ListViewItem>();
        public Dictionary<string, string> tColor = new Dictionary<string, string>();
        ListViewItem lv = new ListViewItem();

        public ColorEditorForm()
        {
            InitializeComponent();
            ascSorter = new ColumnSorterAsc();
            colorsListView.ListViewItemSorter = ascSorter;
            Text = Language.tools_color_editor;
            scltColorlbl.Text = Language.tools__color_selected_color;
        }

        public static void EnableDoubleBuffered(Control control, bool enable)
        {
            var doubleBufferPropertyInfo = control.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            doubleBufferPropertyInfo.SetValue(control, enable, null);
        }

        public void loadColors(List<Dictionary<string, Dictionary<string, string>>> color)
        {//List<ListViewItem> items = new List<ListViewItem>();
            foreach (Dictionary<string, Dictionary<string, string>> dict in color)
            {
                
                foreach (var filepathPair in dict)
                {
                    foreach (var idPair in filepathPair.Value)
                    {
                        ListViewItem.ListViewSubItem lvColor = new ListViewItem.ListViewSubItem();
                        ListViewItem lv = new ListViewItem();
                        string value1 = idPair.Key.ToString();
                        string value = idPair.Value.ToString();
                        string value2 = filepathPair.Key.ToString();
                        string[] s = { idPair.Key.ToString(), idPair.Value.ToString(), filepathPair.Key };
                        foreach (string file in s)
                        {
                            if (value.StartsWith("#"))
                            {
                                Color c = ColorTranslator.FromHtml(value);
                                float f = c.GetBrightness();
                                if (f <= 0.35)
                                {
                                    lv.ForeColor = Color.White;
                                }
                                lv.BackColor = c;
                            }
                        }
                        
                        lv.SubItems[0].Text = value1;
                        lv.SubItems.Add(value);
                        lv.SubItems.Add(value2);
                        colorsListView.Items.Add(lv);
                     //   tColor.Add(value1, value);
                        //    items.Add(new ListViewItem(new string[]
                        //        { idPair.Key.ToString(), idPair.Value.ToString(), filepathPair.Key
                        //        }));
                        //}
                    }
                }
            }
            colorsListView.Items.Add(lv);
            colorsListView.Items.AddRange(items.ToArray());
            this.color = color;
        }

        private void ColorEditor_Load(object sender, EventArgs e)
        {
            EnableDoubleBuffered(colorsListView, true);

        }

        private void colorsListView_DoubleClick(object sender, EventArgs e)
        {
            if (colorsListView.SelectedItems.Count > 0)
            {
                Patcher.openTextEditor(colorsListView.SelectedItems[0].SubItems[2].Text, Patcher.getLineNumberInFile(colorsListView.SelectedItems[0].SubItems[2].Text, colorsListView.SelectedItems[0].SubItems[1].Text));//, "android:id=\"@id/" + colorsListView.SelectedItems[0].SubItems[0].Text));
            }
        }

        private void colorsListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }

        private void colorsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshProperties();
        }

        public void HexToArgb()
        {
            string selectedKey = colorsListView.SelectedItems[0].Text;
            string value = colorsListView.SelectedItems[0].SubItems[1].Text;
            select_color.Text = selectedKey;
            hexTBox.Text = value;
            //проверка на валидность цвета
            if (value.StartsWith("#"))
            {
                Color _color = ColorTranslator.FromHtml(value);
                colorPanel.BackColor = _color;
                Color col;
                string hexColor = value;
                //Remove # if present
                if (hexColor.IndexOf('#') != -1)
                    hexColor = hexColor.Replace("#", "");

                int red = 0;
                int green = 0;
                int blue = 0;
                int alfa = 0;
                if (hexColor.Length == 8)
                {
                    //#AARRGGBB
                    alfa = int.Parse(hexColor.Substring(0, 2), NumberStyles.HexNumber);
                    red = int.Parse(hexColor.Substring(2, 2), NumberStyles.HexNumber);
                    green = int.Parse(hexColor.Substring(4, 2), NumberStyles.HexNumber);
                    blue = int.Parse(hexColor.Substring(6, 2), NumberStyles.HexNumber);

                }
                //else if (hexColor.Length == 3)
                //{
                //    //#RGB
                //    red = int.Parse(hexColor[0].ToString() + hexColor[0].ToString(), NumberStyles.AllowHexSpecifier);
                //    green = int.Parse(hexColor[1].ToString() + hexColor[1].ToString(), NumberStyles.AllowHexSpecifier);
                //    blue = int.Parse(hexColor[2].ToString() + hexColor[2].ToString(), NumberStyles.AllowHexSpecifier);
                //}
                col = Color.FromArgb(alfa, red, green, blue);
                alphaTBox.Text = alfa.ToString();
                redTBox.Text = red.ToString(); ;
                greenTBox.Text = green.ToString();
                blueTBox.Text = blue.ToString();
            }
            else
            {
                MessageBox.Show(Language.message_color_not_valid, Language.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //public void HexToColor(string hexColor)
        //{
        //    Color col;

        //    //Remove # if present
        //    if (hexColor.IndexOf('#') != -1)
        //        hexColor = hexColor.Replace("#", "");

        //    int red = 0;
        //    int green = 0;
        //    int blue = 0;
        //    int alfa = 0;
        //    if (hexColor.Length == 8)
        //    {
        //        //#AARRGGBB
        //     //   alfa = int
        //        alfa = int.Parse(hexColor.Substring(0, 2), NumberStyles.HexNumber);
        //        red = int.Parse(hexColor.Substring(2, 2), NumberStyles.HexNumber);
        //        green = int.Parse(hexColor.Substring(4, 2), NumberStyles.HexNumber);
        //        blue = int.Parse(hexColor.Substring(6, 2), NumberStyles.HexNumber);

        //    }
        //    else if (hexColor.Length == 3)
        //    {
        //        //#RGB
        //        red = int.Parse(hexColor[0].ToString() + hexColor[0].ToString(), NumberStyles.AllowHexSpecifier);
        //        green = int.Parse(hexColor[1].ToString() + hexColor[1].ToString(), NumberStyles.AllowHexSpecifier);
        //        blue = int.Parse(hexColor[2].ToString() + hexColor[2].ToString(), NumberStyles.AllowHexSpecifier);
        //    }
        //    col = Color.FromArgb(alfa, red, green, blue);
        //    alphaTBox.Text = alfa.ToString();
        //    redTBox.Text = red.ToString(); ;
        //    greenTBox.Text = green.ToString();
        //    blueTBox.Text = blue.ToString();
        //    //return col;
        //}

        //public static bool IsValidHex(string hexColor)
        //{
        //    if (hexColor.StartsWith("#"))
        //     //  string hexColor.Length == 9;
        //    return hexColor.Length == 9;//|| hexColor.Length == 4;
        //    return true;
        //    //else
        //    //    return hexColor.Length == 6 || hexColor.Length == 3;
        //}
        private static String RGBConverter(Color c)
        {
            return "RGB(" + c.R.ToString() + "," + c.G.ToString() + "," + c.B.ToString() + ")";
        }

        private void RefreshProperties()
        {
            if (colorsListView.SelectedItems.Count == 0)
            {
                return;
            }
            if (colorsListView.SelectedItems.Count == 1)
            {
                HexToArgb();

            }
        }
        //private static String HexConverter(Color c)
        //{
        //    return "#ff" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        //}

        private string ToHtml(Color color)
        {
            return string.Concat("#", (color.ToArgb() & 0x00FFFFFFFF).ToString("X8"));
        }

        private void slctBtn_Click(object sender, EventArgs e)
        {
            string value = colorsListView.SelectedItems[0].SubItems[1].Text;
            ColorPickerDialog CPD = new ColorPickerDialog();
            Color c = ColorTranslator.FromHtml(value);
            CPD.Color = c;
            if (CPD.ShowDialog() == DialogResult.OK)
            {
                Color resColor = CPD.Color;
                int selected = resColor.ToArgb();
                Color clr = Color.FromArgb(selected);
                alphaTBox.Text = resColor.A.ToString();
                redTBox.Text = resColor.R.ToString();
                greenTBox.Text = resColor.G.ToString();
                blueTBox.Text = resColor.B.ToString();
                hexTBox.Text = ToHtml(clr);
                colorPanel.BackColor = clr;
            }
        }

        private void filterTBox_TextChanged(object sender, EventArgs e)
        {
           // myTextChanged();
        }

        private void caseSensCB_CheckedChanged(object sender, EventArgs e)
        {
            //myTextChanged();
        }

        //private void myTextChanged()
        //{
        //    colorsListView.Items.Clear();
        //    List<ListViewItem> items = new List<ListViewItem>();
        //     ListViewItem lv = new ListViewItem();
        //      if ("".Equals(filterTBox.Text)) { loadColors(color); }
        //    foreach (Dictionary<string, Dictionary<string, string>> dict in color)
        //    {
        //        foreach (var filepathPair in dict)
        //        {
        //            foreach (var idPair in filepathPair.Value)
        //            {
        //                if (caseSensCB.Checked)
        //                {
        //                    if (idPair.Value.Contains(filterTBox.Text))
        //                    {
        //                        ListViewItem.ListViewSubItem lvColor = new ListViewItem.ListViewSubItem();
        //                     //   ListViewItem lv = new ListViewItem();
        //                        string value1 = idPair.Key.ToString();
        //                        string value = idPair.Value.ToString();
        //                        string value2 = filepathPair.Key.ToString();
        //                        string[] s = { idPair.Key.ToString(), idPair.Value.ToString(), filepathPair.Key };
        //                        foreach (string file in s)
        //                        {
        //                            if (value.StartsWith("#"))
        //                            {
        //                                Color c = ColorTranslator.FromHtml(value);
        //                                float f = c.GetBrightness();
        //                                if (f <= 0.35)
        //                                {
        //                                    lv.ForeColor = Color.White;
        //                                }
        //                                lv.BackColor = c;
        //                            }
        //                        }
        //                        colorsListView.Items.Add(lv);
        //                        lv.SubItems[0].Text = value1;
        //                        lv.SubItems.Add(value);
        //                        lv.SubItems.Add(value2);
        //                    }
        //                }
        //                else
        //                {
        //                    if (idPair.Value.ToLower().Contains(filterTBox.Text.ToLower()))
        //                    {
        //                        ListViewItem.ListViewSubItem lvColor = new ListViewItem.ListViewSubItem();
                               
        //                        string value1 = idPair.Key.ToString();
        //                        string value = idPair.Value.ToString();
        //                        string value2 = filepathPair.Key.ToString();
        //                        string[] s = { idPair.Key.ToString(), idPair.Value.ToString(), filepathPair.Key };
        //                        foreach (string file in s)
        //                        {
        //                            if (value.StartsWith("#"))
        //                            {
        //                                Color c = ColorTranslator.FromHtml(value);
        //                                float f = c.GetBrightness();
        //                                if (f <= 0.35)
        //                                {
        //                                    lv.ForeColor = Color.White;
        //                                }
        //                                lv.BackColor = c;
        //                            }
        //                        }
        //                        colorsListView.Items.Add(lv);
        //                        lv.SubItems[0].Text = value1;
        //                        lv.SubItems.Add(value);
        //                        lv.SubItems.Add(value2);
        //                    }
        //                }

        //                    //    items.Add(new ListViewItem(new string[]
        //                    //        { idPair.Key.ToString(), idPair.Value.ToString(), filepathPair.Key
        //                    //        }));
        //                    //}
        //                }
        //            }
        //        }
                
        //      colorsListView.Items.AddRange(items.ToArray());
        //   // colorsListView.Items.Add(items);
        //   // color = color;
        //}

        private void saveBtn_Click(object sender, EventArgs e)
        {
          //  if(SFD.ShowDialog() == DialogResult.Cancel)

                 //   return;
            // получаем выбранный файл
          //  string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
           // System.IO.File.WriteAllText(filename, textBox1.Text);
          //  MessageBox.Show("Файл сохранен");

               // string filePath = SFD.FileName;
               // StreamWriter sw = new StreamWriter(filePath);
               //foreach (KeyValuePair<string, string> x in tColor)
               //{
               //     sw.WriteLine(String.Format("{0}={1}", x.Key, x.Value));
               //}
               //sw.Close();
               //sw.Dispose();
            
        }

        
    }
    }


