using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 計算平均分數
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double score1 = double.Parse(test1TextBox.Text);
                double score2 = double.Parse(test2TextBox.Text);
                double score3 = double.Parse(test3TextBox.Text);

                double average = (score1 + score2 + score3) / 3;
                averageLabel.Text = average.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入有效的分數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 清除所有欄位
        private void clearButton_Click(object sender, EventArgs e)
        {

            double test1, test2, test3;
            try
            {



                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                double average = (test1 + test2 + test3) / 3.0;
                averageLabel.Text = average.ToString("n2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("例外發生:", ex.Message);
                test1TextBox.Text = "";
                test2TextBox.Text = "";
                test3TextBox.Text = "";
                averageLabel.Text = "";
                test1TextBox.Focus();


            }
        }
        // 關閉表單
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
