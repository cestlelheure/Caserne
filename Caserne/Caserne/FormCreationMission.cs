using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Data.SQLite;

namespace Caserne
{
    public partial class FormCreationMission : Form
    {
        private MissionLocale missionEnCours;

        public FormCreationMission()
        {
            InitializeComponent();
            InitialiserFormulaire();
        }

        public class MissionLocale
        {
            public int Numero { get; set; }
            public DateTime DateHeureDepart { get; set; }
            public string Motif { get; set; }
            public string Adresse { get; set; }
            public string CP { get; set; }
            public string Ville { get; set; }
            public int IdCaserne { get; set; }
            public int IdNatureSinistre { get; set; }
            public DataTable Engins { get; set; }
            public DataTable Pompiers { get; set; }

            public MissionLocale()
            {
                Engins = new DataTable();
                Pompiers = new DataTable();
                DateHeureDepart = DateTime.Now;
            }
        }

        #region Initialisation
        private void InitialiserFormulaire()
        {
            RemplirComboBox(cmbNatureSinistre, "SELECT libelle FROM NatureSinistre", "types de sinistre");
            RemplirComboBox(cmbCaserneMobiliser, "SELECT nom FROM Caserne", "casernes");
            AfficherNumeroMission();
            lblDateDebut.Text = $"Mission déclenchée le : {DateTime.Now:dd/MM/yyyy HH:mm}";
        }

        private void RemplirComboBox(ComboBox combo, string requete, string typeErreur)
        {
            try
            {
                combo.Items.Clear();
                using (SQLiteCommand command = new SQLiteCommand(requete, Connexion.Connec))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        combo.Items.Add(reader[0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des {typeErreur} : {ex.Message}");
            }
        }

        private void AfficherNumeroMission()
        {
            try
            {
                int numeroMission = ObtenirProchainNumero("SELECT MAX(id) FROM Mission");
                lblNumMission.Text = $"Mission n° {numeroMission}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement du numéro de mission : {ex.Message}");
            }
        }

        private int ObtenirProchainNumero(string requete)
        {
            using (SQLiteCommand command = new SQLiteCommand(requete, Connexion.Connec))
            {
                object result = command.ExecuteScalar();
                return result == null || result == DBNull.Value ? 1 : Convert.ToInt32(result) + 1;
            }
        }
        #endregion

        #region Validation des champs
        private void tbMotifMission_KeyPress(object sender, KeyPressEventArgs e) => ValiderSaisieTexte(e);
        private void tbRueSinistre_KeyPress(object sender, KeyPressEventArgs e) => ValiderSaisieTexte(e);
        private void tbVilleSinistre_KeyPress(object sender, KeyPressEventArgs e) => ValiderSaisieTexte(e);
        private void tbCodePostalSinistre_KeyPress(object sender, KeyPressEventArgs e) => ValiderSaisieNumerique(e);

        private static void ValiderSaisieTexte(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) &&
                e.KeyChar != ' ' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private static void ValiderSaisieNumerique(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Méthodes utilitaires
        private int ObtenirId(string table, string colonne, string valeur, string nomColonne = "id")
        {
            try
            {
                string sql = $"SELECT {nomColonne} FROM {table} WHERE {colonne} = @valeur";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec))
                {
                    cmd.Parameters.AddWithValue("@valeur", valeur);
                    object result = cmd.ExecuteScalar();
                    return result != null && result != DBNull.Value ? Convert.ToInt32(result) : -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur dans la récupération de l'ID de {table} : {ex.Message}");
                return -1;
            }
        }

        private int ObtenirIdNatureSinistre(string libelle) => ObtenirId("NatureSinistre", "libelle", libelle);
        private int ObtenirIdCaserne(string nom) => ObtenirId("Caserne", "nom", nom);

        private string ObtenirNomCaserne(int idCaserne)
        {
            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT nom FROM Caserne WHERE id = @id", Connexion.Connec))
                {
                    cmd.Parameters.AddWithValue("@id", idCaserne);
                    return cmd.ExecuteScalar()?.ToString() ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération du nom de caserne : {ex.Message}");
                return "";
            }
        }
        #endregion

        #region Gestion des ressources
        private DataTable ObtenirDonnees(string requete, params SQLiteParameter[] parametres)
        {
            DataTable table = new DataTable();
            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(requete, Connexion.Connec))
                {
                    if (parametres != null)
                        cmd.Parameters.AddRange(parametres);

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la récupération des données : {ex.Message}");
            }
            return table;
        }

