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

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                const decimal MINIMUM_SALARY = 1200000m; // 最低年薪
                const int MINIMUM_YEARS = 2; // 最低年資

                decimal salary; // 使用者的年薪   
                int yearsOnJob; // 使用者的現職年資
                // 取得使用者的年薪
                if (decimal.TryParse(salaryTextBox.Text, out salary))
                {
                    // 取得使用者的現職年資
                    if (int.TryParse(yearsTextBox.Text, out yearsOnJob))
                    {
                        // 判斷是否符合貸款資格
                        if (salary >= MINIMUM_SALARY && yearsOnJob >= MINIMUM_YEARS)
                        {
                            decisionLabel.Text = "符合資格。";
                        }
                        else
                        {
                            decisionLabel.Text = "不符合資格;年資未達最低標準";
                        }
                    }
                    else
                    {
                        decisionLabel.Text = "不符合資格;收入未未達最低標準";
                    }
                }
                else
                {
                    decisionLabel.Text = "不符合資格;收入未未達最低標準";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and the decisionLabel.
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            // Reset the focus.
            salaryTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
