using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lecture5_1
{
    public partial class SearchForm : Form
    {
        private Form1 _parent;
        private string _path;
        public SearchForm(Form1 parent)
        {
            InitializeComponent();
            _path = Directory.GetDirectoryRoot(Directory.GetCurrentDirectory());
            _parent = parent;
            FolderList(_path);
            
        }

        private void FolderList(string path)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = Directory.GetDirectories(path);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pathLabel.Text = listBox1.SelectedItem?.ToString();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                _path = listBox1.SelectedItem.ToString();
                FolderList(_path);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                _path = Directory.GetParent(_path)?.ToString();
                FolderList(_path);
            }
        }

        private void upLabel_Click(object sender, EventArgs e)
        {
            if(Directory.GetParent(_path) != null)
            {
                _path = Directory.GetParent(_path)?.ToString();
                FolderList(_path);
            }
        }

        private void select_Click(object sender, EventArgs e)
        {
            _path = listBox1.SelectedItem.ToString();
            _parent.FilesList(SearchFiles(_path));
        }

        private List<string> SearchFiles(string path)
        {
            var list = new List<string>();
            var files = Directory.EnumerateFiles(path, mask.Text, new EnumerationOptions());
            list.AddRange(files);
            foreach (var dir in Directory.GetDirectories(path, "*", new EnumerationOptions()))
            {
                list.AddRange(SearchFiles(dir));
            }
            return list;
        }
    }
}