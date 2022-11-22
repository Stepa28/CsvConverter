using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsvConverter
{
    public partial class Form1 : Form
    {
        private readonly List<Property> _parameters;

        public Form1()
        {
            _parameters = new List<Property>();
            InitializeComponent();

        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                LoadPatch.Text = openFileDialog1.FileName;
            else
                return;

            ListParams.Items.Clear();
            _parameters.Clear();
            // асинхронное чтение
            using (StreamReader reader = new StreamReader(LoadPatch.Text, Encoding.GetEncoding("windows-1251")))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Split(',').Length > 4)
                    {
                        var param = line.Split('\"').ToList();

                        _parameters.AddRange(param.Where(x => x.Length > 1)
                                                  .Select(x => x.TrimEnd(','))
                                                  .Select(x => new Property { Name = x, Checked = false })
                                                  .ToArray());

                        ListParams.Items.AddRange(_parameters
                                                  .Select(property => new ListViewItem { Text = property.Name })
                                                  .ToArray());

                        _parameters.ForEach(property => property.Index = _parameters.IndexOf(property));
                        return;
                    }
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                SavePatch.Text = saveFileDialog1.FileName;
            else
                return;

            using var reader = new StreamReader(LoadPatch.Text, Encoding.GetEncoding("windows-1251"));
            using var streamReader = new StreamWriter(SavePatch.Text);
            var selectedIndices = _parameters.Where(property => property.Checked).Select(property => property.Index).ToArray();
            var firstFlag = true;
            while (reader.ReadLine() is {} line)
            {
                var split = line.Split(',');
                if (split.Length > 4) //TODO вместо 4 постовить нормальное число
                {
                    var linkedList = new LinkedList<string>();
                    if (!firstFlag)
                    {
                        foreach (var index in selectedIndices)
                            linkedList.AddLast(split[index]);
                    }
                    else
                    {
                        foreach (var param in _parameters.Where(property => property.Checked).Select(property => property.Name))
                            linkedList.AddLast($"\"{param}\"");
                        firstFlag = false;
                    }

                    streamReader.WriteLine(string.Join(",", linkedList));
                }
                else
                {
                    streamReader.WriteLine(line);
                }
            }
        }

        private void ListParams_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var item = _parameters.FirstOrDefault(property => property.Name == e.Item.Text);
            if (!e.IsSelected)
                return;
            item.Checked = true;
            if (!listBox2.Items.Contains(item.Name))
                listBox2.Items.Add(item.Name);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem is null)
                return;
            var str = listBox2.SelectedItems.Cast<string>().First();
            var item = _parameters.FirstOrDefault(property => property.Name == str);
            item.Checked = false;
            listBox2.Items.Remove(str);
        }

        private void Filter_TextChanged(object sender, EventArgs e)
        {
            ListParams.Items.Clear();
            ListParams.Items.AddRange(_parameters
                                      .Where(x => x.Name.ToLower().Contains(Filter.Text.ToLower()))
                                      .Select(property => new ListViewItem { Text = property.Name })
                                      .ToArray());
            Filter.BackColor = ListParams.Items.Count == 0
                ? Color.Red
                : Color.White;
        }
    }
}