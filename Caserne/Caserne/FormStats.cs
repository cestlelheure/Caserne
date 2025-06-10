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
using Org.BouncyCastle.Asn1.Ocsp;

namespace Caserne
{
    public partial class FormStats : Form
    {
        private SQLiteConnection connection;

        public FormStats()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadCasernes();
            LoadGlobalStats();
        }

        private void InitializeDatabase()
        {
            connection = Connexion.Connec;
        }

        private void LoadCasernes()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                string query = "SELECT id, nom FROM Caserne ORDER BY nom";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        cboChoixCaserne.DisplayMember = "nom";
                        cboChoixCaserne.ValueMember = "id";
                        cboChoixCaserne.DataSource = dt;
                    }
                }

                // Événement pour charger les stats de la caserne sélectionnée
                cboChoixCaserne.SelectedIndexChanged += CboChoixCaserne_SelectedIndexChanged;

                // Charger les stats de la première caserne
                if (cboChoixCaserne.Items.Count > 0)
                {
                    LoadCaserneStats();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des casernes : {ex.Message}");
            }
        }

        private void CboChoixCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCaserneStats();
        }

        private void LoadCaserneStats()
        {
            if (cboChoixCaserne.SelectedValue == null) return;

            int caserneId = Convert.ToInt32(cboChoixCaserne.SelectedValue);

            LoadEnginsUtilises(caserneId);
            LoadHeuresUtilisation(caserneId);
        }

        private void LoadEnginsUtilises(int caserneId)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                string query = @"
                        SELECT 
                            e.numero,
                            te.nom AS type_engin,
                            COUNT(pa.idMission) AS nombre_missions
                        FROM Engin e
                        JOIN TypeEngin te ON e.codeTypeEngin = te.code
                        JOIN PartirAvec pa ON e.idCaserne = pa.idCaserne 
                            AND e.codeTypeEngin = pa.codeTypeEngin 
                            AND e.numero = pa.numeroEngin
                        WHERE e.idCaserne = @caserneId
                        GROUP BY e.numero, te.nom, e.idCaserne, e.codeTypeEngin
                        HAVING COUNT(pa.idMission) > 0
                        ORDER BY nombre_missions DESC
                        LIMIT 5";


                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@caserneId", caserneId);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("Engins les plus utilisés :");

                        int rank = 1;
                        while (reader.Read() && rank <= 5)
                        {
                            sb.AppendLine($"\n{rank}. {reader["type_engin"]} n°{reader["numero"]} " +
                                        $"({reader["nombre_missions"]} missions)");
                            rank++;
                        }

                        if (rank == 1)
                        {
                            sb.AppendLine("Aucune donnée disponible");
                        }

                        lblEnginsPlusUtilise.Text = sb.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                lblEnginsPlusUtilise.Text = $"Erreur : {ex.Message}";
            }
        }

        private void LoadHeuresUtilisation(int caserneId)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                string query = @"
                    SELECT 
                        e.numero,
                        te.nom AS type_engin,
                        COALESCE(SUM(
                            CASE 
                                WHEN m.dateHeureRetour IS NOT NULL AND m.dateHeureDepart IS NOT NULL
                                THEN (julianday(m.dateHeureRetour) - julianday(m.dateHeureDepart)) * 24
                                ELSE 0
                            END
                        ), 0) AS heures_utilisation_cumul
                    FROM Engin e
                    JOIN TypeEngin te ON e.codeTypeEngin = te.code
                    LEFT JOIN PartirAvec pa ON e.idCaserne = pa.idCaserne 
                        AND e.codeTypeEngin = pa.codeTypeEngin 
                        AND e.numero = pa.numeroEngin
                    LEFT JOIN Mission m ON pa.idMission = m.id
                    WHERE e.idCaserne = @caserneId              
                    GROUP BY e.numero, te.nom, e.idCaserne, e.codeTypeEngin
                    HAVING heures_utilisation_cumul > 0
                    ORDER BY heures_utilisation_cumul DESC";

                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@caserneId", caserneId);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("Total d'heures d'utilisation pour chaque engin :");

                        while (reader.Read())
                        {
                            double heures = Convert.ToDouble(reader["heures_utilisation_cumul"]);
                            sb.AppendLine($"\n• {reader["type_engin"]} n°{reader["numero"]} : " +
                                        $"{heures:F1}h");
                        }

                        lblHeuresUtilisations.Text = sb.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                lblHeuresUtilisations.Text = $"Erreur : {ex.Message}";
            }
        }

        private void LoadGlobalStats()
        {
            LoadInterventionsParSinistre();
            LoadHabilitationsSollicitees();
            LoadPompiersParHabilitation();
        }

        private void LoadInterventionsParSinistre()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                string query = @"
                    SELECT 
                        ns.libelle AS type_sinistre,
                        COUNT(m.id) AS nombre_interventions
                    FROM NatureSinistre ns
                    LEFT JOIN Mission m ON ns.id = m.idNatureSinistre
                    GROUP BY ns.id, ns.libelle
                    ORDER BY nombre_interventions DESC";

                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("Nombre d'interventions par type de sinistre :");

                        while (reader.Read())
                        {
                            sb.AppendLine($"\n• {reader["type_sinistre"]} : {reader["nombre_interventions"]}");
                        }

                        lblNbInterventionParSinistre.Text = sb.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                lblNbInterventionParSinistre.Text = $"Erreur : {ex.Message}";
            }
        }

        private void LoadHabilitationsSollicitees()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                string query = @"
                    SELECT 
                        h.libelle AS habilitation,
                        COUNT(mob.idMission) AS nombre_sollicitations
                    FROM Habilitation h
                    LEFT JOIN Mobiliser mob ON h.id = mob.idHabilitation
                    GROUP BY h.id, h.libelle
                    ORDER BY nombre_sollicitations DESC
                    LIMIT 10";

                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("Habilitations les plus sollicitées :");

                        while (reader.Read())
                        {
                            sb.AppendLine($"\n• {reader["habilitation"]} : {reader["nombre_sollicitations"]} fois");
                        }

                        lblHabiPlusSolicite.Text = sb.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                lblHabiPlusSolicite.Text = $"Erreur : {ex.Message}";
            }
        }

        private void LoadPompiersParHabilitation()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                string query = @"
                    SELECT 
                        h.libelle AS habilitation,
                        COUNT(DISTINCT p.matricule) AS nombre_pompiers
                    FROM Habilitation h
                    LEFT JOIN Passer pas ON h.id = pas.idHabilitation
                    LEFT JOIN Pompier p ON pas.matriculePompier = p.matricule
                    GROUP BY h.id, h.libelle
                    ORDER BY h.libelle";

                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("Liste des pompiers par habilitation : \n");

                        while (reader.Read())
                        {
                            int nbPompiers = Convert.ToInt32(reader["nombre_pompiers"]);
                            sb.AppendLine($"• {reader["habilitation"]} : {nbPompiers} pompier(s)");
                        }

                        // Ajouter les pompiers sans habilitation
                        LoadPompiersSansHabilitation(sb);

                        lblListePompierPArHabilitation.Text = sb.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                lblListePompierPArHabilitation.Text = $"Erreur : {ex.Message}";
            }
        }

        private void LoadPompiersSansHabilitation(StringBuilder sb)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                string query = @"
                    SELECT COUNT(DISTINCT p.matricule) as nb_sans_habilitation
                    FROM Pompier p
                    LEFT JOIN Passer pas ON p.matricule = pas.matriculePompier
                    WHERE pas.matriculePompier IS NULL";

                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    object result = cmd.ExecuteScalar();
                    int nbSansHabilitation = Convert.ToInt32(result);

                    if (nbSansHabilitation > 0)
                    {
                        sb.AppendLine($"• AUCUNE HABILITATION : {nbSansHabilitation} pompier(s)");
                    }
                }
            }
            catch (Exception ex)
            {
                sb.AppendLine($"Erreur lors du chargement des pompiers sans habilitation : {ex.Message}");
            }
        }

        // Méthode pour rafraîchir toutes les statistiques
        public void RefreshStats()
        {
            LoadCasernes();
            LoadGlobalStats();
        }

        private void bttnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show(
            "Êtes-vous sûr de vouloir quitter ?",
            "Confirmation de fermeture",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (resultat == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}