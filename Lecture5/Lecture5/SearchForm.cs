using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Lecture5
{
    public partial class SearchForm : Form
    {
        private Form1 _parent;
        private string _path;
        private Stack<string> _listPath;
        public SearchForm(Form1 parent)
        {
            InitializeComponent();
            _listPath = new Stack<string>();
            _listPath.Push(_path);
            _parent = parent;
            _path = @"C:\";
            FolderList(_path);
            
        }

        private void FolderList(string path)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = Directory.GetDirectories(path);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pathLabel.Text = listBox1?.SelectedItem.ToString();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            _listPath.Push(listBox1.SelectedItem.ToString());
            FolderList(_listPath.Peek());
        }
    }
}