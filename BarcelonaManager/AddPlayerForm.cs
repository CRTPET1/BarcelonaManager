using BarcelonaManager.Models;
using System;
using System.Windows.Forms;

namespace BarcelonaManager
{
    public partial class AddPlayerForm : Form
    {
        public AddPlayerForm()
        {
            InitializeComponent();
        }

        public PlayerBase NewPlayer { get; private set; }

        private void AddPlayerForm_Load(object sender, EventArgs e)
        {
            cmbPosition.Items.Clear();
            cmbPosition.Items.Add("Forward");
            cmbPosition.Items.Add("Midfielder");
            cmbPosition.Items.Add("Defender");
            cmbPosition.Items.Add("Goalkeeper");
            cmbPosition.Items.Add("Generic");
            cmbPosition.SelectedIndex = 0; // Privzeto "Forward"
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vpiši ime igralca!", "Napaka",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string position = cmbPosition.SelectedItem?.ToString() ?? "Generic";

            switch (position)
            {
                case "Forward":
                    NewPlayer = new Forward(
                        txtName.Text,
                        (int)numAge.Value,
                        (decimal)numValue.Value);
                    break;

                case "Midfielder":
                    NewPlayer = new Midfielder(
                        txtName.Text,
                        (int)numAge.Value,
                        (decimal)numValue.Value);
                    break;

                case "Defender":
                    NewPlayer = new Defender(
                        txtName.Text,
                        (int)numAge.Value,
                        (decimal)numValue.Value);
                    break;

                case "Goalkeeper":
                    NewPlayer = new Goalkeeper(
                        txtName.Text,
                        (int)numAge.Value,
                        (decimal)numValue.Value);
                    break;

                default:
                    NewPlayer = new Player(
                        txtName.Text,
                        (int)numAge.Value,
                        (decimal)numValue.Value);
                    break;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}