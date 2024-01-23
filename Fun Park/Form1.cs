using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Fun_Park
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idtext.Text = "";
            namecombo.Text = "";
            quantitycombo.Text = "";
            timecombo.Text = "";
            paytext.Text = "";
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
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, quantitycombo.Text, timecombo.Text, paytext.Text, dateTimePicker1.Value);



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
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, quantitycombo.Text, timecombo.Text, paytext.Text, dateTimePicker1.Value);






            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime from = dateTimePicker1.Value;
            DateTime to = DateTime.Now;
            TimeSpan TSpan = to - from;
            double days = TSpan.TotalDays;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text += "********************\n";
            richTextBox1.Text += "**                 Chun Receipt System                  **\n";
            richTextBox1.Text += "********************\n";
            richTextBox1.Text += "Date:" + DateTime.Now + "\n\n";


            richTextBox1.Text += "ID: " + idtext.Text + "\n\n";
            richTextBox1.Text += "Age type : " + namecombo.Text + "\n\n";
            richTextBox1.Text += "Quantity : " + quantitycombo.Text + "\n\n";
            richTextBox1.Text += "Time :" + timecombo.Text + "\n\n";
            richTextBox1.Text += "Payment :" + paytext.Text + "\n\n";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void idtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Microsoft Sans serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)

        {



        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("Date type like '%" + textBox1.Text + "%'");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void timecombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}

