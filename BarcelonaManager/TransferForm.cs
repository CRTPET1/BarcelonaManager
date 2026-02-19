using BarcelonaManager.Models;
using BarcelonaManager.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BarcelonaManager
{
    // //dedovanje - TransferForm deduje od Form
    public partial class TransferForm : Form
    {
        // //kapsulacija - zasebno polje, dostopno samo znotraj tega razreda
        private readonly Team _team;

        // Lista tržnih igralcev ki jo prikazujemo v tabeli
        private List<PlayerBase> _marketPlayers;

        // Trenutno izbran igralec v tabeli
        private PlayerBase _selectedPlayer;

        // //konstruktor - sprejmemo Team kot parameter
        public TransferForm(Team team)
        {
            InitializeComponent();
            _team = team;
        }

        private void TransferForm_Load(object sender, EventArgs e)
        {
            SetupGrid();
            RefreshMarketList();
        }

        // //objektna metoda - nastavi izgled tabele (stolpci, barve)
        private void SetupGrid()
        {
            dgvMarket.Columns.Clear();
            dgvMarket.AutoGenerateColumns = false;
            dgvMarket.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMarket.MultiSelect = false;
            dgvMarket.ReadOnly = true;
            dgvMarket.AllowUserToAddRows = false;
            dgvMarket.AllowUserToDeleteRows = false;
            dgvMarket.RowHeadersVisible = false;
            dgvMarket.BackgroundColor = Color.White;
            dgvMarket.Font = new Font("Segoe UI", 9f);

            // Dodaj stolpce
            dgvMarket.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Ime in priimek", Width = 160 });
            dgvMarket.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPos", HeaderText = "Pozicija", Width = 90 });
            dgvMarket.Columns.Add(new DataGridViewTextBoxColumn { Name = "colAge", HeaderText = "Starost", Width = 60 });
            dgvMarket.Columns.Add(new DataGridViewTextBoxColumn { Name = "colValue", HeaderText = "Vrednost (M€)", Width = 100 });
            dgvMarket.Columns.Add(new DataGridViewTextBoxColumn { Name = "colInTeam", HeaderText = "V tvoji ekipi?", Width = 100 });
        }

        // //objektna metoda - osveži seznam tržnih igralcev v tabeli
        private void RefreshMarketList()
        {
            // //statična metoda - klic statične metode iz MarketPlayerDatabase
            _marketPlayers = MarketPlayerDatabase.GetAllPlayers();

            dgvMarket.Rows.Clear();

            foreach (var p in _marketPlayers)
            {
                bool inTeam = _team.Players.Contains(p);

                int rowIdx = dgvMarket.Rows.Add(
                    p.Name,
                    p.Position,
                    p.Age,
                    $"{p.Value:0.0}",
                    inTeam ? "✅ DA" : "NE"
                );

                // Obarva vrstice: zelena = v ekipi, bela = na trgu
                if (inTeam)
                    dgvMarket.Rows[rowIdx].DefaultCellStyle.BackColor = Color.LightGreen;
            }

            // Osveži prikaz budgeta
            lblBudget.Text = $"💰 Budget: {Team.Budget:N0} €";

            // Resetiraj izbiro in zakleni gumbe dokler ni nič izbrano
            _selectedPlayer = null;
            btnBuy.Enabled = false;
            btnSell.Enabled = false;
            lblSelectedInfo.Text = "Izberi igralca v tabeli...";
        }

        // Ko klikneš vrstico v tabeli → pokaži info + nastavi gumbe
        private void dgvMarket_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMarket.SelectedRows.Count == 0) return;

            int idx = dgvMarket.SelectedRows[0].Index;
            if (idx < 0 || idx >= _marketPlayers.Count) return;

            _selectedPlayer = _marketPlayers[idx];
            bool inTeam = _team.Players.Contains(_selectedPlayer);

            // Posodobi info labelo
            lblSelectedInfo.Text =
                $"📋 {_selectedPlayer.Name} | {_selectedPlayer.Position} | " +
                $"{_selectedPlayer.Age} let | {_selectedPlayer.Value:0.0}M €";

            // ===== ZAKLEPANJE GUMBOV =====
            // Če je v ekipi → Kupi zaklenjen, Prodaj odklenjen
            // Če ni v ekipi → Prodaj zaklenjen, Kupi odklenjen
            btnBuy.Enabled = !inTeam;
            btnSell.Enabled = inTeam;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (_selectedPlayer == null) return;

            // Cena je vrednost v milionih (100M = 100_000_000 €)
            decimal cena = _selectedPlayer.Value * 1_000_000m;

            // Preveri budget — ne moreš kupiti za manj kot je vreden
            if (Team.Budget < cena)
            {
                MessageBox.Show(
                    $"❌ Premalo budgeta!\n\n" +
                    $"Cena: {cena:N0} €\n" +
                    $"Tvoj budget: {Team.Budget:N0} €",
                    "Napaka pri nakupu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // //statična metoda - klic statične metode TransferMarket.BuyPlayer
            bool uspeh = TransferMarket.BuyPlayer(_team, _selectedPlayer, cena);

            if (uspeh)
            {
                MessageBox.Show(
                    $"✅ {_selectedPlayer.Name} je prišel v ekipo!\n" +
                    $"Porabljeno: {cena:N0} €\n" +
                    $"Ostalo: {Team.Budget:N0} €",
                    "Nakup uspešen!");
                RefreshMarketList();
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (_selectedPlayer == null) return;

            decimal cena = _selectedPlayer.Value * 1_000_000m;

            var potrditev = MessageBox.Show(
                $"Prodati {_selectedPlayer.Name} za {cena:N0} €?",
                "Potrdi prodajo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (potrditev != System.Windows.Forms.DialogResult.Yes) return;

            // //statična metoda - proda igralca in vrne denar
            TransferMarket.SellPlayer(_team, _selectedPlayer, cena);

            // ===== KLJUČNO: Prodani igralec ostane na trgu! =====
            // //statična metoda - vrne ga v bazo tržnih igralcev
            MarketPlayerDatabase.AddToMarket(_selectedPlayer);

            MessageBox.Show(
                $"💰 {_selectedPlayer.Name} prodan!\n" +
                $"Zaslužek: {cena:N0} €\n" +
                $"Novi budget: {Team.Budget:N0} €",
                "Prodaja uspešna!");

            RefreshMarketList();
        }
    }
}