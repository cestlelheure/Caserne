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
                UcMission uc = new UcMission
                {
                    IdMission = row["Id"].ToString(),
                    DateMission = Convert.ToDateTime(row["DateHeureDepart"]).ToString("dd/MM/yyyy HH:mm"),
                    Caserne = row["Nom"].ToString(),
                    Description = row["MotifAppel"].ToString(),
                    NatureSinistre = row["Libelle"].ToString(),
                    Width = flowMissions.ClientSize.Width - 25
                };

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
    }
}
