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

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 計算按鈕事件：計算加班薪資，並顯示於標籤
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 常數：基本工時與加班倍率
            const decimal BASE_HOURS = 40m; // 基本工時
            const decimal OVERTIME_RATE = 1.5m; // 加班倍率

            decimal hoursWorked;      // 儲存工時
            decimal hourlyPayRate;    // 儲存時薪
            decimal grossPay;         // 儲存總薪資

            // 取得工時
            if (decimal.TryParse(hoursWorkedTextBox.Text, out hoursWorked))
            {
                // 取得時薪
                if (decimal.TryParse(hourlyPayRateTextBox.Text, out hourlyPayRate))
                {
                    // 計算總薪資
                    if (hoursWorked <= BASE_HOURS)
                    {
                        grossPay = hoursWorked * hourlyPayRate;
                    }
                    else
                    {
                        grossPay = (BASE_HOURS * hourlyPayRate) +
                                   ((hoursWorked - BASE_HOURS) *
                                   (hourlyPayRate * OVERTIME_RATE));
                    }

                    // 顯示總薪資（格式化為貨幣）
                    grossPayLabel.Text = grossPay.ToString("c");
                }
                else
                {
                    // 時薪輸入錯誤
                    MessageBox.Show("請輸入正確的時薪數值。", "輸入錯誤");
                }
            }
            else
            {
                // 工時輸入錯誤
                MessageBox.Show("請輸入正確的工時數值。", "輸入錯誤");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and gross pay label.
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            // Reset the focus.
            hoursWorkedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
