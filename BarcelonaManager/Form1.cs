using BarcelonaManager.Models;
// //uporaba lastnih knjižnic - uvoz naših modelov in servisov
using BarcelonaManager.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BarcelonaManager
{
    // //dedovanje - Form1 deduje od Form (WinForms)
    public partial class Form1 : Form
    {
        // //kapsulacija - zasebno polje ekipe
        private Team Barca = new Team();

        // Šteje katero sezono smo (prikazuje se v naslovu)
        // //static - skupen števec za celo aplikacijo
        private static int _seasonNumber = 1;

        // //konstruktor
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshUI();
        }

        // //objektna metoda - osveži celoten prikaz na Form1
        private void RefreshUI()
        {
            lstPlayers.Items.Clear();
            foreach (var p in Barca.Players)
                lstPlayers.Items.Add(p.ToString());

            lblInfo.Text = Barca.Info() + $"  |  Budget: {Team.Budget:N0} €";
            this.Text = $"Barcelona Manager – Sezona {_seasonNumber}";
        }

        // ===== GUMB: Dodaj igralca =====
        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            using (var f = new AddPlayerForm())
            {
                if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Barca.AddPlayer(f.NewPlayer);
                    // Registriraj lastnega igralca tudi na trgu prestopov!
                    MarketPlayerDatabase.RegisterCustomPlayer(f.NewPlayer);
                    RefreshUI();
                }
            }
        }

        // ===== GUMB: Odstrani igralca =====
        private void btnRemovePlayer_Click(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedIndex < 0)
            {
                MessageBox.Show("Najprej izberi igralca iz seznama!",
                    "Ni izbire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var player = Barca.Players[lstPlayers.SelectedIndex];
            Barca.RemovePlayer(player);
            RefreshUI();
        }

        // ===== GUMB: Trg prestopov =====
        private void btnMarket_Click(object sender, EventArgs e)
        {
            using (var f = new TransferForm(Barca))
            {
                f.ShowDialog();
                RefreshUI();
            }
        }

        // ===== GUMB: Statistika =====
        private void btnStats_Click(object sender, EventArgs e)
        {
            using (var f = new StatsForm(Barca))
            {
                f.ShowDialog();
            }
        }

        // ===== GUMB: Next Season – GENERATOR GOLOV =====
        private void btnNextSeason_Click(object sender, EventArgs e)
        {
            if (Barca.Players.Count == 0)
            {
                MessageBox.Show("Ekipa je prazna! Dodaj najprej igralce.",
                    "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ===== BUDGET DIALOG =====
            // Pred vsako sezono izbereš koliko budgeta dobiš
            using (var budgetForm = new Form())
            {
                budgetForm.Text = $"Sezona {_seasonNumber + 1} – Nastavi budget";
                budgetForm.Size = new System.Drawing.Size(360, 180);
                budgetForm.StartPosition = FormStartPosition.CenterParent;
                budgetForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                budgetForm.MaximizeBox = false;

                var lbl = new Label { Text = "Koliko budgeta (v €) dobiš za to sezono?", Left = 15, Top = 20, Width = 320 };
                var num = new NumericUpDown
                {
                    Left = 15,
                    Top = 50,
                    Width = 200,
                    Minimum = 0,
                    Maximum = 2_000_000_000,
                    Increment = 5_000_000,
                    Value = 75_000_000,
                    ThousandsSeparator = true
                };
                var btnOk = new Button { Text = "Potrdi", Left = 230, Top = 48, Width = 90, DialogResult = DialogResult.OK };
                budgetForm.Controls.AddRange(new Control[] { lbl, num, btnOk });
                budgetForm.AcceptButton = btnOk;

                if (budgetForm.ShowDialog() == DialogResult.OK)
                {
                    Team.Budget += (decimal)num.Value; // Dodamo k obstoječemu
                    MessageBox.Show($"✅ Budget povečan za {(decimal)num.Value:N0} €\nNovi budget: {Team.Budget:N0} €",
                        "Budget nastavljen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            _seasonNumber++;

            // //statična metoda - pokličemo generator golov za celo ekipo
            // //delegat + dogodek - GoalGenerator interno sproži dogodek za vsakega igralca
            Dictionary<string, int> rezultati = GoalGenerator.GenerateForTeam(Barca.Players);

            // Sestavi poročilo
            // //kapsulacija - StringBuilder za sestavljanje besedila
            var sb = new StringBuilder();
            sb.AppendLine($"📅 SEZONA {_seasonNumber} – REZULTATI\n");
            sb.AppendLine("═══════════════════════════════════");

            int skupajGolov = 0;
            foreach (var par in rezultati)
            {
                sb.AppendLine($"⚽  {par.Key,-22} → {par.Value,3} golov/podaj");
                skupajGolov += par.Value;
            }

            sb.AppendLine("═══════════════════════════════════");
            sb.AppendLine($"🏆  SKUPAJ ekipa: {skupajGolov} golov/podaj");

            // Pokaži poročilo
            MessageBox.Show(sb.ToString(), $"Rezultati sezone {_seasonNumber}",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Osveži UI (seznam zdaj prikazuje gole v ToString())
            RefreshUI();
        }
    }
}