using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;

namespace Caserne
{
    public partial class FormParcoursEngins : Form
    {
        public FormParcoursEngins()
        {
            InitializeComponent();
            ChargerCasernes();
        }

        private List<Engin> engins = new List<Engin>();
        private int indexActuel = 0;

        private class Engin
        {
            public string CodeTypeEngin { get; set; }
            public string Numero { get; set; }
            public DateTime DateReception { get; set; }
            public int IdCaserne { get; set; }
            public bool EnMission { get; set; }
            public bool EnPanne { get; set; }
        }

        private void ChargerCasernes()
        {
            try
            {
                // Récupération de la connexion via le Singleton
                SQLiteConnection connection = Connexion.Connec;

                string requete = "SELECT nom FROM Caserne";
                SQLiteCommand command = new SQLiteCommand(requete, connection);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cmbChoixCaserne.Items.Add(reader["nom"].ToString());
                }

                reader.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des casernes : " + ex.Message);
            }
        }

        private void cmbChoixCaserne_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Récupérer le nom de la caserne sélectionnée
            string caserneNom = cmbChoixCaserne.SelectedItem.ToString();
            // Charger les engins associés à cette caserne
            ChargerEnginsParCaserne(caserneNom);
        }

        private void ChargerEnginsParCaserne(string caserneNom)
        {
            try
            {
                engins.Clear();
                indexActuel = 0;

                SQLiteConnection connection = Connexion.Connec;

                string requete = @"
                    SELECT e.codeTypeEngin, e.numero, e.dateReception, e.idCaserne, e.enMission, e.enPanne
                    FROM Engin e
                    INNER JOIN Caserne c ON e.idCaserne = c.id
                    WHERE c.nom = @caserneNom;
                ";

                SQLiteCommand command = new SQLiteCommand(requete, connection);
                command.Parameters.AddWithValue("@caserneNom", caserneNom);

                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    engins.Add(new Engin
                    {
                        CodeTypeEngin = reader["codeTypeEngin"].ToString(),
                        Numero = reader["numero"].ToString(),
                        DateReception = Convert.ToDateTime(reader["dateReception"]),
                        IdCaserne = Convert.ToInt32(reader["idCaserne"]),
                        EnMission = Convert.ToBoolean(reader["enMission"]),
                        EnPanne = Convert.ToBoolean(reader["enPanne"])
                    });

                }

                reader.Close();

                if (engins.Count > 0)
                {
                    AfficherEngin(indexActuel);
                }
                else
                {
                    MessageBox.Show("Aucun engin trouvé pour la caserne spécifiée.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des engins : " + ex.Message);
            }
        }
        private void AfficherEngin(int index)
        {
            if (index >= 0 && index < engins.Count)
            {
                var engin = engins[index];

                lblNumeroEngin.Text = $"Numéro  :  {engin.IdCaserne} - {engin.CodeTypeEngin} - {engin.Numero}";
                lblDateRCP.Text = $"Date de Réception  :  {engin.DateReception:dd/MM/yyyy}";
                cbEnMission.Checked = engin.EnMission;
                cbEnPanne.Checked = engin.EnPanne;

                // Chargement de l'image
                string dossierImages = @"C:\Users\arthu\A21\Images\FormParcoursEngins\ImagesEngins";
                string cheminImage = Path.Combine(dossierImages, engin.CodeTypeEngin + ".png");

                if (pbEngin.Image != null)
                {
                    pbEngin.Image.Dispose();
                    pbEngin.Image = null;
                }

                if (File.Exists(cheminImage))
                {
                    pbEngin.Image = Image.FromFile(cheminImage);
                }
                else
                {
                    // Image par défaut
                    string defaultPath = Path.Combine(dossierImages, "default.png");
                    if (File.Exists(defaultPath))
                    {
                        pbEngin.Image = Image.FromFile(defaultPath);
                    }
                }
            }
        }



        private void bttnPrecedent_Click(object sender, EventArgs e)
        {
            if (indexActuel > 0)
            {
                indexActuel--;
                AfficherEngin(indexActuel);
            }
        }

        private void bttnSuivant_Click(object sender, EventArgs e)
        {
            if (indexActuel < engins.Count - 1)
            {
                indexActuel++;
                AfficherEngin(indexActuel);
            }
        }
    }
}
