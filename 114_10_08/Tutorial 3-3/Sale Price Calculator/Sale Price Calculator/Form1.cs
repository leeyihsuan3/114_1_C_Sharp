using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice;
            decimal discountPercentage;
            decimal salePrice;

            originalPrice = decimal.Parse(originalPriceTextBox.Text);
            discountPercentage=decimal.Parse(discountPercentageTextBox.Text);

            salePrice = originalPrice * (1 - discountPercentage / 100.0m);
                
            salePriceLabel.Text =salePrice.ToString("C");
        }
       

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void outputDescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void originalPricePromptLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
