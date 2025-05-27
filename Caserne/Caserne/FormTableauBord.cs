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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Caserne
{
    public partial class FrmTableauBord : Form
    {
        public FrmTableauBord()
        {
            InitializeComponent();
        }

        private void FrmTableauBord_Load(object sender, EventArgs e)
        {
            try
            {
                chkEnCours_CheckedChanged(null, null);

                ChargerMissions();

                if (MesDatas.DsGlobal.Tables.Contains("Mission"))
                {
                    AfficherMissions(MesDatas.DsGlobal.Tables["Mission"]);
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
        }

        private void ChargerMissions(bool enCours = false)
        {
            try
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

                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, Connexion.Connec);

                // Supprimer la table Mission existante si elle existe
                if (MesDatas.DsGlobal.Tables.Contains("Mission"))
                {
                    MesDatas.DsGlobal.Tables.Remove("Mission");
                }

                da.Fill(MesDatas.DsGlobal, "Mission");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des missions : " + ex.Message);
            }
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

                // Assigner l'ID de la mission au Tag du bouton
                uc.BtnTerminer.Tag = row["Id"];
                uc.BtnPDF.Tag = row["Id"];

                // Attacher l'événement Click
                uc.BtnTerminer.Click += TerminerMission;
                uc.BtnPDF.Click += CreationPDF;

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
                // Fermer proprement la connexion avant de quitter
                Connexion.FermerConnexion();
                Application.Exit();
            }
        }

        private void chkEnCours_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // Filtrer selon l'état de la checkbox
                ChargerMissions(chkEnCours.Checked);

                if (MesDatas.DsGlobal.Tables.Contains("Mission"))
                {
                    AfficherMissions(MesDatas.DsGlobal.Tables["Mission"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void CreationPDF(object sender, EventArgs e)
        {
            try
            {
                // Récupérer l'ID de la mission depuis le Tag du bouton
                Button btnPDF = sender as Button;
                string idMission = btnPDF.Tag.ToString();

                // Afficher l'ID pour débogage
                Console.WriteLine($"ID Mission pour PDF: {idMission}");

                // Récupérer toutes les données de la mission depuis la base de données
                string sql = @"
            SELECT 
                m.id,
                m.dateHeureDepart,
                m.dateHeureRetour,
                m.motifAppel,
                m.adresse,
                m.cp,
                m.ville,
                m.compteRendu,
                c.nom as NomCaserne,
                s.libelle as NatureSinistre
            FROM 
                Mission m
            JOIN Caserne c ON m.idCaserne = c.id
            JOIN NatureSinistre s ON m.idNatureSinistre = s.id
            WHERE m.id = @Id";

                SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);
                cmd.Parameters.AddWithValue("@Id", idMission);

                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Extraire les données de la mission
                    string nomCaserne = reader["NomCaserne"].ToString();
                    string natureSinistre = reader["NatureSinistre"].ToString();
                    string motifAppel = reader["motifAppel"].ToString();
                    string adresse = reader["adresse"].ToString();
                    string cp = reader["cp"].ToString();
                    string ville = reader["ville"].ToString();
                    string compteRendu = reader["compteRendu"].ToString();
                    DateTime dateDepart = Convert.ToDateTime(reader["dateHeureDepart"]);

                    DateTime? dateRetour = null;
                    if (reader["dateHeureRetour"] != DBNull.Value)
                    {
                        dateRetour = Convert.ToDateTime(reader["dateHeureRetour"]);
                    }

                    reader.Close();

                    // Récupérer les pompiers affectés à cette mission
                    string sqlPompiers = @"
                SELECT p.matricule, p.nom, p.prenom, g.libelle as grade
                FROM Mobiliser mo
                JOIN Pompier p ON mo.matriculePompier = p.matricule
                JOIN Grade g ON p.codeGrade = g.code
                WHERE mo.idMission = @Id";

                    SQLiteCommand cmdPompiers = new SQLiteCommand(sqlPompiers, Connexion.Connec);
                    cmdPompiers.Parameters.AddWithValue("@Id", idMission);
                    SQLiteDataReader readerPompiers = cmdPompiers.ExecuteReader();

                    List<string> listePompiers = new List<string>();
                    while (readerPompiers.Read())
                    {
                        string pompier = $"{readerPompiers["nom"]} {readerPompiers["prenom"]} ({readerPompiers["grade"]})";
                        listePompiers.Add(pompier);
                    }
                    readerPompiers.Close();

                    // Récupérer les engins utilisés pour cette mission
                    string sqlEngins = @"
                SELECT e.numero, te.nom as typeEngin
                FROM PartirAvec pa
                JOIN Engin e ON pa.numeroEngin = e.numero
                JOIN TypeEngin te ON e.codeTypeEngin = te.code
                WHERE pa.idMission = @Id";

                    SQLiteCommand cmdEngins = new SQLiteCommand(sqlEngins, Connexion.Connec);
                    cmdEngins.Parameters.AddWithValue("@Id", idMission);
                    SQLiteDataReader readerEngins = cmdEngins.ExecuteReader();

                    List<string> listeEngins = new List<string>();
                    while (readerEngins.Read())
                    {
                        string engin = $"{readerEngins["typeEngin"]} - {readerEngins["numero"]}";
                        listeEngins.Add(engin);
                    }
                    readerEngins.Close();

                    // Construire l'adresse complète
                    string adresseComplete = adresse;
                    if (!string.IsNullOrEmpty(cp) && !string.IsNullOrEmpty(ville))
                    {
                        adresseComplete += $" {cp} {ville}";
                    }

                    // Créer le dialogue pour sauvegarder le fichier PDF
                    SaveFileDialog saveDialog = new SaveFileDialog
                    {
                        Filter = "Fichiers PDF (*.pdf)|*.pdf",
                        FileName = $"Rapport_Mission_{idMission}_{dateDepart:yyyyMMdd_HHmm}.pdf",
                        Title = "Enregistrer le rapport de mission"
                    };

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Générer le PDF
                        GenererRapportPDF(saveDialog.FileName, idMission, nomCaserne,
                                        natureSinistre, motifAppel, adresseComplete, compteRendu,
                                        dateDepart, dateRetour, listePompiers, listeEngins);

                        MessageBox.Show($"Rapport PDF généré avec succès :\n{saveDialog.FileName}",
                                      "PDF Créé", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Demander si l'utilisateur veut ouvrir le PDF
                        DialogResult openResult = MessageBox.Show("Voulez-vous ouvrir le rapport PDF ?",
                                                                "Ouvrir le PDF", MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Question);
                        if (openResult == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(saveDialog.FileName);
                        }
                    }
                }
                else
                {
                    reader.Close();
                    MessageBox.Show($"Aucune mission trouvée avec l'ID: {idMission}", "Erreur",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la création du PDF : " + ex.Message, "Erreur",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenererRapportPDF(string cheminFichier, string idMission, string nomCaserne,
                                     string natureSinistre, string motifAppel,
                                     string adresseComplete, string compteRendu, DateTime dateDepart,
                                     DateTime? dateRetour, List<string> listePompiers, List<string> listeEngins)
        {
            try
            {
                // Utilisation d'iTextSharp pour générer le PDF
                // Note: Vous devrez ajouter la référence NuGet iTextSharp
                using (FileStream fs = new FileStream(cheminFichier, FileMode.Create))
                {
                    using (iTextSharp.text.Document document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 50, 50, 50, 50))
                    {
                        iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(document, fs);
                        document.Open();

                        // Définir les polices
                        iTextSharp.text.Font titleFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD);
                        iTextSharp.text.Font headerFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD);
                        iTextSharp.text.Font normalFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10);
                        iTextSharp.text.Font boldFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD);

                        // Titre du document
                        iTextSharp.text.Paragraph title = new iTextSharp.text.Paragraph("RAPPORT DE MISSION", titleFont);
                        title.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                        title.SpacingAfter = 20;
                        document.Add(title);

                        // Informations générales
                        document.Add(new iTextSharp.text.Paragraph($"Mission N° : {idMission}", boldFont));
                        document.Add(new iTextSharp.text.Paragraph($"Déclenchée le : {dateDepart:dd/MM/yyyy à HH:mm}", normalFont));

                        if (dateRetour.HasValue)
                        {
                            document.Add(new iTextSharp.text.Paragraph($"Retour le : {dateRetour.Value:dd/MM/yyyy à HH:mm}", normalFont));
                            TimeSpan duree = dateRetour.Value - dateDepart;
                            document.Add(new iTextSharp.text.Paragraph($"Durée d'intervention : {duree.Hours}h{duree.Minutes:D2}min", normalFont));
                        }
                        else
                        {
                            document.Add(new iTextSharp.text.Paragraph("Mission en cours", boldFont));
                        }

                        document.Add(new iTextSharp.text.Paragraph("", normalFont)); // Ligne vide

                        // Type de sinistre
                        document.Add(new iTextSharp.text.Paragraph($"Type de sinistre : {natureSinistre}", headerFont));
                        document.Add(new iTextSharp.text.Paragraph("", normalFont));

                        // Motif et adresse
                        document.Add(new iTextSharp.text.Paragraph("Motif :", boldFont));
                        document.Add(new iTextSharp.text.Paragraph(motifAppel, normalFont));
                        document.Add(new iTextSharp.text.Paragraph("", normalFont));

                        if (!string.IsNullOrEmpty(adresseComplete))
                        {
                            document.Add(new iTextSharp.text.Paragraph($"Adresse : {adresseComplete}", normalFont));
                            document.Add(new iTextSharp.text.Paragraph("", normalFont));
                        }

                        // Compte-rendu
                        if (!string.IsNullOrEmpty(compteRendu))
                        {
                            document.Add(new iTextSharp.text.Paragraph("Compte-rendu :", boldFont));
                            document.Add(new iTextSharp.text.Paragraph(compteRendu, normalFont));
                            document.Add(new iTextSharp.text.Paragraph("", normalFont));
                        }

                        // Caserne
                        document.Add(new iTextSharp.text.Paragraph($"Caserne : {nomCaserne}", headerFont));
                        document.Add(new iTextSharp.text.Paragraph("", normalFont));

                        // Pompiers affectés
                        if (listePompiers.Count > 0)
                        {
                            document.Add(new iTextSharp.text.Paragraph("Pompiers affectés :", headerFont));
                            foreach (string pompier in listePompiers)
                            {
                                document.Add(new iTextSharp.text.Paragraph($"→ {pompier}", normalFont));
                            }
                            document.Add(new iTextSharp.text.Paragraph("", normalFont));
                        }

                        // Engins utilisés
                        if (listeEngins.Count > 0)
                        {
                            document.Add(new iTextSharp.text.Paragraph("Engins utilisés :", headerFont));
                            foreach (string engin in listeEngins)
                            {
                                document.Add(new iTextSharp.text.Paragraph($"→ {engin}", normalFont));
                            }
                            document.Add(new iTextSharp.text.Paragraph("", normalFont));
                        }

                        // Pied de page avec date de génération
                        document.Add(new iTextSharp.text.Paragraph("", normalFont));
                        document.Add(new iTextSharp.text.Paragraph("", normalFont));
                        iTextSharp.text.Paragraph footer = new iTextSharp.text.Paragraph($"Rapport généré le {DateTime.Now:dd/MM/yyyy à HH:mm}",
                                                                                       new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8));
                        footer.Alignment = iTextSharp.text.Element.ALIGN_RIGHT;
                        document.Add(footer);

                        document.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erreur lors de la génération du PDF : {ex.Message}");
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
                    // Vérifier si l'ID existe dans la base de données
                    string checkSql = "SELECT COUNT(*) FROM Mission WHERE Id = @Id";
                    SQLiteCommand checkCmd = new SQLiteCommand(checkSql, Connexion.Connec);
                    checkCmd.Parameters.AddWithValue("@Id", idMission);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count == 0)
                    {
                        MessageBox.Show($"Aucune mission trouvée avec l'ID: {idMission}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Vérifier si la mission n'est pas déjà terminée
                    string checkRetourSql = "SELECT terminee FROM Mission WHERE Id = @Id";
                    SQLiteCommand checkRetourCmd = new SQLiteCommand(checkRetourSql, Connexion.Connec);
                    checkRetourCmd.Parameters.AddWithValue("@Id", idMission);
                    object terminee = checkRetourCmd.ExecuteScalar();

                    if (terminee != DBNull.Value && Convert.ToInt32(terminee) == 1)
                    {
                        MessageBox.Show("Cette mission est déjà terminée.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Ouvrir le formulaire de saisie du compte rendu
                    string compteRendu = "";
                    using (FormCompteRendu formCompteRendu = new FormCompteRendu(idMission))
                    {
                        if (formCompteRendu.ShowDialog(this) == DialogResult.OK)
                        {
                            compteRendu = formCompteRendu.CompteRendu;
                        }
                        else
                        {
                            // L'utilisateur a annulé
                            return;
                        }
                    }

                    // Préparer la commande SQL pour mettre à jour la mission
                    string sql = "UPDATE Mission SET DateHeureRetour = @DateHeureRetour, terminee = @Terminee, compteRendu = @CompteRendu WHERE Id = @Id";
                    SQLiteCommand cmd = new SQLiteCommand(sql, Connexion.Connec);

                    // Paramètres
                    cmd.Parameters.AddWithValue("@DateHeureRetour", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@Terminee", 1);
                    cmd.Parameters.AddWithValue("@CompteRendu", compteRendu);
                    cmd.Parameters.AddWithValue("@Id", idMission);

                    // Exécuter la requête
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Mission terminée avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recharger les missions pour mettre à jour l'affichage
                        ChargerMissions(chkEnCours.Checked);
                        if (MesDatas.DsGlobal.Tables.Contains("Mission"))
                        {
                            AfficherMissions(MesDatas.DsGlobal.Tables["Mission"]);
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
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            // À implémenter
        }

        private void btnEngins_Click(object sender, EventArgs e)
        {
            try
            {
                // Créer une instance du formulaire FormParcoursEngins
                FormParcoursEngins formEngins = new FormParcoursEngins();

                // Afficher le formulaire
                formEngins.Show();
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