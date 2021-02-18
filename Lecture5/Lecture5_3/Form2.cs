using System;
using System.Windows.Forms;

namespace Lecture5_3
{
    public partial class Form2 : Form, IText
    {
        private IText _parent;
        
        public Form2(Form1 parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void GetText(string text)
        {
            textBox1.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _parent.GetText(textBox1.Text);
            this.Close();
        }
    }
}