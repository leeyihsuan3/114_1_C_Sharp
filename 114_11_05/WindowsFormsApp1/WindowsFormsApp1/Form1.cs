using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String message = "點餐內容:";
            string drink= "";
            string sandwich = "";   
            if (coffeeRadioButton2.Checked)
            {
                drink = "咖啡"; 
            }
            else if (milkteaRadioButton1.Checked)
            {
                drink = "奶茶";
             
            }
            else if (blackteaRadioButton3.Checked)
            {
                drink = "紅茶";
            }
            else if (juiceRadioButton4.Checked)
            {
                drink = "果汁";
            }
            else
                {
                drink = "";
            }   

            if(jamsandwichRadioButton5.Checked)
            {
                sandwich = "果醬三明治";
            }
            else if (hamsandwichRadioButton6.Checked)
            {
     
          
                sandwich = "火腿三明治";
            }
            else if (tunaRadioButton7.Checked)
            {
                sandwich = "鮪魚三明治";
            }
            else
            {
                sandwich = "";
            }
            message= drink+ sandwich;
            MessageBox.Show(message, "您的餐點內容");
        }

        private void jamsandwichRadioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
