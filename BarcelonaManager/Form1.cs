using BarcelonaManager.Models;
// ===== UPORABA LASTNIH KNJIŽNIC =====
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
    // ===== DEDOVANJE =====
    public partial class Form1 : Form
    {
        // ===== KAPSULACIJA =====
        private Team Barca = new Team();
        // ===== KONSTRUKTOR =====
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshUI();
        }
        private void RefreshUI()
        {
            lstPlayers.Items.Clear();
            foreach (var p in Barca.Players)
                lstPlayers.Items.Add(p.ToString());

            lblInfo.Text = Barca.Info() + $" | Budget: {Team.Budget}€";
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            using (var f = new AddPlayerForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    Barca.AddPlayer(f.NewPlayer);
                    RefreshUI();
                }
            }
        }


        private void btnRemovePlayer_Click(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedIndex >= 0)
            {
                var player = Barca.Players[lstPlayers.SelectedIndex];
                Barca.RemovePlayer(player);
                RefreshUI();
            }
        }

        private void btnMarket_Click(object sender, EventArgs e)
        {
            using (var f = new TransferForm(Barca))
            {
                f.ShowDialog();
                RefreshUI();
            }
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            using (var f = new StatsForm(Barca))
            {
                f.ShowDialog();
            }
        }

    }
}
