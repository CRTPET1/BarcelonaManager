using BarcelonaManager.Models;
using BarcelonaManager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcelonaManager
{
    public partial class TransferForm : Form
    {
        private Team team;

        public TransferForm(Team team)
        {
            InitializeComponent();
            this.team = team;
        }
        public void TransferForm_Load(object sender, EventArgs e)
        {
            foreach (var p in team.Players)
                cmbPlayers.Items.Add(p.Name);
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            var p = new Player("Random", 25, numPrice.Value);
            if (TransferMarket.BuyPlayer(team, p, numPrice.Value))
                MessageBox.Show("Nakup uspešen!");
            else
                MessageBox.Show("Premalo budgeta!");
        }

        public void btnSell_Click(object sender, EventArgs e)
        {
            if (cmbPlayers.SelectedIndex < 0) return;

            var playerBase = team.Players[cmbPlayers.SelectedIndex];
            TransferMarket.SellPlayer(team, playerBase, numPrice.Value);
            MessageBox.Show("Prodaja uspešna!");
        }

    }
}
