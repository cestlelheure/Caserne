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

        private void ChargerMissions()
        {
            string sql = @"
                SELECT 
                    m.Id, 
                    m.DateHeureDepart, 
                    m.MotifAppel, 
                    c.Nom
                FROM 
                    Mission m
                JOIN 
                    Caserne c ON m.Id = c.Id"; // ⚠️ vérifie le vrai nom de ta clé étrangère ici

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
                    Width = flowMissions.ClientSize.Width - 25 // Évite d'être coupé
                };

                flowMissions.Controls.Add(uc);
            }
        }
    }
}
