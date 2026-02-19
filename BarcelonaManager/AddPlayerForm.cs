using BarcelonaManager.Models;
using System;
using System.Windows.Forms;

namespace BarcelonaManager
{
    // //dedovanje - AddPlayerForm deduje od Form (WinForms)
    public partial class AddPlayerForm : Form
    {
        // //konstruktor
        public AddPlayerForm()
        {
            InitializeComponent();
        }

        // //lastnost - kapsuliran dostop do ustvarjenega igralca
        // //kapsulacija - set je private, samo znotraj tega razreda ga nastavimo
        public PlayerBase NewPlayer { get; private set; }

        private void AddPlayerForm_Load(object sender, EventArgs e)
        {
            // Napolni dropdown s pozicijami (namesto ročnega vpisa)
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
            // Preverimo da je ime vpisano
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vpiši ime igralca!", "Napaka",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string position = cmbPosition.SelectedItem?.ToString() ?? "Generic";

            // //polimorfizem - ustvarimo pravilen tip glede na izbrano pozicijo
            // //konstruktor - klic konstruktorja za vsak podrazred
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