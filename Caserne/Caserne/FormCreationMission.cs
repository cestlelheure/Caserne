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

namespace Caserne
{
    public partial class FormCreationMission : Form
    {
        public FormCreationMission()
        {
            InitializeComponent();
            chargerlibelle();
            chargerCaserne();
            NumeroMission();
        }

        public class MissionLocale
        {
            public int Numero { get; set; }
            public DateTime DateHeureDepart { get; set; }
            public string Motif { get; set; }
            public string Adresse { get; set; }
            public string CP { get; set; }
            public string Ville { get; set; }
            public string Caserne { get; set; }
            public string NatureSinistre { get; set; }
            public DataTable Engins { get; set; }
            public DataTable Pompiers { get; set; }

            public MissionLocale()
            {
                Engins = new DataTable();
                Pompiers = new DataTable();
            }
        }

        private void tbMotifMission_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Vérifier si la touche pressée est une lettre ou un espace
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorer la touche
            }
        }

        private void tbRueSinistre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Vérifier si la touche pressée est une lettre ou un espace
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorer la touche
            }
        }

        private void tbCodePostalSinistre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignorer la touche
            }
        }

        private void tbVilleSinistre_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorer la touche
            }
        }

        private void chargerlibelle()
        {
            try
            {
                // Connexion à la base de données
                SQLiteConnection connection = Connexion.Connec;
                // Requête pour récupérer les types de sinistre
                string requete = "SELECT libelle FROM NatureSinistre";
                SQLiteCommand command = new SQLiteCommand(requete, connection);
                SQLiteDataReader reader = command.ExecuteReader();
                // Remplissage de la liste déroulante avec les types de sinistre
                while (reader.Read())
                {
                    cmbNatureSinistre.Items.Add(reader["libelle"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des types de sinistre : " + ex.Message);
            }
        }

        private void chargerCaserne()
        {
            try
            {
                // Connexion à la base de données
                SQLiteConnection connection = Connexion.Connec;
                // Requête pour récupérer les casernes
                string requete = "SELECT nom FROM Caserne";
                SQLiteCommand command = new SQLiteCommand(requete, connection);
                SQLiteDataReader reader = command.ExecuteReader();
                // Remplissage de la liste déroulante avec les casernes
                while (reader.Read())
                {
                    cmbCaserneMobiliser.Items.Add(reader["nom"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des casernes : " + ex.Message);
            }
        }

        private void NumeroMission()
        {
            try
            {
                // Connexion à la base de données
                SQLiteConnection connection = Connexion.Connec;
                // Requête pour récupérer le dernier numéro de mission
                string requete = "SELECT MAX(id) FROM Mission";
                SQLiteCommand command = new SQLiteCommand(requete, connection);
                SQLiteDataReader reader = command.ExecuteReader();
                // Affichage du numéro de mission
                if (reader.Read())
                {
                    int numeroMission = reader.IsDBNull(0) ? 1 : reader.GetInt32(0) + 1;
                    lblNumMission.Text = "Mission n° " + numeroMission.ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement du numéro de mission : " + ex.Message);
            }
        }

        private int obtenirIdNatureSinistre(string libelle)
        {
            try
            {
                string sql = "SELECT Id FROM NatureSinistre WHERE libelle = @lib";
                SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);
                cmd.Parameters.AddWithValue("@lib", libelle);
                object result = cmd.ExecuteScalar();
                return (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur dans ObtenirIdNatureSinistre : " + ex.Message);
                return -1;
            }
        }

        private int obtenirIdCaserne(string nom)
        {
            try
            {
                string sql = "SELECT Id FROM Caserne WHERE nom = @nom";
                SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);
                cmd.Parameters.AddWithValue("@nom", nom);
                object result = cmd.ExecuteScalar();
                return (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur dans ObtenirIdCaserne : " + ex.Message);
                return -1;
            }
        }

        private DataTable ObtenirEnginsPourSinistre(int idNatureSinistre, int idCaserne)
        {
            DataTable table = new DataTable();
            try
            {
                // Requête corrigée basée sur le diagramme fourni
                string sql = @"SELECT e.numero AS idEngin, e.numero AS numeroEngin
                FROM Engin e
                INNER JOIN Caserne c ON e.idCaserne = c.id
                WHERE c.id = @idCaserne
                AND e.enMission = 0
                AND e.enPanne = 0
                AND e.codeTypeEngin IN (
                    SELECT n.codeTypeEngin
                    FROM Necessiter n
                    WHERE n.idNatureSinistre = @idNatureSinistre
                )";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec))
                {
                    cmd.Parameters.AddWithValue("@idNatureSinistre", idNatureSinistre);
                    cmd.Parameters.AddWithValue("@idCaserne", idCaserne);
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur dans ObtenirEnginsPourSinistre : " + ex.Message);
            }
            return table;
        }

        private void ChargerEnginsDisponibles()
        {
            try
            {
                // Vérification que les éléments sont sélectionnés
                if (cmbNatureSinistre.SelectedItem == null || cmbCaserneMobiliser.SelectedItem == null)
                {
                    MessageBox.Show("Veuillez sélectionner une nature de sinistre et une caserne.");
                    return;
                }

                int natureSinistreId = obtenirIdNatureSinistre(cmbNatureSinistre.SelectedItem.ToString());
                int caserneId = obtenirIdCaserne(cmbCaserneMobiliser.SelectedItem.ToString());
                DataTable enginsDispo = ObtenirEnginsPourSinistre(natureSinistreId, caserneId);
                dgvEngins.DataSource = enginsDispo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des engins : " + ex.Message);
            }
        }

        private DataTable ObtenirPompierPourSinistre(int idNatureSinistre, int idHabilitation, int idCaserne)
        {
            DataTable table = new DataTable();
            try
            {
                string sql = @"SELECT p.matricule AS idPompier, p.nom || ' ' || p.prenom AS nomPompier
                       FROM Pompier p
                       INNER JOIN Passer pass ON p.matricule = pass.matriculePompier
                       INNER JOIN Affectation a ON p.matricule = a.matriculePompier
                       WHERE p.enConge = 0
                         AND p.enMission = 0
                         AND pass.idHabilitation = @idHabilitation
                         AND a.idCaserne = @idCaserne
                         AND (a.dateFin IS NULL OR a.dateFin > DATE('now'))";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec))
                {
                    cmd.Parameters.AddWithValue("@idHabilitation", idHabilitation);
                    cmd.Parameters.AddWithValue("@idCaserne", idCaserne);

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur dans ObtenirPompierPourSinistre : " + ex.Message);
            }
            return table;
        }


        private void ChargerPompiersDisponibles()
        {
            try
            {
                if (cmbNatureSinistre.SelectedItem == null || cmbCaserneMobiliser.SelectedItem == null)
                {
                    MessageBox.Show("Veuillez sélectionner une nature de sinistre et une caserne.");
                    return;
                }

                int natureSinistreId = obtenirIdNatureSinistre(cmbNatureSinistre.SelectedItem.ToString());
                int caserneId = obtenirIdCaserne(cmbCaserneMobiliser.SelectedItem.ToString());

                int habilitationRequise = ObtenirHabilitationRequise(natureSinistreId);
                if (habilitationRequise == -1)
                {
                    MessageBox.Show("Impossible de déterminer l'habilitation requise pour ce type de sinistre.");
                    return;
                }

                DataTable pompiersDisponibles = ObtenirPompierPourSinistre(natureSinistreId, habilitationRequise, caserneId);
                dgvPompier.DataSource = pompiersDisponibles;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des pompiers : " + ex.Message);
            }
        }
        private int ObtenirHabilitationRequise(int idNatureSinistre)
        {
            try
            {
                string sql = "SELECT id FROM NatureSinistre WHERE id = @idNatureSinistre";
                SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);
                cmd.Parameters.AddWithValue("@idNatureSinistre", idNatureSinistre);
                object result = cmd.ExecuteScalar();
                return (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur dans ObtenirHabilitationRequise : " + ex.Message);
                return -1;
            }
        }

        private bool VerifierRessourcesDisponibles()
        {
            // Vérifier si des engins sont disponibles
            if (dgvEngins.Rows.Count == 0)
            {
                MessageBox.Show("Attention : Aucun engin disponible dans cette caserne pour ce type de sinistre. Veuillez choisir une autre caserne.");
                return false;
            }

            // Vérifier si des pompiers sont disponibles
            if (dgvPompier.Rows.Count == 0)
            {
                MessageBox.Show("Attention : Aucun pompier disponible avec l'habilitation requise pour ce type de sinistre. Veuillez choisir une autre caserne.");
                return false;
            }

            return true;
        }

        // Modifier la méthode bttnValider_Click pour appeler ces nouvelles fonctions
        private void bttnValider_Click(object sender, EventArgs e)
        {
            ChargerEnginsDisponibles();
            ChargerPompiersDisponibles();

            // Vérifier si les ressources sont disponibles
            if (!VerifierRessourcesDisponibles())
            {
                // Si non disponibles, suggérer de changer de caserne
                // Le message est déjà affiché dans la méthode VerifierRessourcesDisponibles
            }
            else
            {
                // Si ressources disponibles, permettre à l'utilisateur de continuer
                // Par exemple, activer un bouton de confirmation
                //btnConfirmerMission.Enabled = true;
            }
        }

        /*private void bttnValider_Click(object sender, EventArgs e)
        {
            ChargerEnginsDisponibles();
        }*/
    }
}
