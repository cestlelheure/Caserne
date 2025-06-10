using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Data.SQLite;
using Caserne;

namespace Caserne
{
    public partial class FormCreationMission : Form
    {
        private MissionLocale missionEnCours;
        private int numeroMission;
        private string dateHeure;

        // Tables du DataSet global (mode déconnecté)
        private DataTable dtMission;
        private DataTable dtMobiliser;
        private DataTable dtPartirAvec;
        private DataTable dtPompier;
        private DataTable dtEngin;
        private DataTable dtNatureSinistre;
        private DataTable dtCaserne;
        private DataTable dtNecessiter;
        private DataTable dtTypeEngin;
        private DataTable dtEmbarquer;
        private DataTable dtPasser;
        private DataTable dtAffectation;

        private int[] idHabilitation;
        private int[] idHabi;

        // Utilisation de la classe Connexion existante

        public FormCreationMission()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            ChargerDonneesBase();
            InitialiserModeDeconnecte();
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

        #region Chargement des données depuis la base
        private void ChargerDonneesBase()
        {
            try
            {
                SQLiteConnection connection = Connexion.Connec;
                
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    // Charger toutes les tables nécessaires
                    ChargerTable(connection, "Mission", "SELECT * FROM Mission");
                    ChargerTable(connection, "Mobiliser", "SELECT * FROM Mobiliser");
                    ChargerTable(connection, "PartirAvec", "SELECT * FROM PartirAvec");
                    ChargerTable(connection, "Pompier", "SELECT * FROM Pompier");
                    ChargerTable(connection, "Engin", "SELECT * FROM Engin");
                    ChargerTable(connection, "NatureSinistre", "SELECT * FROM NatureSinistre");
                    ChargerTable(connection, "Caserne", "SELECT * FROM Caserne");
                    ChargerTable(connection, "Necessiter", "SELECT * FROM Necessiter");
                    ChargerTable(connection, "TypeEngin", "SELECT * FROM TypeEngin");
                    ChargerTable(connection, "Embarquer", "SELECT * FROM Embarquer");
                    ChargerTable(connection, "Passer", "SELECT * FROM Passer");
                    ChargerTable(connection, "Affectation", "SELECT * FROM Affectation");
                }
                else
                {
                    MessageBox.Show("Impossible d'établir la connexion à la base de données.", 
                                  "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des données : {ex.Message}", 
                              "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChargerTable(SQLiteConnection connection, string nomTable, string requete)
        {
            try
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(requete, connection);
                DataTable table = new DataTable(nomTable);
                adapter.Fill(table);
                
                // Supprimer la table existante si elle existe déjà
                if (MesDatas.DsGlobal.Tables.Contains(nomTable))
                {
                    MesDatas.DsGlobal.Tables.Remove(nomTable);
                }
                
                MesDatas.DsGlobal.Tables.Add(table);
                adapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement de la table {nomTable} : {ex.Message}", 
                              "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Initialisation Mode Déconnecté
        private void InitialiserModeDeconnecte()
        {
            // Récupération des tables depuis le DataSet global
            dtMission = MesDatas.DsGlobal.Tables["Mission"];
            dtMobiliser = MesDatas.DsGlobal.Tables["Mobiliser"];
            dtPartirAvec = MesDatas.DsGlobal.Tables["PartirAvec"];
            dtPompier = MesDatas.DsGlobal.Tables["Pompier"];
            dtEngin = MesDatas.DsGlobal.Tables["Engin"];
            dtNatureSinistre = MesDatas.DsGlobal.Tables["NatureSinistre"];
            dtCaserne = MesDatas.DsGlobal.Tables["Caserne"];
            dtNecessiter = MesDatas.DsGlobal.Tables["Necessiter"];
            dtTypeEngin = MesDatas.DsGlobal.Tables["TypeEngin"];
            dtEmbarquer = MesDatas.DsGlobal.Tables["Embarquer"];
            dtPasser = MesDatas.DsGlobal.Tables["Passer"];
            dtAffectation = MesDatas.DsGlobal.Tables["Affectation"];

            idHabilitation = new int[100];

            InitialiserFormulaire();
        }

        private void InitialiserFormulaire()
        {
            // Vérifier que les tables sont chargées avant de configurer les ComboBox
            if (dtNatureSinistre != null && dtNatureSinistre.Rows.Count > 0)
            {
                cmbNatureSinistre.DataSource = dtNatureSinistre;
                cmbNatureSinistre.DisplayMember = "libelle";
                cmbNatureSinistre.ValueMember = "id";
                cmbNatureSinistre.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Aucune nature de sinistre trouvée dans la base de données.", 
                              "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (dtCaserne != null && dtCaserne.Rows.Count > 0)
            {
                cmbCaserneMobiliser.DataSource = dtCaserne;
                cmbCaserneMobiliser.DisplayMember = "nom";
                cmbCaserneMobiliser.ValueMember = "id";
                cmbCaserneMobiliser.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Aucune caserne trouvée dans la base de données.", 
                              "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Générer le numéro de mission
            numeroMission = ObtenirProchainNumeroMission();
            dateHeure = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            lblNumMission.Text = $"Mission n° {numeroMission}";
            lblDateDebut.Text = $"Mission déclenchée le : {DateTime.Now:dd/MM/yyyy HH:mm}";

            // Masquer la group box des ressources au démarrage
            grpPompiersEngins.Visible = false;
        }

        private int ObtenirProchainNumeroMission()
        {
            if (dtMission == null || dtMission.Rows.Count == 0)
                return 1;

            int maxId = 0;
            foreach (DataRow row in dtMission.Rows)
            {
                if (row["id"] != DBNull.Value)
                {
                    int id = Convert.ToInt32(row["id"]);
                    if (id > maxId)
                        maxId = id;
                }
            }
            return maxId + 1;
        }
        #endregion

        #region Validation des champs
        private void tbMotifMission_KeyPress(object sender, KeyPressEventArgs e) => ValiderSaisieTexte(e);
        private void tbRueSinistre_KeyPress(object sender, KeyPressEventArgs e) => ValiderSaisieTexte(e);
        private void tbVilleSinistre_KeyPress(object sender, KeyPressEventArgs e) => ValiderSaisieTexte(e);
        private void tbCodePostalSinistre_KeyPress(object sender, KeyPressEventArgs e) => ValiderSaisieNumerique(e);

        private static void ValiderSaisieTexte(KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) ||
                e.KeyChar == ' ' || char.IsDigit(e.KeyChar) || e.KeyChar == '\'')
            {
                e.Handled = false;
            }
        }

        private static void ValiderSaisieNumerique(KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }
        #endregion

        #region Gestion des ressources en mode déconnecté
        private void ChargerRessourcesDisponibles()
        {
            if (!ValiderSelections()) return;

            int natureSinistreId = Convert.ToInt32(cmbNatureSinistre.SelectedValue);
            int caserneId = Convert.ToInt32(cmbCaserneMobiliser.SelectedValue);

            // Rechercher les engins nécessaires
            List<(string codeTypeEngin, int nombre, int equipage)> enginsNecessaires = ObtenirEnginsNecessaires(natureSinistreId, caserneId);

            if (enginsNecessaires.Count == 0)
            {
                // Proposer une autre caserne
                int nouvelleCaserne = TrouverCaserneAvecEngins(natureSinistreId);
                if (nouvelleCaserne != -1 && nouvelleCaserne != caserneId)
                {
                    ProposerChangementCaserne(nouvelleCaserne);
                    return;
                }
                else
                {
                    MessageBox.Show("Aucune caserne ne dispose actuellement des engins nécessaires pour ce type de sinistre.");
                    return;
                }
            }

            // Afficher les engins dans le DataGridView
            AfficherEnginsDisponibles(enginsNecessaires, caserneId);

            // Afficher les pompiers disponibles
            AfficherPompiersDisponibles(enginsNecessaires, caserneId);

            grpPompiersEngins.Visible = true;
        }

        private List<(string codeTypeEngin, int nombre, int equipage)> ObtenirEnginsNecessaires(int idNatureSinistre, int idCaserne)
        {
            List<(string, int, int)> enginsNecessaires = new List<(string, int, int)>();

            if (dtNecessiter == null) return enginsNecessaires;

            foreach (DataRow row in dtNecessiter.Select($"idNatureSinistre = {idNatureSinistre}"))
            {
                string codeTypeEngin = row["codeTypeEngin"].ToString();
                int nombreNecessaire = Convert.ToInt32(row["nombre"]);

                // Vérifier la disponibilité dans la caserne
                if (dtEngin != null)
                {
                    DataRow[] enginsDisponibles = dtEngin.Select(
                        $"codeTypeEngin = '{codeTypeEngin}' AND idCaserne = {idCaserne} AND enMission = 0 AND enPanne = 0");

                    if (enginsDisponibles.Length >= nombreNecessaire)
                    {
                        // Récupérer l'équipage nécessaire
                        if (dtTypeEngin != null)
                        {
                            DataRow[] typeEnginRows = dtTypeEngin.Select($"code = '{codeTypeEngin}'");
                            int equipage = typeEnginRows.Length > 0 ? Convert.ToInt32(typeEnginRows[0]["equipage"]) : 1;

                            enginsNecessaires.Add((codeTypeEngin, nombreNecessaire, equipage));
                        }
                    }
                }
            }

            return enginsNecessaires;
        }

        private void AfficherEnginsDisponibles(List<(string codeTypeEngin, int nombre, int equipage)> enginsNecessaires, int idCaserne)
        {
            dgvEngins.Rows.Clear();
            if (dgvEngins.Columns.Count == 0)
            {
                dgvEngins.Columns.Add("codeTypeEngin", "Type d'engin");
                dgvEngins.Columns.Add("nombre", "Quantité");
                dgvEngins.Columns.Add("equipage", "Équipage requis");
                dgvEngins.Columns.Add("numero", "Numéro");
                dgvEngins.Columns.Add("idCaserne", "Caserne");
            }

            if (dtEngin == null) return;

            foreach ((string codeTypeEngin, int nombre, int equipage) in enginsNecessaires)
            {
                DataRow[] enginsDisponibles = dtEngin.Select(
                    $"codeTypeEngin = '{codeTypeEngin}' AND idCaserne = {idCaserne} AND enMission = 0 AND enPanne = 0");

                // Prendre seulement le nombre d'engins nécessaire
                for (int i = 0; i < nombre && i < enginsDisponibles.Length; i++)
                {
                    DataRow engin = enginsDisponibles[i];
                    dgvEngins.Rows.Add(
                        codeTypeEngin,
                        1,
                        equipage,
                        engin["numero"],
                        engin["idCaserne"]
                    );
                }
            }
        }

        private void AfficherPompiersDisponibles(List<(string codeTypeEngin, int nombre, int equipage)> enginsNecessaires, int idCaserne)
        {
            dgvPompier.Rows.Clear();
            if (dgvPompier.Columns.Count == 0)
            {
                dgvPompier.Columns.Add("Matricule", "Matricule");
                dgvPompier.Columns.Add("Nom", "Nom");
                dgvPompier.Columns.Add("Prenom", "Prénom");
                dgvPompier.Columns.Add("PourEngin", "Type Engin");
            }

            if (dtEmbarquer == null || dtPasser == null || dtAffectation == null || dtPompier == null) 
                return;

            int indexHabilitation = 0;
            idHabi = new int[100];

            foreach ((string codeTypeEngin, int nombre, int equipage) in enginsNecessaires)
            {
                // Trouver les habilitations nécessaires pour ce type d'engin
                List<int> habilitationsRequises = dtEmbarquer.Select($"codeTypeEngin = '{codeTypeEngin}'")
                    .Select(row => Convert.ToInt32(row["idHabilitation"]))
                    .Distinct()
                    .ToList();

                List<DataRow> pompiersEligibles = new List<DataRow>();

                foreach (int currentHabilitationId in habilitationsRequises)
                {
                    // Trouver les pompiers ayant cette habilitation
                    DataRow[] passerRows = dtPasser.Select($"idHabilitation = {currentHabilitationId}");

                    foreach (DataRow passerRow in passerRows)
                    {
                        int matricule = Convert.ToInt32(passerRow["matriculePompier"]);

                        // Vérifier que le pompier est affecté à cette caserne
                        DataRow[] affectationRows = dtAffectation.Select($"matriculePompier = {matricule} AND idCaserne = {idCaserne}");
                        if (affectationRows.Length == 0) continue;

                        // Vérifier la disponibilité du pompier
                        DataRow[] pompierRows = dtPompier.Select($"matricule = {matricule}");
                        if (pompierRows.Length == 0) continue;

                        DataRow pompier = pompierRows[0];
                        bool enMission = Convert.ToBoolean(pompier["enMission"]);
                        bool enConge = Convert.ToBoolean(pompier["enConge"]);

                        if (!enMission && !enConge && !pompiersEligibles.Contains(pompier))
                        {
                            pompiersEligibles.Add(pompier);
                            if (indexHabilitation < idHabilitation.Length) 
                            {
                                idHabilitation[indexHabilitation] = currentHabilitationId;
                                indexHabilitation++;
                            }
                        }
                    }
                }

                // Sélectionner le nombre de pompiers nécessaires
                int totalPompiersNecessaires = nombre * equipage;
                List<DataRow> pompiersSelectionnes = pompiersEligibles.Take(totalPompiersNecessaires).ToList();

                // Mettre à jour idHabi avec les bonnes habilitations
                for (int j = 0; j < pompiersSelectionnes.Count && j < idHabi.Length; j++)
                {
                    idHabi[j] = idHabilitation[j];
                }

                // Ajouter les pompiers au DataGridView
                foreach (DataRow pompier in pompiersSelectionnes)
                {
                    dgvPompier.Rows.Add(
                        pompier["matricule"],
                        pompier["nom"],
                        pompier["prenom"],
                        codeTypeEngin
                    );
                }
            }
        }

        private int TrouverCaserneAvecEngins(int idNatureSinistre)
        {
            if (dtCaserne == null) return -1;

            foreach (DataRow caserne in dtCaserne.Rows)
            {
                int idCaserne = Convert.ToInt32(caserne["id"]);
                List<(string, int, int)> engins = ObtenirEnginsNecessaires(idNatureSinistre, idCaserne);
                if (engins.Count > 0)
                    return idCaserne;
            }
            return -1;
        }

        private void ProposerChangementCaserne(int idNouvelleCaserne)
        {
            if (dtCaserne == null) return;

            string nomCaserne = dtCaserne.Select($"id = {idNouvelleCaserne}")[0]["nom"].ToString();

            DialogResult resultat = MessageBox.Show(
                $"Les engins nécessaires ne sont pas disponibles dans la caserne sélectionnée.\n" +
                $"Voulez-vous attribuer la mission à la caserne '{nomCaserne}' qui dispose des ressources nécessaires ?",
                "Changement de caserne",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultat == DialogResult.Yes)
            {
                cmbCaserneMobiliser.SelectedValue = idNouvelleCaserne;
                ChargerRessourcesDisponibles();
            }
        }
        #endregion

        #region Validation et contrôles
        private bool ValiderSelections()
        {
            if (cmbNatureSinistre.SelectedValue == null || cmbCaserneMobiliser.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner une nature de sinistre et une caserne.");
                return false;
            }
            return true;
        }

        private bool ValiderFormulaire()
        {
            if (string.IsNullOrWhiteSpace(tbMotifMission.Text))
                return AfficherErreurValidation("Motif de mission");

            if (string.IsNullOrWhiteSpace(tbRueSinistre.Text))
                return AfficherErreurValidation("Adresse");

            if (string.IsNullOrWhiteSpace(tbCodePostalSinistre.Text))
                return AfficherErreurValidation("Code postal");

            if (string.IsNullOrWhiteSpace(tbVilleSinistre.Text))
                return AfficherErreurValidation("Ville");

            if (cmbNatureSinistre.SelectedValue == null || cmbCaserneMobiliser.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner une nature de sinistre et une caserne.");
                return false;
            }

            if (tbCodePostalSinistre.Text.Length != 5)
            {
                MessageBox.Show("Le code postal doit contenir 5 chiffres.");
                return false;
            }

            return true;
        }

        private static bool AfficherErreurValidation(string nomChamp)
        {
            MessageBox.Show($"Le champ '{nomChamp}' est obligatoire.");
            return false;
        }
        #endregion

        #region Création de mission en mode déconnecté
        private void CreerMissionLocale()
        {
            if (dtMission == null) return;

            // Ajouter la mission au DataSet
            DataRow nouvelleMission = dtMission.NewRow();
            nouvelleMission["id"] = numeroMission;
            nouvelleMission["motifAppel"] = tbMotifMission.Text;
            nouvelleMission["adresse"] = tbRueSinistre.Text;
            nouvelleMission["cp"] = tbCodePostalSinistre.Text;
            nouvelleMission["ville"] = tbVilleSinistre.Text;
            nouvelleMission["dateHeureDepart"] = dateHeure;
            nouvelleMission["idCaserne"] = Convert.ToInt32(cmbCaserneMobiliser.SelectedValue);
            nouvelleMission["idNatureSinistre"] = Convert.ToInt32(cmbNatureSinistre.SelectedValue);
            nouvelleMission["terminee"] = 0;
            dtMission.Rows.Add(nouvelleMission);

            // Marquer les pompiers comme étant en mission et les ajouter à dtMobiliser
            if (dtPompier != null && dtMobiliser != null)
            {
                HashSet<int> matriculesDejaAjoutes = new HashSet<int>();
                int indexHabi = 0;

                foreach (DataGridViewRow row in dgvPompier.Rows)
                {
                    if (row.Cells["Matricule"].Value != null)
                    {
                        int matricule = Convert.ToInt32(row.Cells["Matricule"].Value);

                        if (!matriculesDejaAjoutes.Contains(matricule))
                        {
                            // Marquer le pompier comme étant en mission
                            DataRow[] pompierRows = dtPompier.Select($"matricule = {matricule}");
                            if (pompierRows.Length > 0)
                            {
                                pompierRows[0]["enMission"] = 1;
                            }

                            // Ajouter dans dtMobiliser
                            DataRow nouveauMobiliser = dtMobiliser.NewRow();
                            nouveauMobiliser["matriculePompier"] = matricule;
                            nouveauMobiliser["idMission"] = numeroMission;
                            nouveauMobiliser["idHabilitation"] = idHabi[indexHabi];
                            dtMobiliser.Rows.Add(nouveauMobiliser);

                            matriculesDejaAjoutes.Add(matricule);
                            indexHabi++;
                        }
                    }
                }
            }

            // Marquer les engins comme étant en mission
            if (dtEngin != null)
            {
                foreach (DataGridViewRow row in dgvEngins.Rows)
                {
                    if (row.Cells["numero"].Value != null &&
                        row.Cells["idCaserne"].Value != null &&
                        row.Cells["codeTypeEngin"].Value != null)
                    {
                        string numero = row.Cells["numero"].Value.ToString();
                        string idCaserne = row.Cells["idCaserne"].Value.ToString();
                        string codeTypeEngin = row.Cells["codeTypeEngin"].Value.ToString();

                        DataRow[] enginRows = dtEngin.Select(
                            $"numero = '{numero}' AND idCaserne = '{idCaserne}' AND codeTypeEngin = '{codeTypeEngin}'");

                        foreach (DataRow engin in enginRows)
                        {
                            engin["enMission"] = 1;
                        }
                    }
                }
            }

            MessageBox.Show("Mission créée avec succès !",
                          "Mission créée", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ReinitialiserFormulaire()
        {
            tbMotifMission.Clear();
            tbRueSinistre.Clear();
            tbCodePostalSinistre.Clear();
            tbVilleSinistre.Clear();

            cmbNatureSinistre.SelectedIndex = -1;
            cmbCaserneMobiliser.SelectedIndex = -1;

            dgvEngins.DataSource = null;
            dgvPompier.DataSource = null;
            dgvEngins.Rows.Clear();
            dgvPompier.Rows.Clear();

            grpPompiersEngins.Visible = false;
            missionEnCours = null;

            // Nouveau numéro de mission
            numeroMission = ObtenirProchainNumeroMission();
            dateHeure = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            lblNumMission.Text = $"Mission n° {numeroMission}";
            lblDateDebut.Text = $"Mission déclenchée le : {DateTime.Now:dd/MM/yyyy HH:mm}";
        }
        #endregion

        #region Événements des boutons
        private void bttnValiderInfos_Click(object sender, EventArgs e)
        {
            if (!ValiderFormulaire()) return;
            ChargerRessourcesDisponibles();
        }

        private void bttnEffacerInfos_Click(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show(
                "Êtes-vous sûr de vouloir effacer toutes les informations saisies ?",
                "Confirmation d'effacement",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultat == DialogResult.Yes)
            {
                ReinitialiserFormulaire();
            }
        }

        private void bttnValider_Click(object sender, EventArgs e)
        {
            if (!grpPompiersEngins.Visible)
            {
                MessageBox.Show("Veuillez d'abord valider les informations pour charger les ressources disponibles.");
                return;
            }

            if (dgvEngins.Rows.Count == 0)
            {
                MessageBox.Show("Aucun engin disponible pour cette mission.");
                return;
            }

            CreerMissionLocale();
            ReinitialiserFormulaire();
        }

        private void bttnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show(
                "Êtes-vous sûr de vouloir quitter sans sauvegarder ?",
                "Confirmation de fermeture",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultat == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion
    }
}