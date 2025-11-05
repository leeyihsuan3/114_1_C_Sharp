using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheakBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "";
            if (checkBox1.Checked)
            {
                message += "夏威夷\n";
            }
            if (checkBox2.Checked)
            {
                message += "章魚燒\n";
            }
            if (checkBox3.Checked)
            {
                message += "綜合海鮮\n";
            }
            if (checkBox4.Checked)
            {
                message += "義式火腿\n";
            }
            if (message == "")
            {
               message = "您沒有選擇任何口味";
            }

            MessageBox.Show(message, "您選擇的披薩口味是");
        }
    }
}
