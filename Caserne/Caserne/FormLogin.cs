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
        public FormLogin()
        {
            InitializeComponent();
        }


        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if(txtBoxID.Text == null || txtBoxMDP == null)
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
                    // Si l'identifiant et le mot de passe sont corrects, on ferme la fenêtre de connexion
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
    }


}
