using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROJECT
{
    public partial class BlackjackForm : Form
    {
        private List<string> deck;
        private List<string> playerCards = new List<string>();
        private List<string> dealerCards = new List<string>();
        private Random rand = new Random();

        private int playerTotal = 0;
        private int dealerTotal = 0;
        private int betAmount = 0;
        private int balance = 1000;
        private bool cardHidden = false;

        private Form mainMenu;

        public BlackjackForm(Form menu)
        {
            InitializeComponent();
            mainMenu = menu;
        }

        private void BlackjackForm_Load(object sender, EventArgs e)
        {
            UpdateBalance();
        }

        private void InitializeDeck()
        {
            deck = new List<string>();
            string[] suits = { "♠", "♥", "♦", "♣" };
            string[] values = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            foreach (var suit in suits)
            {
                foreach (var value in values)
                {
                    deck.Add(value + suit);
                }
            }

            deck = deck.OrderBy(x => rand.Next()).ToList();
        }

        private void StartNewGame()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            result_label.Text = "";
            dealer_points.Text = "0";
            your_points.Text = "0";

            playerCards.Clear();
            dealerCards.Clear();
            playerTotal = 0;
            dealerTotal = 0;
            cardHidden = true;

            InitializeDeck();
            DealInitialCards();

            EnableActions();
        }

        private void DealInitialCards()
        {
            AddCardToPanel(flowLayoutPanel2, DrawCard(), playerCards, ref playerTotal);
            AddCardToPanel(flowLayoutPanel1, DrawCard(), dealerCards, ref dealerTotal);

            AddCardToPanel(flowLayoutPanel2, DrawCard(), playerCards, ref playerTotal);
            AddCardToPanel(flowLayoutPanel1, "?", dealerCards, ref dealerTotal);

            your_points.Text = playerTotal.ToString();
        }

        private string DrawCard()
        {
            if (deck.Count == 0) InitializeDeck();
            var card = deck[0];
            deck.RemoveAt(0);
            return card;
        }

        private int GetCardValue(string card)
        {
            string value = card.Substring(0, card.Length - 1);
            return value switch
            {
                "A" => 11,
                "K" or "Q" or "J" => 10,
                _ => int.Parse(value)
            };
        }

        private void AddCardToPanel(FlowLayoutPanel panel, string card, List<string> hand, ref int total)
        {
            if (card != "?")
            {
                hand.Add(card);
                total += GetCardValue(card);
            }

            Label cardLabel = new Label
            {
                Text = card,
                AutoSize = true,
                Font = new Font("Sitka Small", 11, FontStyle.Bold),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(5),
                Margin = new Padding(5)
            };

            panel.Controls.Add(cardLabel);
        }

        private void hit_button_Click(object sender, EventArgs e)
        {
            AddCardToPanel(flowLayoutPanel2, DrawCard(), playerCards, ref playerTotal);
            your_points.Text = playerTotal.ToString();  

            if (playerTotal > 21)
            {
                result_label.Text = "You busted!";
                DisableActions();
            }
        }

        private void stand_button_Click(object sender, EventArgs e)
        {
            RevealDealerHand();

            while (dealerTotal < 17)
            {
                AddCardToPanel(flowLayoutPanel1, DrawCard(), dealerCards, ref dealerTotal);
                dealer_points.Text = dealerTotal.ToString();
            }

            EvaluateWinner();
            DisableActions();
        }

        private void RevealDealerHand()
        {
            flowLayoutPanel1.Controls.Clear();
            dealerTotal = 0;

            foreach (var card in dealerCards.ToList())
            {
                AddCardToPanel(flowLayoutPanel1, card, dealerCards, ref dealerTotal);
            }

            dealer_points.Text = dealerTotal.ToString();
        }

        private void EvaluateWinner()
        {
            if (dealerTotal > 21 || playerTotal > dealerTotal)
            {
                result_label.Text = "You win!";
                balance += betAmount * 2;   
            }
            else if (playerTotal < dealerTotal)
            {
                result_label.Text = "Dealer wins!";
            }
            else
            {
                result_label.Text = "It's a tie!";
                balance += betAmount;
            }

            UpdateBalance();
        }

        private void new_game_button_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }  

        private void UpdateBalance()
        {
            balance_label.Text = balance.ToString();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            this.Close();
        }

        private void DisableActions()
        {
            hit_button.Enabled = false;
            stand_button.Enabled = false;
            double_button.Enabled = false;
        }

        private void EnableActions()
        {
            hit_button.Enabled = true;
            stand_button.Enabled = true;
            double_button.Enabled = true;
        }

        private void double_button_Click_1(object sender, EventArgs e)
        {
            if (balance >= betAmount)
            {
                balance -= betAmount;
                betAmount *= 2;
                UpdateBalance();
                current_bet.Text = $"{betAmount}";

                AddCardToPanel(flowLayoutPanel2, DrawCard(), playerCards, ref playerTotal);
                your_points.Text = playerTotal.ToString();

                if (playerTotal > 21)
                {
                    result_label.Text = "You busted!";
                    DisableActions();
                }
                else
                {
                    stand_button.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("Not enough balance!");
            }
        }

        private void place_bet_button_Click(object sender, EventArgs e)
        {
            if (int.TryParse(BettextBox.Text, out int bet) && bet > 0 && bet <= balance)
            {
                betAmount = bet;
                balance -= bet;
                UpdateBalance();
                current_bet.Text = $"{betAmount}$";
                StartNewGame();
            }
            else
            {
                MessageBox.Show("Invalid bet amount!");
            }
        }
    }
}

