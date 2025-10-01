using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tutorial_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dayofweekTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dayOfWeek = dayofweekTextBox.Text;
            string month = monthTextBox.Text;
            string year = yearsTextBox.Text;
            string dayOfMonth = dayOfMonthTextBox.Text;
            string output = "中華民國" + year + "年" + month + "月" + dayOfMonth + "日" + ",星期" + dayOfWeek;
            dateOutput.Text = output;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dayofweekTextBox.Text = "";
            monthTextBox.Text = "";
            yearsTextBox.Text = "";
            dayOfMonthTextBox.Text = "";
            dateOutput.Text = "";

        }
    }
}