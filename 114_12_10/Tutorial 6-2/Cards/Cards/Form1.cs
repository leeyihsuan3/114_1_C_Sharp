using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showCardButton_Click(object sender, EventArgs e)
        {
            if (cardListBox.SelectedIndex != -1)
            {
                var selected = cardListBox.SelectedItem as string;

                if (!string.IsNullOrEmpty(selected))
                {
                    showSelectedCard(selected.Trim());
                }
                else 
                {
                    MessageBox.Show("Please select a valid card from the list!");
                }
            }
            else
            { 
                MessageBox.Show("Please select a card from the list!");    
            }

        }

        private void showSelectedCard(string cardName)
        {
            switch (cardName)
            {
                case "Ace of Spades":
                    showAceSpades();
                    break;
                case "10 of Hearts":
                    showTenHearts();
                    break;
                case "King of Clubs":
                    showKingClubs();
                    break;

                default:
                    MessageBox.Show("Card not recognized.");
                    break;
            }
        }
        private void showAceSpades()
        {
            aceSpadesPictureBox.Visible = true;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;
        }
        private void showTenHearts()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = true;
            kingClubsPictureBox.Visible = false;
        }
        private void showKingClubs()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
