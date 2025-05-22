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
        // Ajout du BindingSource pour la liaison de données
        private BindingSource bindingSourceEngins = new BindingSource();

        public FormParcoursEngins()
        {
            InitializeComponent();

            // Configurer les événements du BindingSource
            bindingSourceEngins.CurrentChanged += BindingSourceEngins_CurrentChanged;

            // Masquer le panneau d'informations au démarrage
            pnlInfosEngins.Visible = false;

            // Masquer les boutons de navigation au démarrage
            bttnPrecedent.Visible = false;
            bttnSuivant.Visible = false;

            ChargerCasernes();
        }

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
                // Ajouter l'option par défaut
                cmbChoixCaserne.Items.Add("-- Veuillez sélectionner une caserne --");

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

                // Sélectionner l'option par défaut
                cmbChoixCaserne.SelectedIndex = 0;

                // Masquer le panneau des infos au démarrage
                pnlInfosEngins.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des casernes : " + ex.Message);
            }
        }

        private void ChargerEnginsParCaserne(string caserneNom)
        {
            try
            {
                List<Engin> engins = new List<Engin>();

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

                // Associer la liste d'engins au BindingSource
                bindingSourceEngins.DataSource = engins;

                // Remettre l'index à zéro
                if (engins.Count > 0)
                {
                    bindingSourceEngins.Position = 0;
                }

                if (engins.Count > 0)
                {
                    // Le CurrentChanged event du BindingSource va déclencher l'affichage
                    MettreAJourBoutonsNavigation();
                }
                else
                {
                    MessageBox.Show("Aucun engin trouvé pour la caserne spécifiée.");
                    // Vider l'affichage
                    ViderAffichage();
                    // Masquer les boutons de navigation
                    bttnPrecedent.Visible = false;
                    bttnSuivant.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des engins : " + ex.Message);
            }
        }

        private void ViderAffichage()
        {
            lblNumeroEngin.Text = "Numéro  :  ";
            lblDateRCP.Text = "Date de Réception  :  ";
            cbEnMission.Checked = false;
            cbEnPanne.Checked = false;

            if (pbEngin.Image != null)
            {
                pbEngin.Image.Dispose();
                pbEngin.Image = null;
            }
        }

        // Gestionnaire d'événement pour le changement d'élément courant dans le BindingSource
        private void BindingSourceEngins_CurrentChanged(object sender, EventArgs e)
        {
            AfficherEnginCourant();
            MettreAJourBoutonsNavigation();
        }

        // Nouvelle méthode pour mettre à jour la visibilité des boutons de navigation
        private void MettreAJourBoutonsNavigation()
        {
            if (bindingSourceEngins.Count > 0)
            {
                // Bouton Précédent visible seulement si on n'est pas au premier élément
                bttnPrecedent.Visible = (bindingSourceEngins.Position > 0);

                // Bouton Suivant visible seulement si on n'est pas au dernier élément
                bttnSuivant.Visible = (bindingSourceEngins.Position < bindingSourceEngins.Count - 1);
            }
            else
            {
                // Aucun engin à afficher, masquer les deux boutons
                bttnPrecedent.Visible = false;
                bttnSuivant.Visible = false;
            }
        }

        private void AfficherEnginCourant()
        {
            if (bindingSourceEngins.Current != null)
            {
                var engin = (Engin)bindingSourceEngins.Current;

                lblNumeroEngin.Text = $"Numéro  :  {engin.IdCaserne} - {engin.CodeTypeEngin} - {engin.Numero}";
                lblDateRCP.Text = $"Date de Réception  :  {engin.DateReception:dd/MM/yyyy}";
                cbEnMission.Checked = engin.EnMission;
                cbEnPanne.Checked = engin.EnPanne;

                // Chargement de l'image

                string dossierImages = Path.Combine(Application.StartupPath, "Images", "FormParcoursEngins", "ImagesEngins");
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
            // Utilisation du BindingSource pour la navigation
            bindingSourceEngins.MovePrevious();
        }

        private void bttnSuivant_Click(object sender, EventArgs e)
        {
            // Utilisation du BindingSource pour la navigation
            bindingSourceEngins.MoveNext();
        }

        private void cmbChoixCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Récupérer le nom de la caserne sélectionnée
            string caserneNom = cmbChoixCaserne.SelectedItem.ToString();

            // Vérifier si c'est l'option par défaut
            if (caserneNom == "-- Veuillez sélectionner une caserne --")
            {
                // Masquer le panneau d'informations
                pnlInfosEngins.Visible = false;

                // Vider le BindingSource
                bindingSourceEngins.DataSource = null;

                // Vider l'affichage
                ViderAffichage();

                // Masquer les boutons de navigation
                bttnPrecedent.Visible = false;
                bttnSuivant.Visible = false;
            }
            else
            {
                // Afficher le panneau d'informations
                pnlInfosEngins.Visible = true;

                // Charger les engins associés à cette caserne
                ChargerEnginsParCaserne(caserneNom);
            }
        }
    }
}