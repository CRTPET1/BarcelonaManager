using BarcelonaManager.Models;
using System.Windows.Forms;

namespace BarcelonaManager
{
    // //dedovanje - PlayerStatsForm deduje od Form (WinForms)
    public partial class PlayerStatsForm : Form
    {
        // //kapsulacija - zasebno polje za igralca
        private readonly PlayerBase _player;

        // //konstruktor - sprejmemo PlayerBase kot parameter
        public PlayerStatsForm(PlayerBase player)
        {
            InitializeComponent();
            _player = player;
        }

        private void PlayerStatsForm_Load(object sender, System.EventArgs e)
        {
            this.Text = $"Kariera – {_player.Name}";

            lstPlayerStats.Items.Clear();
            lstPlayerStats.Items.Add($"═══════════════════════════════════");
            lstPlayerStats.Items.Add($"  👤  {_player.Name}");
            lstPlayerStats.Items.Add($"═══════════════════════════════════");
            lstPlayerStats.Items.Add($"  Pozicija:         {_player.Position}");
            lstPlayerStats.Items.Add($"  Starost:          {_player.Age} let");
            lstPlayerStats.Items.Add($"  Vrednost:         {_player.Value}M €");
            lstPlayerStats.Items.Add($"  Sezon v klubu:    {_player.SeasonsAtClub}");
            lstPlayerStats.Items.Add($"───────────────────────────────────");
            lstPlayerStats.Items.Add($"  ⚽ Karierni goli:      {_player.CareerGoals}");
            lstPlayerStats.Items.Add($"═══════════════════════════════════");
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}