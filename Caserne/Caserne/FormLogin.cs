using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caserne
{
    public partial class FormLogin : Form
    {
        // Variable pour gérer la visibilité du mot de passe
        private bool motDePasseVisible = false;

        public FormLogin()
        {
            InitializeComponent();
            txtBoxMDP.PasswordChar = '*';
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxID.Text) || string.IsNullOrEmpty(txtBoxMDP.Text))
            {
                MessageBox.Show("Veuillez saisir un identifiant.");
                return;
            }
            try
            {
                string requete = "SELECT login, mdp FROM Admin WHERE login = '" + txtBoxID.Text + "' AND mdp = '" + txtBoxMDP.Text + "';";
                SQLiteConnection connec = Connexion.Connec;
                SQLiteCommand commande = new SQLiteCommand(requete, connec);
                SQLiteDataReader lecteur = commande.ExecuteReader();
                if (lecteur.Read())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Identifiant ou mot de passe incorrect");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect");
                return;
            }
        }

        private void txtBoxMDP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnConfirmer.PerformClick();
                e.Handled = true;
            }
        }

        private void txtBoxMDP_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void btnOeil_Click(object sender, EventArgs e)
        {
            motDePasseVisible = !motDePasseVisible;
            txtBoxMDP.PasswordChar = motDePasseVisible ? '\0' : '*';
        }

        private void txtBoxMDP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }


    }
}