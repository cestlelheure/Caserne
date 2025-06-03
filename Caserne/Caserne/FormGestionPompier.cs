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

        public FormGestionPompier()
        {
            InitializeComponent();
        }

        private string grade;
        private string grade2;
        private string matricule;
        private bool _estConnecte = false;

        public bool EstConnecte
        {
            get
            {
                return _estConnecte;
            }
            set
            {
                _estConnecte = value;
                btnLogin.Visible = !_estConnecte;
                btnChanger.Enabled = _estConnecte;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string requete = "SELECT nom FROM Caserne;";
            RemplirComboBoxDepuisSQLite(comboBox1, requete, "nom");
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            pictureBox2.Image = Image.FromFile(@"Images/Logo/Logo.png");

        }

        private void RemplirComboBoxDepuisSQLite(ComboBox combo, string requeteSQL, string colonneAffichage)
        {
            try
            {
                SQLiteConnection connec = Connexion.Connec;

                SQLiteCommand commande = new SQLiteCommand(requeteSQL, connec);
                SQLiteDataReader lecteur = commande.ExecuteReader();

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

        public void chargerListBox(ListBox lstBox, string requete, string[] colonnes)
        {
            SQLiteConnection connec = Connexion.Connec;

            SQLiteCommand commande = new SQLiteCommand(requete, connec);
            SQLiteDataReader reader = commande.ExecuteReader();

            lstBox.Items.Clear();

            while (reader.Read())
            {
                string ligne = "";
                for (int i = 0; i < colonnes.Length; i++)
                {
                    ligne += reader[colonnes[i]].ToString();

                    if (i < colonnes.Length - 1)
                        ligne += " | ";
                }

                lstBox.Items.Add(ligne);
            }
            reader.Close();
        }

        public void chargerListBox(ListBox lstBox, string requete, string colonne)
        {
            SQLiteConnection connec = Connexion.Connec;

            SQLiteCommand commande = new SQLiteCommand(requete, connec);
            SQLiteDataReader reader = commande.ExecuteReader();
            if (reader.Read())
            {
                lstBox.Items.Add(reader[colonne].ToString());
            }
        }

        private void RemplirComboBoxDepuisSQLite(ComboBox combo, string requeteSQL, string[] colonnesAffichage)
        {
            try
            {
                SQLiteConnection connec = Connexion.Connec;

                SQLiteCommand commande = new SQLiteCommand(requeteSQL, connec);
                SQLiteDataReader lecteur = commande.ExecuteReader();

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
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = null;
            grpBoxInfoPompier.Visible = false;
            grpBoxInfoCarriere.Visible = false;
            btnAfficherMoins.Visible = false;
            int caserneI = comboBox1.SelectedIndex + 1;
            string requete = "SELECT * FROM Pompier p JOIN Affectation a ON p.matricule = a.matriculePompier " +
                "JOIN Caserne c ON a.idCaserne = c.id WHERE c.id = '" + caserneI.ToString() + "';";
            string[] nomPrenom = { "nom", "prenom" };
            RemplirComboBoxDepuisSQLite(comboBox2, requete, nomPrenom);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null) return;
            btnChanger.Visible = false;
            grpBoxInfoPompier.Visible = true;
            btnAfficherPlus.Visible = true;

            string[] nomPrenom = comboBox2.SelectedItem.ToString().Trim().Split(' ');
            if (nomPrenom.Length < 2) return;

            string prenom = nomPrenom[nomPrenom.Length - 1];
            string nom = string.Join(" ", nomPrenom.Take(nomPrenom.Length - 1));
            string requete =
                "SELECT * " +
                "FROM   Pompier " +
                "WHERE  nom = @nom;";

            SQLiteConnection connec = Connexion.Connec;
            SQLiteCommand cmd = new SQLiteCommand(requete, connec);
            cmd.Parameters.AddWithValue("@nom", nom);
            SQLiteDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                matricule = reader["matricule"].ToString();
                grade = reader["codeGrade"].ToString();
                lblMatricule.Text = $"Matricule : {reader["matricule"]}";
                lblNom.Text = $"Nom : {reader["nom"]}";
                lblPrenom.Text = $"Prénom : {reader["prenom"]}";
                txtBoxGrade.Text = $"{reader["codeGrade"]}";
                DateTime dateE = reader.GetDateTime(reader.GetOrdinal("dateEmbauche"));
                lblED.Text = $"Date d'embauche : {dateE:dd/MM/yyyy}";
                lblBip.Text = $"Bip : {reader["bip"]}";
                lblTel.Text = $"Téléphone : {reader["portable"]}";
                DateTime dateN = reader.GetDateTime(reader.GetOrdinal("dateNaissance"));
                lblBD.Text = $"Date de naissance : {dateN:dd/MM/yyyy}";

                lblSexe.Text = $"Sexe : {(reader["sexe"].ToString() == "f" ? "Féminin" : "Masculin")}";

                bool professionnel = reader["type"].ToString() == "p";
                rdbProfessionnel.Checked = professionnel;
                rdbVolontaire.Checked = !professionnel;
                bool Conge = reader["enConge"].ToString() == "0";
                cBoxConge.Checked = !Conge;
            }
            reader.Close();
            cmd.Dispose();

            requete =
                "SELECT libelle " +
                "FROM Grade " +
                "WHERE code = '" + txtBoxGrade.Text + "'";

            cmd = new SQLiteCommand(requete, connec);
            cmd.Parameters.AddWithValue("@nom", nom);

            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                comboBox3.Text = $"{reader["libelle"]}";
            }

            else
            {
                MessageBox.Show("Pompier non trouvé !");
            }
            reader.Close();
            cmd.Dispose();
            requete = "SELECT DISTINCT libelle from Grade";
            RemplirComboBoxDepuisSQLite(comboBox3, requete, "libelle");
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Image = Image.FromFile(@"Images/ImagesGrades/" + txtBoxGrade.Text + ".png");
            lstBoxHabilitations.Items.Clear();
            lstBoxAffectations.Items.Clear();
            requete = "SELECT h.libelle FROM Habilitation h JOIN Passer s ON h.id = s.idHabilitation JOIN Pompier p ON s.matriculePompier = p.matricule WHERE p.matricule = '" + matricule + "';";
            chargerListBox(lstBoxHabilitations, requete, "libelle");
            requete = "SELECT a.dateA , c.nom FROM Affectation a JOIN Caserne c ON c.id = a.idCaserne JOIN Pompier p on a.matriculePompier = p.matricule WHERE p.matricule = '" + matricule + "' AND a.dateFin IS NOT NULL";
            string[] colonnes = { "dateA", "nom" };
            chargerListBox(lstBoxAffectations, requete, colonnes);
        }

        private void btnAfficherPlus_Click(object sender, EventArgs e)
        {
            btnAfficherPlus.Visible = false;
            btnAfficherMoins.Visible = true;
            grpBoxInfoCarriere.Visible = true;
            string requete = "SELECT nom FROM Caserne;";
            RemplirComboBoxDepuisSQLite(comboBox4, requete, "nom");
            comboBox4.SelectedIndex = comboBox1.SelectedIndex;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vos modifications ne seront pas enregistrées");
            Application.Exit();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxGrade.Enabled = false;
            string requete = "SELECT code FROM Grade where libelle = '" + comboBox3.Text + "';";
            SQLiteConnection connec = Connexion.Connec;
            SQLiteCommand cmd = new SQLiteCommand(requete, connec);
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtBoxGrade.Text = $"{reader["code"]}";
                grade2 = txtBoxGrade.Text;
            }
            pictureBox1.Image = Image.FromFile(@"Images/ImagesGrades/" + txtBoxGrade.Text + ".png");

            if (grade != grade2)
            {
                btnChanger.Visible = true;
            }
            else
            {
                btnChanger.Visible = false;
            }
        }

        private void btnAfficherMoins_Click(object sender, EventArgs e)
        {
            btnAfficherPlus.Visible = true;
            btnAfficherMoins.Visible = false;
            grpBoxInfoCarriere.Visible = false;
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            FormAjoutPompier form2 = new FormAjoutPompier();
            form2.ShowDialog();
        }

        private void btnChanger_Click(object sender, EventArgs e)
        {
            if (!EstConnecte)
            {
                FormLogin login = new FormLogin();
                login.ShowDialog();
                if (login.DialogResult == DialogResult.OK)
                {
                    EstConnecte = true;
                }
            }
            else
            {
                try
                {
                    grade = grade2;
                    btnChanger.Visible = false;
                    SQLiteConnection connec = Connexion.Connec;
                    string requete = "UPDATE Pompier SET codeGrade = @codeGrade WHERE matricule = @matricule;";
                    SQLiteCommand cmd = new SQLiteCommand(requete, connec);
                    cmd.Parameters.AddWithValue("@codeGrade", txtBoxGrade.Text);
                    cmd.Parameters.AddWithValue("@matricule", matricule);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Grade mis à jour avec succès !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la mise à jour du grade : " + ex.Message);
                }
            }
        }

        private void btnMaj_Click(object sender, EventArgs e)
        {
            if (!EstConnecte)
            {
                FormLogin login = new FormLogin();
                login.ShowDialog();
                if (login.DialogResult == DialogResult.OK)
                {
                    EstConnecte = true;
                }
            }
            else
            {
                try
                {

                    int caserneI = comboBox4.SelectedIndex + 1;
                    SQLiteConnection connec = Connexion.Connec;
                    string requete = "UPDATE Affectation SET idCaserne = @idCaserne WHERE matriculePompier = @matricule;";
                    SQLiteCommand cmd = new SQLiteCommand(requete, connec);
                    cmd.Parameters.AddWithValue("@idCaserne", caserneI);
                    cmd.Parameters.AddWithValue("@matricule", matricule);
                    cmd.ExecuteNonQuery();
                    if (cBoxConge.Checked)
                    {
                        string requete1 = "UPDATE Pompier SET enConge = 1";
                        SQLiteCommand cmd1 = new SQLiteCommand(requete1, connec);

                        cmd1.ExecuteNonQuery();
                    }


                    MessageBox.Show("Grade mis à jour avec succès !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la mise à jour du grade : " + ex.Message);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!EstConnecte)
            {
                FormLogin login = new FormLogin();
                login.ShowDialog();
                if (login.DialogResult == DialogResult.OK)
                {
                    EstConnecte = true;
                }
            }
        }
    }
}
