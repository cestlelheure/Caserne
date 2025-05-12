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

namespace Caserne
{
    public partial class FormParcoursEngins : Form
    {
        public FormParcoursEngins()
        {
            InitializeComponent();
            ChargerCasernes();
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
                // Récupérer la connexion
                SQLiteConnection connection = Connexion.Connec;

                // Préparer la requête SQL avec une jointure entre Engin et Caserne
                string requete = @"
                    SELECT e.codeTypeEngin, e.numero, e.dateReception, e.idCaserne
                    FROM Engin e
                    INNER JOIN Caserne c ON e.idCaserne = c.id
                    WHERE c.nom = @caserneNom;
                ";

                SQLiteCommand command = new SQLiteCommand(requete, connection);
                command.Parameters.AddWithValue("@caserneNom", caserneNom);  // Remplacer avec le nom de la caserne sélectionnée

                SQLiteDataReader reader = command.ExecuteReader();

                // S'assurer que la GroupBox contient déjà des Label pour afficher les données
                if (reader.HasRows)
                {
                    // Récupérer les premières données et les afficher dans les Labels
                    reader.Read();  // Lire la première ligne de résultat

                    // Mettre à jour les labels existants avec les données de la base
                    lblNumero.Text = reader["idCaserne"].ToString() + 
                        " - " +
                        reader["codeTypeEngin"].ToString() +
                        " - " +
                        reader["numero"].ToString();
                    lblDate.Text = "Date de Réception: " + Convert.ToDateTime(reader["dateReception"]).ToString("dd/MM/yyyy");
                }
                else
                {
                    // Si aucune donnée n'est trouvée
                    MessageBox.Show("Aucun engin trouvé pour la caserne spécifiée.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des engins : " + ex.Message);
            }
        }
    }
}
