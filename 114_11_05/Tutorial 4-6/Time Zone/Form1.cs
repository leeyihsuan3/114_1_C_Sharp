using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Zone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string city;
            if (cityListBox.SelectedIndex != -1)
                (
                    city = cityListBox.SelectedItems.ToString();

            switch (city)
            {
                case "紐約";
                    timeZoneLabel.Text = "東部標準時間";
                            break;
                case "檀香山";



                    timeZoneLabel.Text = "夏威夷標準時間";
                            break;
                case "明尼牙波利斯";
                        timeZoneLabel.Text = "中部標準時間";
                            break;
                case "丹彿";
                    timeZoneLabel.Text = "山底標準時間";
                        break;
                case "舊金山";
                    timeZoneLabel.Text = "東部標準時間";
                        break;

            }
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
