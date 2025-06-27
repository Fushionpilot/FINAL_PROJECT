using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Net.NetworkInformation;

namespace FINAL_PROJECT
{
    public partial class RouletteForm : Form
    {
        private Form mainMenu;

        public RouletteForm(Form menu)
        {
            InitializeComponent();
            mainMenu = menu;
        }
        public static class GameSession
        {
            public static int Balance { get; set; } = 0;

            public static List<string> Inventory { get; set; } = new List<string>();

            public static void AddItem(string item)
            {
                Inventory.Add(item);
            }

            public static void SellAll()
            {
                foreach (var item in Inventory)
                {
                    Balance += GetItemValue(item);
                }
                Inventory.Clear();
            }

            public static int GetItemValue(string item)
            {
                return item switch
                {
                    "gold watch" => 500,
                    "diamond" => 1500,
                    "gold" => 1000,
                    "emerald" => 250,
                    "killer" => 0,
                    "man" => 100,
                    "laptop" => 15000,
                    "mouse" => 300,
                    "ring" => 800,
                    "car" => 20000,
                    "phone" => 7000,
                    "headphones" => 1200,
                    "painting" => 5000,
                    "silver coin" => 400,
                    "watch" => 600,
                    "tablet" => 5500,
                    "assasin" => 0
                };
            }

        }
        private void UpdateUI()
        {
            balance_label.Text = GameSession.Balance.ToString();
            InventoryList.Items.Clear();
            foreach (var item in GameSession.Inventory)
            {
                InventoryList.Items.Add(item);
            }
        }

        private void spin_button_Click(object sender, EventArgs e)
        {
            string[] items = { "gold watch", "diamond", "gold", "emerald", "killer", "man", "laptop", "mouse", "ring", "car", "phone", "headphones", "painting", "silver coin", "watch", "tablet", "assasin" };
            Random rand = new Random();
            string selectedItem = items[rand.Next(items.Length)];

            if (selectedItem == "killer" || selectedItem == "assasin")
            {
                MessageBox.Show("Inventory lost");
                GameSession.Inventory.Clear();
            }
            else
            {
                GameSession.AddItem(selectedItem);
                MessageBox.Show($"You won: {selectedItem}");
            }

            UpdateUI();
        }

        private void sell_button_Click(object sender, EventArgs e)
        {
            GameSession.SellAll();
            UpdateUI();
        }

        private void RouletteForm_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("gold watch - 500 UAN");
            listBox1.Items.Add("diamond - 1500 UAN");
            listBox1.Items.Add("gold - 1000 UAN");
            listBox1.Items.Add("emerald - 250 UAN");
            listBox1.Items.Add("killer - reset");
            listBox1.Items.Add("man - 100 UAN");
            listBox1.Items.Add("laptop - 15000 UAN");
            listBox1.Items.Add("mouse - 300 UAN");
            listBox1.Items.Add("ring - 800 UAN");
            listBox1.Items.Add("car - 20000 UAN");
            listBox1.Items.Add("phone - 7000 UAN");
            listBox1.Items.Add("headphones - 1200 UAN");
            listBox1.Items.Add("painting - 5000 UAN");
            listBox1.Items.Add("silver coin - 400 UAN");
            listBox1.Items.Add("watch - 600 UAN");
            listBox1.Items.Add("tablet - 5500 UAN");
            listBox1.Items.Add("assasin - reset");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            this.Close();
        }
    }

}

