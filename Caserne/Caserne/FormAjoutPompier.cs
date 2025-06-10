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
    public partial class FormAjoutPompier : Form
    {
        public FormAjoutPompier()
        {
            InitializeComponent();
        }

        private int matricule;
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

        public void chargerCheckedListBox(CheckedListBox lstBox, string requete, string colonne)
        {
            SQLiteConnection connec = Connexion.Connec;
            SQLiteCommand commande = new SQLiteCommand(requete, connec);
            SQLiteDataReader reader = commande.ExecuteReader();
            lstBox.Items.Clear();
            while (reader.Read())
            {
                lstBox.Items.Add(reader[colonne].ToString());
            }
            reader.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            bool estSexe = rdbFeminin.Checked || rdbMasculin.Checked;
            bool estSituation = rdbProfessionnel.Checked || rdbVolontaire.Checked;
            if (string.IsNullOrEmpty(txtBoxNom.Text))
            {
                MessageBox.Show("Le champ 'Nom' est obligatoire.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtBoxPrenom.Text))
            {
                MessageBox.Show("Le champ 'Prénom' est obligatoire.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtBoxBip.Text))
            {
                MessageBox.Show("Le champ 'Bip' est obligatoire.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtBoxTel.Text))
            {
                MessageBox.Show("Le champ 'Téléphone' est obligatoire.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboJours.SelectedIndex < 0)
            {
                MessageBox.Show("Veuillez sélectionner un jour de naissance.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboMois.SelectedIndex < 0)
            {
                MessageBox.Show("Veuillez sélectionner un mois de naissance.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboAnnee.SelectedIndex < 0)
            {
                MessageBox.Show("Veuillez sélectionner une année de naissance.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!rdbFeminin.Checked && !rdbMasculin.Checked)
            {
                MessageBox.Show("Veuillez sélectionner un sexe.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!rdbProfessionnel.Checked && !rdbVolontaire.Checked)
            {
                MessageBox.Show("Veuillez sélectionner une situation.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboCaserne.SelectedIndex < 0)
            {
                MessageBox.Show("Veuillez sélectionner une caserne.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboGrade.SelectedIndex < 0)
            {
                MessageBox.Show("Veuillez sélectionner un grade.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string nom = txtBoxNom.Text.Trim();
                string prenom = txtBoxPrenom.Text.Trim();
                string bip = txtBoxBip.Text.Trim();
                string telephone = txtBoxTel.Text.Trim();
                string dateNaissance = $"{cboAnnee.SelectedItem}-{cboMois.SelectedItem}-{cboJours.SelectedItem}";
                string sexe = rdbFeminin.Checked ? "f" : "m";
                string situation = rdbProfessionnel.Checked ? "p" : "v";
                int caserne = cboCaserne.SelectedIndex + 1;
                string grade = txtBoxGrade.Text;
                int enMission = 0;
                int enConge = 0;
                string codeGrade;
                string dateEmbauche = DateTime.Now.ToString("yyyy-MM-dd");
                string requeteAjoutPompier = @"INSERT INTO Pompier (matricule, nom, prenom, sexe, dateNaissance, type, portable, bip, enMission, enConge, codeGrade, dateEmbauche) VALUES (@matricule, @nom, @prenom, @sexe, @dateNaissance, @type, @portable, @bip, @enMission, @enConge, @codeGrade, @dateEmbauche);";
                string requeteAjoutCaserne = @"INSERT INTO Affectation (matriculePompier, dateA, idCaserne) VALUES (@matricule, @dateEmbauche, @caserne);";
                SQLiteConnection connec = Connexion.Connec;
                SQLiteCommand cmd = new SQLiteCommand(requeteAjoutPompier, connec);
                SQLiteCommand cmd2 = new SQLiteCommand(requeteAjoutCaserne , connec);
                cmd.Parameters.AddWithValue("@matricule", matricule);
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@prenom", prenom);
                cmd.Parameters.AddWithValue("@sexe", sexe);
                cmd.Parameters.AddWithValue("@dateNaissance", dateNaissance);
                cmd.Parameters.AddWithValue("@type", situation);
                cmd.Parameters.AddWithValue("@portable", telephone);
                cmd.Parameters.AddWithValue("@bip", bip);
                cmd.Parameters.AddWithValue("@enMission", enMission);
                cmd.Parameters.AddWithValue("@enConge", enConge);
                cmd.Parameters.AddWithValue("@codeGrade", grade);
                cmd.Parameters.AddWithValue("@dateEmbauche", dateEmbauche);
                cmd2.Parameters.AddWithValue("@matricule", matricule);
                cmd2.Parameters.AddWithValue("@dateEmbauche", dateEmbauche);
                cmd2.Parameters.AddWithValue("@caserne", caserne);
                VerifierCheckListBox(cblHabilitations);
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show(nom + " " + prenom + "a bien été ajouté.");
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout du pompier : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerifierCheckListBox(CheckedListBox checkedListBox)
        {
            string requete;
            SQLiteConnection connec = Connexion.Connec;

            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                bool estCoche = checkedListBox.GetItemChecked(i);
                if (estCoche)
                {
                    requete = "INSERT INTO Passer (matriculePompier, idHabilitation, dateObtention) VALUES " + matricule + "," + i + 1 + "," + DateTime.Now.ToString("yyyy-MM-dd") +";";
                    SQLiteCommand cmd = new SQLiteCommand(requete, connec);
                }
            }
        }

        private void FormAjoutPompier_Load(object sender, EventArgs e)
        {
            string requetematricule = "SELECT max(matricule) FROM Pompier ;";

            SQLiteConnection connec = Connexion.Connec;
            SQLiteCommand cmd = new SQLiteCommand(requetematricule, connec);
            SQLiteDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                matricule = Convert.ToInt32(reader[0]) + 1;
            }
            lblMatricule.Text += matricule.ToString();
            cboJours.Items.Clear();
            for (int i = 1; i <= 31; i++)
            {
                cboJours.Items.Add(i.ToString("00"));
            }
            cboMois.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cboMois.Items.Add(i.ToString("00"));
            }
            cboAnnee.Items.Clear();
            int anneeCourante = DateTime.Now.Year - 18;
            for (int i = anneeCourante; i >= 1950; i--) {
                cboAnnee.Items.Add(i.ToString());
            }
            string requete = "SELECT nom FROM Caserne";
            RemplirComboBoxDepuisSQLite(cboCaserne, requete, "nom");
            requete = "SELECT libelle FROM Grade";
            RemplirComboBoxDepuisSQLite(cboGrade, requete, "libelle");
            requete = "SELECT libelle FROM Habilitation";
            chargerCheckedListBox(cblHabilitations, requete, "libelle");
        }

        private void txtBoxNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtBoxPrenom.Focus();
                return;
            }

            if (char.IsControl(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) &&
                e.KeyChar != ' ' &&
                e.KeyChar != '-' &&
                e.KeyChar != '\'')
            {
                e.Handled = true;
            }

            TextBox tb = sender as TextBox;
            int selectionStart = tb.SelectionStart;
            string text = tb.Text;

            if ((e.KeyChar == '-' || e.KeyChar == ' ' || e.KeyChar == '\'') && selectionStart == 0)
            {
                e.Handled = true;
                return;
            }

            if ((e.KeyChar == '-' || e.KeyChar == ' ' || e.KeyChar == '\'') &&
                selectionStart > 0 &&
                text.Length > 0 &&
                (text[selectionStart - 1] == e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (char.IsLetter(e.KeyChar))
            {
                if (selectionStart == 0)
                    e.KeyChar = char.ToUpper(e.KeyChar);
                else
                    e.KeyChar = char.ToLower(e.KeyChar);
            }
        }

        private void txtBoxPrenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtBoxTel.Focus();
                return;
            }

            if (char.IsControl(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-' && e.KeyChar != '\'')
            {
                e.Handled = true;
            }

            TextBox tb = sender as TextBox;
            int selectionStart = tb.SelectionStart;
            string text = tb.Text;

            if ((e.KeyChar == '-' || e.KeyChar == ' ' || e.KeyChar == '\'') && selectionStart == 0)
            {
                e.Handled = true;
                return;
            }

            if ((e.KeyChar == '-' || e.KeyChar == ' ' || e.KeyChar == '\'') &&
                selectionStart > 0 &&
                text.Length > 0 &&
                (text[selectionStart - 1] == e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (char.IsLetter(e.KeyChar))
            {
                if (selectionStart == 0)
                    e.KeyChar = char.ToUpper(e.KeyChar);
                else
                    e.KeyChar = char.ToLower(e.KeyChar);
            }
        }

        private void txtBoxTel_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                e.Handled = true;
                txtBoxBip.Focus();
                return;
            }

            if (char.IsControl(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (!char.IsControl(e.KeyChar) && txtBoxTel.Text.Length >= 10 && txtBoxTel.SelectionLength == 0)
            {
                e.Handled = true;
                return;
            }
        }

        private void txtBoxBip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                e.Handled = true;
                txtBoxBip.Focus();
                return;
            }

            if (char.IsControl(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (!char.IsControl(e.KeyChar) && txtBoxBip.Text.Length >= 6 && txtBoxBip.SelectionLength == 0)
            {
                e.Handled = true;
                return;
            }
        }

        private void UpdateJoursComboBox()
        {
            if (cboMois.SelectedIndex < 0 || cboAnnee.SelectedIndex < 0)
                return;

            int mois = cboMois.SelectedIndex + 1;
            int annee = int.Parse(cboAnnee.SelectedItem.ToString());
            int joursDansMois = DateTime.DaysInMonth(annee, mois);

            int jourSelectionne = cboJours.SelectedIndex >= 0 ? cboJours.SelectedIndex : 0;

            cboJours.Items.Clear();
            for (int i = 1; i <= joursDansMois; i++)
                cboJours.Items.Add(i.ToString("00"));

            // Rétablir la sélection si possible
            if (jourSelectionne < joursDansMois)
                cboJours.SelectedIndex = jourSelectionne;
            else
                cboJours.SelectedIndex = joursDansMois - 1;
        }

        private void cboMois_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateJoursComboBox();
        }

        private void cboAnnee_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateJoursComboBox();
        }

        private void cboGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            string requete = "SELECT code FROM Grade WHERE libelle = @libelle";
            SQLiteConnection connec = Connexion.Connec;
            SQLiteCommand cmd = new SQLiteCommand(requete, connec);
            cmd.Parameters.AddWithValue("@libelle", cboGrade.Text);
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtBoxGrade.Text = reader["code"].ToString();
            }
        }
    }
}
