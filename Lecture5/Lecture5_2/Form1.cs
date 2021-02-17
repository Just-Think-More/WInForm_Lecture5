using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture5_2
{
    public partial class Form1 : Form
    {
        private List<Goods> _goods;
        private List<Goods> _listBox;
        public Form1()
        {
            InitializeComponent();
            _listBox = new List<Goods>();
            _goods = Goods.GetGoods();
            comboBox1.DataSource = _goods;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Goods goods = listBox1.SelectedItem as Goods;
            currentTextBox.Text = goods?.Price.ToString();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            var goods = comboBox1.SelectedItem as Goods;
            _listBox.Add(goods);
            listBox1.DataSource = null;
            listBox1.DataSource = _listBox;
            var totalCurrent = _listBox.Sum(x => x.Price);
            totalTextBox.Text = $@"{totalCurrent :#.## '$'}";
        }
    }
}