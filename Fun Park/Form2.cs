using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fun_Park
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (namecombo.SelectedItem.ToString() == "Child")
            {
                if (timecombo.SelectedItem.ToString() == "1hr")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 450).ToString();
                }
                if (timecombo.SelectedItem.ToString() == "2hr")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 700).ToString();

                }
                if (timecombo.SelectedItem.ToString() == "3hr")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 1050).ToString();
                }
                if (timecombo.SelectedItem.ToString() == "4hr")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 1450).ToString();
                }
                if (timecombo.SelectedItem.ToString() == "Whole day")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 2200).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, quantitycombo.Text, timecombo.Text, paytext.Text);



            }
            if (namecombo.SelectedItem.ToString() == "Adult")

            {
                if (timecombo.SelectedItem.ToString() == "1hr")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 500).ToString();
                }
                if (timecombo.SelectedItem.ToString() == "2hr")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 1000).ToString();
                }
                if (timecombo.SelectedItem.ToString() == "3hr")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 1500).ToString();
                }
                if (timecombo.SelectedItem.ToString() == "4hr")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 2100).ToString();
                }
                if (timecombo.SelectedItem.ToString() == "Whole day")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 2100).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, quantitycombo.Text, timecombo.Text, paytext.Text);






            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
