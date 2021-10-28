using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeOutcome
{
    public partial class Form1 : Form
    {
        public int income;
        public int outlay;
        int income1;
        int outlay1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Show();
            maskedTextBox1.Show();
            button5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Show();
            maskedTextBox2.Show();
            button6.Show();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(income);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            income1 = Convert.ToInt32(textBox1.Text); 
            income += income1;
            dataGridView1.Rows.Add("+",income1, maskedTextBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            outlay1 = Convert.ToInt32(textBox2.Text);
            dataGridView1.Rows.Add("-",outlay1, maskedTextBox2.Text);
            outlay += outlay1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString(outlay);
        }
    }
}
