using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            showName.Text="rhombus eight";  

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            showName.Text="Two of Clubs";   
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           showName.Text="king of spades";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            showName.Text="Ace of spades";  
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            showName.Text="black joker" +
                "";
        }
    }
}
