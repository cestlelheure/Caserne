using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Reflection;
using System.Data.SqlClient;

namespace Caserne
{
    public partial class FormGestionPompier : Form
    {
        SQLiteConnection connec = new SQLiteConnection();
        string chcon = @"Data Source=SDIS67.db";
        DataSet ds = new DataSet();
        public FormGestionPompier()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string requete = "SELECT nom FROM Caserne;";
            RemplirComboBoxDepuisSQLite(comboBox1, chcon, requete, "nom");
        }

        private void RemplirComboBoxDepuisSQLite(ComboBox combo, string chaineConnexion, string requeteSQL, string colonneAffichage)
        {
            SQLiteConnection connexion = null;
            SQLiteCommand commande = null;
            SQLiteDataReader lecteur = null;

            try
            {
                connexion = new SQLiteConnection(chaineConnexion);
                connexion.Open();

                commande = new SQLiteCommand(requeteSQL, connexion);
                lecteur = commande.ExecuteReader();

                combo.Items.Clear();

                while (lecteur.Read())
                {
                    combo.Items.Add(lecteur[colonneAffichage].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void RemplirComboBoxDepuisSQLite(ComboBox combo, string chaineConnexion, string requeteSQL, string[] colonnesAffichage)
        {
            SQLiteConnection connexion = null;
            SQLiteCommand commande = null;
            SQLiteDataReader lecteur = null;

            try
            {
                connexion = new SQLiteConnection(chaineConnexion);
                connexion.Open();

                commande = new SQLiteCommand(requeteSQL, connexion);
                lecteur = commande.ExecuteReader();

                combo.Items.Clear();

                while (lecteur.Read())
                {
                    List<string> valeurs = new List<string>();

                    foreach (string colonne in colonnesAffichage)
                    {
                        valeurs.Add(lecteur[colonne].ToString());
                    }

                    combo.Items.Add(string.Join(" ", valeurs));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                if (lecteur != null) lecteur.Close();
                if (commande != null) commande.Dispose();
                if (connexion != null) connexion.Close();
            }
        }

        private void RemplirLabel(Label label, string chaineConnexion, string requete, string colonne)
        {
            SQLiteConnection connexion = null;
            SQLiteCommand commande = null;
            SQLiteDataReader lecteur = null;

            try
            {
                connexion = new SQLiteConnection(chaineConnexion);
                connexion.Open();

                commande = new SQLiteCommand(requete, connexion);
                lecteur = commande.ExecuteReader();
                if (lecteur.Read())
                {
                    label.Text += lecteur[colonne].ToString();
                }
                else
                {
                    label.Text += "Aucune données";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                if (lecteur != null) lecteur.Close();
                if (commande != null) commande.Dispose();
                if (connexion != null) connexion.Close();
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string requete = "SELECT * FROM Pompier p JOIN Affectation a ON p.matricule = a.matriculePompier " +
                "JOIN Caserne c ON a.idCaserne = c.id WHERE c.id = '"+ comboBox1.SelectedIndex.ToString() + "';";
            string[] nomPrenom = { "nom", "prenom" };
            RemplirComboBoxDepuisSQLite(comboBox2, chcon, requete, nomPrenom);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sécurité : si rien n’est sélectionné on sort
            if (comboBox2.SelectedItem == null) return;

            grpBoxInfoPompier.Visible = true;
            btnAfficherPlus.Visible = true;

            // ⇢ Supposons "Nom Prénom" dans la ComboBox
            string[] nomPrenom = comboBox2.SelectedItem.ToString().Split(' ');
            if (nomPrenom.Length == 0) return;
            string nom = nomPrenom[0].Trim();

            string requete =
                "SELECT matricule, nom, prenom, sexe, dateNaissance, type " +
                "FROM   Pompier " +
                "WHERE  nom = @nom;";

            SQLiteConnection conn = new SQLiteConnection(chcon);
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(requete, conn);
            cmd.Parameters.AddWithValue("@nom", nom);

            SQLiteDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lblMatricule.Text = $"Matricule : {reader["matricule"]}";
                lblNom.Text = $"Nom : {reader["nom"]}";
                lblPrenom.Text = $"Prénom : {reader["prenom"]}";

                DateTime dateN = reader.GetDateTime(reader.GetOrdinal("dateNaissance"));
                lblBD.Text = $"Date de naissance : {dateN:dd/MM/yyyy}";

                lblSexe.Text = $"Sexe : {(reader["sexe"].ToString() == "f" ? "Féminin" : "Masculin")}";

                bool professionnel = reader["type"].ToString() == "p";
                rdbProfessionnel.Checked = professionnel;
                rdbVolontaire.Checked = !professionnel;
            }
            else
            {
                MessageBox.Show("Pompier non trouvé !");
            }

            // --- Libération des ressources ---
            reader.Close();   // ferme le DataReader
            cmd.Dispose();    // libère la commande
            conn.Close();     // ferme la connexion
            conn.Dispose();   // libère la connexion
        }

        private void btnAfficherPlus_Click(object sender, EventArgs e)
        {
            grpBoxCarriere.Visible = true;
        }
    }
}