        private DataTable ObtenirEnginsPourSinistre(int idNatureSinistre, int idCaserne)
        {
            const string sql = @"SELECT 
                                e.numero, 
                                t.nom as TypeEngin, 
                                e.dateReception, 
                                e.codeTypeEngin,
                                n.nombre as NombreNecessaire
                             FROM Necessiter n
                             INNER JOIN TypeEngin t ON n.codeTypeEngin = t.code
                             INNER JOIN Engin e ON t.code = e.codeTypeEngin
                             WHERE n.idNatureSinistre = @idNatureSinistre
                             AND e.idCaserne = @idCaserne
                             AND e.enMission = 0 AND e.enPanne = 0
                             ORDER BY e.codeTypeEngin, e.dateReception";

            DataTable resultTemp = ObtenirDonnees(sql,
                new SQLiteParameter("@idNatureSinistre", idNatureSinistre),
                new SQLiteParameter("@idCaserne", idCaserne));

            return FiltrerEnginsParQuantite(resultTemp);
        }

        private static DataTable FiltrerEnginsParQuantite(DataTable engins)
        {
            if (engins.Rows.Count == 0) return engins;

            DataTable result = engins.Clone();
            System.Collections.Generic.IEnumerable<System.Linq.IGrouping<string, DataRow>> groupes = engins.AsEnumerable()
                .GroupBy(row => row.Field<string>("codeTypeEngin"));

            foreach (System.Linq.IGrouping<string, DataRow> groupe in groupes)
            {
                int nombreNecessaire = Convert.ToInt32(groupe.First().Field<object>("NombreNecessaire"));
                System.Collections.Generic.IEnumerable<DataRow> enginsSelectionnes = groupe.Take(nombreNecessaire);

                foreach (DataRow engin in enginsSelectionnes)
                {
                    result.ImportRow(engin);
                }
            }

            return result;
        }

        private DataTable ObtenirPompiersDisponibles(int idNatureSinistre, int idCaserne)
        {
            int nombrePompiersNecessaires = CalculerNombrePompiersNecessaires(idNatureSinistre);

            const string sql = @"SELECT DISTINCT p.matricule, p.nom, p.prenom, g.libelle as Grade,
                                GROUP_CONCAT(DISTINCT h.libelle) as Habilitations
                        FROM Pompier p
                        INNER JOIN Grade g ON p.codeGrade = g.code
                        INNER JOIN Affectation af ON p.matricule = af.matriculePompier
                        INNER JOIN Passer pa ON p.matricule = pa.matriculePompier
                        INNER JOIN Habilitation h ON pa.idHabilitation = h.id
                        WHERE p.enConge = 0 AND p.enMission = 0
                        AND af.idCaserne = @idCaserne
                        AND (af.dateFin IS NULL OR af.dateFin > date('now'))
                        AND EXISTS (
                            SELECT 1 FROM Embarquer emb 
                            INNER JOIN Necessiter n ON emb.codeTypeEngin = n.codeTypeEngin
                            WHERE emb.idHabilitation = h.id 
                            AND n.idNatureSinistre = @idNatureSinistre
                        )
                        GROUP BY p.matricule, p.nom, p.prenom, g.libelle
                        ORDER BY g.rang DESC, p.nom, p.prenom
                        LIMIT @nombrePompiers";

            return ObtenirDonnees(sql,
                new SQLiteParameter("@idNatureSinistre", idNatureSinistre),
                new SQLiteParameter("@idCaserne", idCaserne),
                new SQLiteParameter("@nombrePompiers", nombrePompiersNecessaires));
        }

        private int CalculerNombrePompiersNecessaires(int idNatureSinistre)
        {
            const string sql = @"SELECT SUM(n.nombre * t.equipage) as TotalPompiers
                               FROM Necessiter n
                               INNER JOIN TypeEngin t ON n.codeTypeEngin = t.code
                               WHERE n.idNatureSinistre = @idNatureSinistre";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec))
                {
                    cmd.Parameters.AddWithValue("@idNatureSinistre", idNatureSinistre);
                    object result = cmd.ExecuteScalar();
                    return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 10;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur calcul nombre pompiers : {ex.Message}");
                return 10; // Valeur par défaut
            }
        }

        private int TrouverCaserneAvecEngins(int idNatureSinistre)
        {
            const string sql = @"SELECT c.id FROM Caserne c
                        INNER JOIN Engin e ON c.id = e.idCaserne
                        WHERE e.enMission = 0 AND e.enPanne = 0
                        AND e.codeTypeEngin IN (
                            SELECT n.codeTypeEngin FROM Necessiter n WHERE n.idNatureSinistre = @idNatureSinistre
                        )
                        GROUP BY c.id, c.nom
                        ORDER BY COUNT(*) DESC
                        LIMIT 1";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec))
                {
                    cmd.Parameters.AddWithValue("@idNatureSinistre", idNatureSinistre);
                    object result = cmd.ExecuteScalar();
                    return result != null && result != DBNull.Value ? Convert.ToInt32(result) : -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la recherche d'une caserne alternative : {ex.Message}");
                return -1;
            }
        }
        #endregion

