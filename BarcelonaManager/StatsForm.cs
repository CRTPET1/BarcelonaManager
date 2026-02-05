using BarcelonaManager.Models;
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
    public partial class StatsForm : Form
    {
        private Team team;
        public StatsForm(Team t)
        {
            InitializeComponent();
            team = t;
        }

        private void StatsForm_Load(object sender, EventArgs e)
        {
            lstStats.Items.Add($"Skupna vrednost ekipe: {team.TotalPlayersValue()} €");
            lstStats.Items.Add($"Povprečna starost: {team.AverageAge():0.0} let");
            lstStats.Items.Add($"Št. igralcev: {team.Players.Count}");

            var mvp = team.MostValuablePlayer();
            if (mvp != null)
                lstStats.Items.Add($"Najdražji igralec: {mvp.Name} ({mvp.Value} €)");

            lstStats.Items.Add("Po pozicijah:");
            foreach (var pos in team.PositionDistribution())
                lstStats.Items.Add($"   {pos.Key}: {pos.Value}");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
