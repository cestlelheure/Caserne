using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Caserne
{
    public partial class FormParcoursEngins : Form
    {
        #region Variables privées
        private BindingSource bindingSourceEngins = new BindingSource();
        private const string OPTION_DEFAUT_CASERNE = "-- Veuillez sélectionner une caserne --";
        private const string DOSSIER_IMAGES = "Images\\FormParcoursEngins\\ImagesEngins";
        private const string IMAGE_DEFAUT = "default.png";
        #endregion

        #region Constructeur
        public FormParcoursEngins()
        {
            InitializeComponent();
            InitialiserFormulaire();
        }
        #endregion

        #region Classe interne
        private class Engin
        {
            public string CodeTypeEngin { get; set; }
            public string Numero { get; set; }
            public DateTime DateReception { get; set; }
            public int IdCaserne { get; set; }
            public bool EnMission { get; set; }
            public bool EnPanne { get; set; }
        }
        #endregion

        #region Initialisation
        private void InitialiserFormulaire()
        {
            // Configurer les événements du BindingSource
            bindingSourceEngins.CurrentChanged += BindingSourceEngins_CurrentChanged;

            // État initial de l'interface
            MasquerPanneauInfos();
            MasquerBoutonsNavigation();

            // Charger les données initiales
            ChargerCasernes();
        }

        private void MasquerPanneauInfos()
        {
            pnlInfosEngins.Visible = false;
        }

        private void MasquerBoutonsNavigation()
        {
            bttnDebut.Visible = false;
            bttnPrecedent.Visible = false;
            bttnSuivant.Visible = false;
            bttnFin.Visible = false;
        }

        private void AfficherBoutonsNavigation()
        {
            bttnDebut.Visible = true;
            bttnPrecedent.Visible = true;
            bttnSuivant.Visible = true;
            bttnFin.Visible = true;
        }
        #endregion

        #region Méthodes utilitaires réutilisables
        private void RemplirComboBox(ComboBox comboBox, string requete, string champAffichage, string optionDefaut = null)
        {
            try
            {
                comboBox.Items.Clear();

                if (!string.IsNullOrEmpty(optionDefaut))
                {
                    comboBox.Items.Add(optionDefaut);
                }

                using (SQLiteCommand command = new SQLiteCommand(requete, Connexion.Connec))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader[champAffichage].ToString());
                    }
                }

                if (comboBox.Items.Count > 0)
                {
                    comboBox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                AfficherErreur($"Erreur lors du remplissage de la ComboBox : {ex.Message}");
            }
        }

        private void AfficherErreur(string message)
        {
            MessageBox.Show(message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AfficherInfo(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LibererImagePictureBox(PictureBox pictureBox)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
                pictureBox.Image = null;
            }
        }

        private void ChargerImageEngin(PictureBox pictureBox, string nomImage)
        {
            LibererImagePictureBox(pictureBox);

            string dossierImages = Path.Combine(Application.StartupPath, DOSSIER_IMAGES);
            string cheminImage = Path.Combine(dossierImages, $"{nomImage}.png");

            if (File.Exists(cheminImage))
            {
                pictureBox.Image = Image.FromFile(cheminImage);
            }
            else
            {
                string cheminImageDefaut = Path.Combine(dossierImages, IMAGE_DEFAUT);
                if (File.Exists(cheminImageDefaut))
                {
                    pictureBox.Image = Image.FromFile(cheminImageDefaut);
                }
            }
        }
        #endregion

        #region Chargement des données
        private void ChargerCasernes()
        {
            string requete = "SELECT nom FROM Caserne ORDER BY nom";
            RemplirComboBox(cmbChoixCaserne, requete, "nom", OPTION_DEFAUT_CASERNE);
        }

        private void ChargerEnginsParCaserne(string caserneNom)
        {
            try
            {
                List<Engin> engins = RecupererEnginsParCaserne(caserneNom);

                bindingSourceEngins.DataSource = engins;

                if (engins.Count > 0)
                {
                    bindingSourceEngins.Position = 0;
                    AfficherBoutonsNavigation();
                }
                else
                {
                    AfficherInfo("Aucun engin trouvé pour la caserne spécifiée.");
                    ViderAffichage();
                    MasquerBoutonsNavigation();
                }
            }
            catch (Exception ex)
            {
                AfficherErreur($"Erreur lors de la récupération des engins : {ex.Message}");
            }
        }

        private List<Engin> RecupererEnginsParCaserne(string caserneNom)
        {
            List<Engin> engins = new List<Engin>();

            string requete = @"
                SELECT e.codeTypeEngin, e.numero, e.dateReception, e.idCaserne, e.enMission, e.enPanne
                FROM Engin e
                INNER JOIN Caserne c ON e.idCaserne = c.id
                WHERE c.nom = @caserneNom
                ORDER BY e.codeTypeEngin, e.numero;
            ";

            using (SQLiteCommand command = new SQLiteCommand(requete, Connexion.Connec))
            {
                command.Parameters.AddWithValue("@caserneNom", caserneNom);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        engins.Add(CreerEnginDepuisReader(reader));
                    }
                }
            }

            return engins;
        }

        private Engin CreerEnginDepuisReader(SQLiteDataReader reader)
        {
            return new Engin
            {
                CodeTypeEngin = reader["codeTypeEngin"].ToString(),
                Numero = reader["numero"].ToString(),
                DateReception = Convert.ToDateTime(reader["dateReception"]),
                IdCaserne = Convert.ToInt32(reader["idCaserne"]),
                EnMission = Convert.ToBoolean(reader["enMission"]),
                EnPanne = Convert.ToBoolean(reader["enPanne"])
            };
        }
        #endregion

        #region Affichage
        private void ViderAffichage()
        {
            lblNumeroEngin.Text = "Numéro  :  ";
            lblDateRCP.Text = "Date de Réception  :  ";
            lblDisponible.Text = "Disponibilité  :  ";
            lblEnPanne.Text = "État  :  ";
            LibererImagePictureBox(pbEngin);
        }

        private void AfficherEnginCourant()
        {
            if (bindingSourceEngins.Current is Engin engin)
            {
                lblNumeroEngin.Text = $"Numéro  :  {engin.IdCaserne} - {engin.CodeTypeEngin} - {engin.Numero}";
                lblDateRCP.Text = $"Date de Réception  :  {engin.DateReception:dd/MM/yyyy}";
                lblDisponible.Text = $"Disponibilité  :  {(engin.EnMission ? "Disponibilité" : "Disponible")}";
                lblEnPanne.Text = $"État  :  {(engin.EnPanne ? "En panne" : "Opérationnel")}";

                ChargerImageEngin(pbEngin, engin.CodeTypeEngin);
            }
        }
        #endregion

        #region Navigation
        private void NaviguerVers(int position)
        {
            if (bindingSourceEngins.Count > 0)
            {
                bindingSourceEngins.Position = position;
            }
        }

        private void NaviguerCirculaire(bool versSuivant)
        {
            if (bindingSourceEngins.Count == 0) return;

            if (versSuivant)
            {
                int nouvellePosition = (bindingSourceEngins.Position + 1) % bindingSourceEngins.Count;
                bindingSourceEngins.Position = nouvellePosition;
            }
            else
            {
                int nouvellePosition = bindingSourceEngins.Position - 1;
                if (nouvellePosition < 0)
                    nouvellePosition = bindingSourceEngins.Count - 1;
                bindingSourceEngins.Position = nouvellePosition;
            }
        }
        #endregion

        #region Gestionnaires d'événements
        private void BindingSourceEngins_CurrentChanged(object sender, EventArgs e)
        {
            AfficherEnginCourant();
        }

        private void bttnDebut_Click(object sender, EventArgs e)
        {
            NaviguerVers(0);
        }

        private void bttnPrecedent_Click(object sender, EventArgs e)
        {
            NaviguerCirculaire(false);
        }

        private void bttnSuivant_Click(object sender, EventArgs e)
        {
            NaviguerCirculaire(true);
        }

        private void bttnFin_Click(object sender, EventArgs e)
        {
            NaviguerVers(bindingSourceEngins.Count - 1);
        }

        private void cmbChoixCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            string caserneNom = cmbChoixCaserne.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(caserneNom) || caserneNom == OPTION_DEFAUT_CASERNE)
            {
                MasquerPanneauInfos();
                bindingSourceEngins.DataSource = null;
                ViderAffichage();
                MasquerBoutonsNavigation();
            }
            else
            {
                pnlInfosEngins.Visible = true;
                ChargerEnginsParCaserne(caserneNom);
            }
        }
        #endregion

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