        #region Traitement principal
        private void ChargerRessourcesDisponibles()
        {
            if (!ValiderSelections()) return;

            int natureSinistreId = ObtenirIdNatureSinistre(cmbNatureSinistre.SelectedItem.ToString());
            int caserneId = ObtenirIdCaserne(cmbCaserneMobiliser.SelectedItem.ToString());

            if (natureSinistreId == -1 || caserneId == -1)
            {
                MessageBox.Show("Erreur dans la récupération des identifiants.");
                return;
            }

            DataTable enginsDispo = ObtenirEnginsPourSinistre(natureSinistreId, caserneId);
            DataTable pompiersDispos = ObtenirPompiersDisponibles(natureSinistreId, caserneId);

            dgvEngins.DataSource = enginsDispo;
            dgvPompier.DataSource = pompiersDispos;

            if (!VerifierRessourcesDisponibles(enginsDispo, pompiersDispos))
            {
                ProposerAutresCasernes(natureSinistreId, caserneId);
            }
            else
            {
                CreerMissionLocale(natureSinistreId, caserneId, enginsDispo, pompiersDispos);
            }
        }

        private bool ValiderSelections()
        {
            if (cmbNatureSinistre.SelectedItem == null || cmbCaserneMobiliser.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une nature de sinistre et une caserne.");
                return false;
            }
            return true;
        }

        private static bool VerifierRessourcesDisponibles(DataTable engins, DataTable pompiers)
        {
            if (engins.Rows.Count == 0) return false;

            if (pompiers.Rows.Count == 0)
            {
                MessageBox.Show("Attention : Aucun pompier disponible avec les habilitations requises. " +
                              "La mission sera déclenchée avec une équipe incomplète.");
            }
            return true;
        }

        private void ProposerAutresCasernes(int idNatureSinistre, int caserneActuelle)
        {
            int nouvelleCaserne = TrouverCaserneAvecEngins(idNatureSinistre);

            if (nouvelleCaserne != -1 && nouvelleCaserne != caserneActuelle)
            {
                string nomCaserne = ObtenirNomCaserne(nouvelleCaserne);
                if (ProposerChangementCaserne(nomCaserne))
                {
                    cmbCaserneMobiliser.SelectedItem = nomCaserne;
                    ChargerRessourcesDisponibles();
                }
            }
            else
            {
                MessageBox.Show("Aucune caserne ne dispose actuellement des engins nécessaires pour ce type de sinistre.");
            }
        }

        private static bool ProposerChangementCaserne(string nomCaserne)
        {
            return MessageBox.Show(
                $"Les engins nécessaires ne sont pas disponibles dans la caserne sélectionnée.\n" +
                $"Voulez-vous attribuer la mission à la caserne '{nomCaserne}' qui dispose des ressources nécessaires ?",
                "Changement de caserne", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void CreerMissionLocale(int idNatureSinistre, int idCaserne, DataTable engins, DataTable pompiers)
        {
            try
            {
                missionEnCours = new MissionLocale
                {
                    Numero = int.Parse(lblNumMission.Text.Replace("Mission n° ", "")),
                    DateHeureDepart = DateTime.Now,
                    Motif = tbMotifMission.Text,
                    Adresse = tbRueSinistre.Text,
                    CP = tbCodePostalSinistre.Text,
                    Ville = tbVilleSinistre.Text,
                    IdCaserne = idCaserne,
                    IdNatureSinistre = idNatureSinistre,
                    Engins = engins.Copy(),
                    Pompiers = pompiers.Copy()
                };

                MessageBox.Show("Mission créée en mode local. Elle sera enregistrée dans la base lors de la clôture.",
                              "Mission créée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la création de la mission locale : {ex.Message}");
            }
        }
        #endregion

        #region Événements des boutons
        private void bttnValider_Click(object sender, EventArgs e)
        {
            if (!ValiderFormulaire()) return;
            ChargerRessourcesDisponibles();
        }

        private bool ValiderFormulaire()
        {
            // Vérification des champs obligatoires
            if (string.IsNullOrWhiteSpace(tbMotifMission.Text))
                return AfficherErreurValidation("Motif de mission");

            if (string.IsNullOrWhiteSpace(tbRueSinistre.Text))
                return AfficherErreurValidation("Adresse");

            if (string.IsNullOrWhiteSpace(tbCodePostalSinistre.Text))
                return AfficherErreurValidation("Code postal");

            if (string.IsNullOrWhiteSpace(tbVilleSinistre.Text))
                return AfficherErreurValidation("Ville");

            if (cmbNatureSinistre.SelectedItem == null || cmbCaserneMobiliser.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une nature de sinistre et une caserne.", "Sélection manquante",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (tbCodePostalSinistre.Text.Length != 5)
            {
                MessageBox.Show("Le code postal doit contenir 5 chiffres.", "Code postal invalide",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private static bool AfficherErreurValidation(string nomChamp)
        {
            MessageBox.Show($"Le champ '{nomChamp}' est obligatoire.", "Champ manquant",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        #endregion

        private void FormCreationMission_Load(object sender, EventArgs e)
        {

        }

        private void bttnAnnuler_Click(object sender, EventArgs e)
        {

        }

        private void bttnEffacerInfos_Click(object sender, EventArgs e)
        {

        }

        private void bttnValiderInfos_Click(object sender, EventArgs e)
        {

        }
    }
}