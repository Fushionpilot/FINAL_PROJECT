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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void menuSpin_Click(object sender, EventArgs e)
        {
            RouletteForm rouletteForm = new RouletteForm(this);
            rouletteForm.Show();
            this.Hide();
        }

        private void menuBlackJack_Click(object sender, EventArgs e)
        {

        }

        private void menuSlots_Click(object sender, EventArgs e)
        {
            SlotsForm slotsForm = new SlotsForm(this);
            slotsForm.Show();
            this.Hide();
        }

        private void menuBlackJack_Click_1(object sender, EventArgs e)
        {
            BlackjackForm blackjackForm = new BlackjackForm(this);
            blackjackForm.Show();
            this.Hide();
        }

        private void menuSlots_Click_1(object sender, EventArgs e)
        {
            SlotsForm slotsForm = new SlotsForm(this);
            slotsForm.Show();
            this.Hide();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
