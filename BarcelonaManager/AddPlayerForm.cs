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
    public partial class AddPlayerForm : Form
    {
        public AddPlayerForm()
        {
            InitializeComponent();
        }

        // ===== LASTNOST =====
        public Player NewPlayer { get; private set; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            NewPlayer = new Player(
                txtName.Text,
                txtPos.Text,
                (int)numAge.Value,
                (decimal)numValue.Value
            );

            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
