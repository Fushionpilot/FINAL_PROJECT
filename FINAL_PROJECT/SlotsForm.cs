using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FINAL_PROJECT
{
    public partial class SlotsForm : Form
    {
        private Form mainMenu;
        private Random rand = new Random();
        private int balance = 1000;
        private int currentBet = 50;

        private List<string> symbols = new List<string>
        {
            "cherry", "lemon", "bell", "diamond", "star", "seven"
        };

        public SlotsForm(Form menu)
        {
            InitializeComponent();
            mainMenu = menu;
            UpdateUI();
        }

        private void SlotsForm_Load(object sender, EventArgs e)
        {
            LoadSymbols();
        }

        private void LoadSymbols()
        {
            pictureBox2.Image = LoadImage("cherry");
            pictureBox3.Image = LoadImage("lemon");
            pictureBox4.Image = LoadImage("star");
        }

        private void spin_button_Click(object sender, EventArgs e)
        {
            if (balance < currentBet)
            {
                MessageBox.Show("Not enough balance!");
                return;
            }

            balance -= currentBet;

            string s1 = GetRandomSymbol();
            string s2 = GetRandomSymbol();
            string s3 = GetRandomSymbol();

            pictureBox2.Image = LoadImage(s1);
            pictureBox3.Image = LoadImage(s2);
            pictureBox4.Image = LoadImage(s3);

            int winAmount = CalculateWinnings(s1, s2, s3);
            balance += winAmount;

            result_lbl.Text = winAmount > 0 ? $"You win {winAmount} ₴" : "No win";
            UpdateUI();
        }

        private string GetRandomSymbol()
        {
            return symbols[rand.Next(symbols.Count)];
        }

        private Image LoadImage(string symbol)
        {
            try
            {
                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", $"{symbol}.png");

                if (File.Exists(imagePath))
                {
                    return Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show($"Image not found: {imagePath}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}");
                return null;
            }
        }

        private int CalculateWinnings(string s1, string s2, string s3)
        {
            if (s1 == s2 && s2 == s3)
                return currentBet * 10;
            else if (s1 == s2 || s2 == s3 || s1 == s3)
                return currentBet * 2;
            return 0;
        }

        private void UpdateUI()
        {
            balance_lbl.Text = $"{balance} ₴";
            Bet_lbl.Text = $"{currentBet} ₴";
        }

        private void bet_plus_button_Click(object sender, EventArgs e)
        {
            if (currentBet + 10 <= balance)
                currentBet += 10;
            UpdateUI();
        }

        private void bet_minys_button_Click(object sender, EventArgs e)
        {
            if (currentBet - 10 >= 10)
                currentBet -= 10;
            UpdateUI();
        }

        private void max_button_Click(object sender, EventArgs e)
        {
            currentBet = balance;
            UpdateUI();
        }

        private void new_game_button_Click(object sender, EventArgs e)
        {
            balance = 1000;
            currentBet = 50;
            result_lbl.Text = "";
            UpdateUI();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            this.Close();
        }
    }
}
