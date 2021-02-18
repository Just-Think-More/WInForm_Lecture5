using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Double;

namespace Lecture5_2
{
    public partial class Form2 : Form, IQos
    {
        private List<Goods> _goods;
        private Form1 _parent;
        public Form2(Form1 parent)
        {
            InitializeComponent();
            _parent = parent;
            _goods = new List<Goods>();
        }

        public void PushList(List<Goods> list)
        {
            _goods = list;
            comboBox1.DataSource = null;
            comboBox1.DataSource = _goods;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Goods goods = comboBox1.SelectedItem as Goods;
            editTypeTextBox.Text = goods?.Type;
            editNameTextBox.Text = goods?.Name;
            editPriceTextBox.Text = goods?.Price.ToString();
            editDescriptionTextBox.Text = goods?.Description;
            editSpecificationsTextBox.Text = goods?.Specifications;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Goods good = comboBox1.SelectedItem as Goods;
            TryParse(editPriceTextBox.Text, out var price);
            if (good != null)
            {
                good.Type = editTypeTextBox.Text;
                good.Name = editNameTextBox.Text;
                good.Price = price;
                good.Description = editDescriptionTextBox.Text;
                good.Specifications = editSpecificationsTextBox.Text;

                foreach (var g in _goods)
                {
                    if (g == good)
                    {
                        g.Type = good.Type;
                        g.Name = good.Name;
                        g.Price = good.Price;
                        g.Description = g.Description;
                        g.Specifications = g.Specifications;
                    }
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            TryParse(addPriceTextBox.Text, out var price);
            Goods good = new Goods()
            {
                Type = addTypeTextBox.Text,
                Name = addNameTextBox.Text,
                Price = price,
                Description = addDescriptionTextBox.Text,
                Specifications = addSpecificationsTextBox.Text
            };
            _goods.Add(good);
            addTypeTextBox.Text = String.Empty;
            addNameTextBox.Text = String.Empty;
            addPriceTextBox.Text = String.Empty;
            addDescriptionTextBox.Text = String.Empty;
            addSpecificationsTextBox.Text = String.Empty;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            _parent.PushList(_goods);
        }
    }
}