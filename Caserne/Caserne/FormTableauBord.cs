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
    public partial class FrmTableauBord : Form
    {
        SQLiteConnection connec = new SQLiteConnection();
        string chcon = @"Data Source=SDIS67.db";
        DataSet ds = new DataSet();

        public FrmTableauBord()
        {
            InitializeComponent();
        }

        private void FrmTableauBord_Load(object sender, EventArgs e)
        {
            try
            {
                chkEnCours_CheckedChanged(null, null);

                connec.ConnectionString = chcon;
                connec.Open();

                ChargerMissions();

                if (ds.Tables.Contains("Mission"))
                {
                    AfficherMissions(ds.Tables["Mission"]);
                }
                else
                {
                    MessageBox.Show("La table 'Mission' n'existe pas dans le DataSet.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                connec.Close();
            }
        }

        private void ChargerMissions(bool enCours = false)
        {
            string sql = @"
        SELECT 
            m.Id, 
            m.DateHeureDepart, 
            m.MotifAppel, 
            c.Nom,
            s.Libelle
        FROM 
            Mission m
        JOIN Caserne c ON m.IdCaserne = c.Id
        JOIN NatureSinistre s ON m.IdNatureSinistre = s.Id";

            if (enCours)
            {
                sql += " WHERE m.DateHeureRetour IS NULL";
            }

            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, connec);
            ds.Tables.Clear(); // Réinitialise le DataSet
            da.Fill(ds, "Mission");
        }


        private void AfficherMissions(DataTable dtMissions)
        {
            flowMissions.Controls.Clear();

            foreach (DataRow row in dtMissions.Rows)
            {
                // Vérifiez cette partie dans votre méthode AfficherMissions
                UcMission uc = new UcMission
                {
                    IdMission = row["Id"].ToString(),
                    DateMission = Convert.ToDateTime(row["DateHeureDepart"]).ToString("dd/MM/yyyy HH:mm"),
                    Caserne = row["Nom"].ToString(),
                    Description = row["MotifAppel"].ToString(),
                    NatureSinistre = row["Libelle"].ToString(),
                    Width = flowMissions.ClientSize.Width - 25
                };

                // IMPORTANT: Assurez-vous que cette ligne assigne correctement l'ID brut et non pas le texte formaté
                uc.BtnTerminer.Tag = row["Id"]; // Utilisez directement la valeur de la colonne Id

                // Vous pourriez aussi vérifier la valeur du Tag avec un débogage ici:
                // Console.WriteLine($"ID assigné au Tag: {uc.BtnTerminer.Tag}");

                uc.BtnTerminer.Click += TerminerMission;

                flowMissions.Controls.Add(uc);
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Êtes-vous sûr de vouloir quitter l'application ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chkEnCours_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                connec.ConnectionString = chcon;
                connec.Open();

                // Filtrer selon l'état de la checkbox
                ChargerMissions(chkEnCours.Checked);

                if (ds.Tables.Contains("Mission"))
                {
                    AfficherMissions(ds.Tables["Mission"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                connec.Close();
            }
        }

        private void TerminerMission(object sender, EventArgs e)
        {
            try
            {
                // Récupérer l'ID de la mission depuis le Tag du bouton
                Button btnTerminer = sender as Button;
                string idMission = btnTerminer.Tag.ToString();

                // Afficher l'ID pour débogage
                Console.WriteLine($"ID Mission à terminer: {idMission}");

                // Message de confirmation
                DialogResult result = MessageBox.Show(
                    $"Êtes-vous sûr de vouloir terminer la mission ID: {idMission} ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    // Ouvrir la connexion
                    connec.ConnectionString = chcon;
                    connec.Open();

                    // Vérifier si l'ID existe dans la base de données
                    string checkSql = "SELECT COUNT(*) FROM Mission WHERE Id = @Id";
                    SQLiteCommand checkCmd = new SQLiteCommand(checkSql, connec);
                    checkCmd.Parameters.AddWithValue("@Id", idMission);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count == 0)
                    {
                        MessageBox.Show($"Aucune mission trouvée avec l'ID: {idMission}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Vérifier si la mission n'est pas déjà terminée
                    string checkRetourSql = "SELECT DateHeureRetour FROM Mission WHERE Id = @Id";
                    SQLiteCommand checkRetourCmd = new SQLiteCommand(checkRetourSql, connec);
                    checkRetourCmd.Parameters.AddWithValue("@Id", idMission);
                    object dateRetour = checkRetourCmd.ExecuteScalar();

                    if (dateRetour != DBNull.Value && dateRetour != null)
                    {
                        MessageBox.Show("Cette mission est déjà terminée.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Préparer la commande SQL pour mettre à jour la date de retour
                    string sql = "UPDATE Mission SET DateHeureRetour = @DateHeureRetour WHERE Id = @Id";
                    SQLiteCommand cmd = new SQLiteCommand(sql, connec);

                    // Paramètres
                    cmd.Parameters.AddWithValue("@DateHeureRetour", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Id", idMission);

                    // Exécuter la requête
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Mission terminée avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recharger les missions pour mettre à jour l'affichage
                        ChargerMissions(chkEnCours.Checked);
                        if (ds.Tables.Contains("Mission"))
                        {
                            AfficherMissions(ds.Tables["Mission"]);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Aucune mission n'a été mise à jour pour l'ID: {idMission}.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la terminaison de la mission : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Fermer la connexion
                if (connec.State == ConnectionState.Open)
                {
                    connec.Close();
                }
            }
        }

        private void btnStats_Click(object sender, EventArgs e)
        {

        }


        private void btnEngins_Click(object sender, EventArgs e)
        {
            try
            {
                // Créer une instance du formulaire FormParcoursEngins
                FormParcoursEngins formEngins = new FormParcoursEngins();

                // Afficher le formulaire
                formEngins.Show();

                // Alternative: Si vous voulez que le formulaire principal attende la fermeture du formulaire des engins
                // formEngins.ShowDialog(this);

                // Note: Utilisez Show() au lieu de ShowDialog() si vous voulez permettre à l'utilisateur
                // d'interagir avec le formulaire principal pendant que FormParcoursEngins est ouvert
                // formEngins.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ouverture du formulaire des engins : " + ex.Message,
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
