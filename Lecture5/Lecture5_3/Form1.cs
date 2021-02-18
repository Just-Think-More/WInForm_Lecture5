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

namespace Lecture5_3
{
    public partial class Form1 : Form, IText
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = @"Text files|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(dlg.FileName);
                editButton.Enabled = true;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this);
            form.GetText(textBox1.Text);
            form.Show();
        }

        public void GetText(string text)
        {
            textBox1.Text = text;
        }
    }
}