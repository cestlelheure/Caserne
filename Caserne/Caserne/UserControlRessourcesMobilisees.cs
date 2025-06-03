using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Caserne
{
    public partial class UserControlRessourcesMobilisees : UserControl
    {
        private DataTable _engins;
        private DataTable _pompiers;

        public UserControlRessourcesMobilisees()
        {
            InitializeComponent();
            InitialiserStyle();
        }

        public DataTable Engins
        {
            get => _engins;
            set
            {
                _engins = value;
                AfficherEngins();
            }
        }

        public DataTable Pompiers
        {
            get => _pompiers;
            set
            {
                _pompiers = value;
                AfficherPompiers();
            }
        }

        private void InitialiserStyle()
        {
            this.BackColor = Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        private void AfficherEngins()
        {
            pnlEngins.Controls.Clear();

            if (_engins == null || _engins.Rows.Count == 0)
            {
                var lblAucunEngin = new Label
                {
                    Text = "Aucun engin disponible",
                    ForeColor = Color.Gray,
                    Font = new Font("Microsoft YaHei", 9, FontStyle.Italic),
                    AutoSize = true,
                    Location = new Point(10, 10)
                };
                pnlEngins.Controls.Add(lblAucunEngin);
                return;
            }

            int yPosition = 10;
            var groupesEngins = _engins.AsEnumerable()
                .GroupBy(row => row.Field<string>("TypeEngin"))
                .ToList();

            foreach (var groupe in groupesEngins)
            {
                // Titre du type d'engin
                var lblTypeEngin = new Label
                {
                    Text = $"{groupe.Key} ({groupe.Count()})",
                    Font = new Font("Microsoft YaHei", 10, FontStyle.Bold),
                    ForeColor = Color.DarkBlue,
                    AutoSize = true,
                    Location = new Point(10, yPosition)
                };
                pnlEngins.Controls.Add(lblTypeEngin);
                yPosition += 25;

                // Liste des engins de ce type
                foreach (DataRow engin in groupe)
                {
                    var pnlEngin = CreerPanelEngin(engin);
                    pnlEngin.Location = new Point(20, yPosition);
                    pnlEngins.Controls.Add(pnlEngin);
                    yPosition += pnlEngin.Height + 5;
                }

                yPosition += 10; // Espace entre les groupes
            }
        }

        private Panel CreerPanelEngin(DataRow engin)
        {
            var panel = new Panel
            {
                Size = new Size(380, 60),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.LightBlue
            };

            var lblNumero = new Label
            {
                Text = $"N° {engin["numero"]}",
                Font = new Font("Microsoft YaHei", 9, FontStyle.Bold),
                Location = new Point(5, 5),
                AutoSize = true
            };

            var lblDateReception = new Label
            {
                Text = $"Reçu le: {Convert.ToDateTime(engin["dateReception"]):dd/MM/yyyy}",
                Font = new Font("Microsoft YaHei", 8),
                Location = new Point(5, 25),
                AutoSize = true,
                ForeColor = Color.DarkGray
            };

            var picStatut = new PictureBox
            {
                Size = new Size(16, 16),
                Location = new Point(350, 5),
                BackColor = Color.Green, // Disponible
                BorderStyle = BorderStyle.FixedSingle
            };

            panel.Controls.AddRange(new Control[] { lblNumero, lblDateReception, picStatut });
            return panel;
        }

        private void AfficherPompiers()
        {
            pnlPompiers.Controls.Clear();

            if (_pompiers == null || _pompiers.Rows.Count == 0)
            {
                var lblAucunPompier = new Label
                {
                    Text = "Aucun pompier disponible",
                    ForeColor = Color.Gray,
                    Font = new Font("Microsoft YaHei", 9, FontStyle.Italic),
                    AutoSize = true,
                    Location = new Point(10, 10)
                };
                pnlPompiers.Controls.Add(lblAucunPompier);
                return;
            }

            int yPosition = 10;
            var groupesGrades = _pompiers.AsEnumerable()
                .GroupBy(row => row.Field<string>("Grade"))
                .OrderByDescending(g => ObtenirRangGrade(g.Key))
                .ToList();

            foreach (var groupe in groupesGrades)
            {
                // Titre du grade
                var lblGrade = new Label
                {
                    Text = $"{groupe.Key} ({groupe.Count()})",
                    Font = new Font("Microsoft YaHei", 10, FontStyle.Bold),
                    ForeColor = Color.DarkRed,
                    AutoSize = true,
                    Location = new Point(10, yPosition)
                };
                pnlPompiers.Controls.Add(lblGrade);
                yPosition += 25;

                // Liste des pompiers de ce grade
                foreach (DataRow pompier in groupe)
                {
                    var pnlPompier = CreerPanelPompier(pompier);
                    pnlPompier.Location = new Point(20, yPosition);
                    pnlPompiers.Controls.Add(pnlPompier);
                    yPosition += pnlPompier.Height + 5;
                }

                yPosition += 10; // Espace entre les groupes
            }
        }

        private Panel CreerPanelPompier(DataRow pompier)
        {
            var panel = new Panel
            {
                Size = new Size(380, 80),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.LightCoral
            };

            var lblNomPrenom = new Label
            {
                Text = $"{pompier["nom"]} {pompier["prenom"]}",
                Font = new Font("Microsoft YaHei", 9, FontStyle.Bold),
                Location = new Point(5, 5),
                AutoSize = true
            };

            var lblMatricule = new Label
            {
                Text = $"Matricule: {pompier["matricule"]}",
                Font = new Font("Microsoft YaHei", 8),
                Location = new Point(5, 25),
                AutoSize = true,
                ForeColor = Color.DarkGray
            };

            var lblHabilitations = new Label
            {
                Text = $"Habilitations: {pompier["Habilitations"]}",
                Font = new Font("Microsoft YaHei", 8),
                Location = new Point(5, 45),
                Size = new Size(370, 30),
                ForeColor = Color.DarkBlue
            };

            var picStatut = new PictureBox
            {
                Size = new Size(16, 16),
                Location = new Point(350, 5),
                BackColor = Color.Green, // Disponible
                BorderStyle = BorderStyle.FixedSingle
            };

            panel.Controls.AddRange(new Control[] { lblNomPrenom, lblMatricule, lblHabilitations, picStatut });
            return panel;
        }

        private int ObtenirRangGrade(string grade)
        {
            // Simuler un système de rang pour trier les grades
            switch (grade?.ToLower())
            {
                case "commandant": return 10;
                case "capitaine": return 9;
                case "lieutenant": return 8;
                case "adjudant-chef": return 7;
                case "adjudant": return 6;
                case "sergent-chef": return 5;
                case "sergent": return 4;
                case "caporal-chef": return 3;
                case "caporal": return 2;
                case "sapeur": return 1;
                default: return 0;
            }
        }

        public void ViderAffichage()
        {
            pnlEngins.Controls.Clear();
            pnlPompiers.Controls.Clear();
        }

        public void AfficherStatistiques()
        {
            int nbEngins = _engins?.Rows.Count ?? 0;
            int nbPompiers = _pompiers?.Rows.Count ?? 0;

            lblStatistiques.Text = $"Total: {nbEngins} engin(s) - {nbPompiers} pompier(s)";
            lblStatistiques.ForeColor = nbEngins > 0 && nbPompiers > 0 ? Color.Green : Color.Orange;
        }

        private void UserControlRessourcesMobilisees_Resize(object sender, EventArgs e)
        {
            // Ajuster la taille des panneaux selon la taille du contrôle
            int largeurPanel = (this.Width - 30) / 2;
            pnlEngins.Width = largeurPanel;
            pnlPompiers.Width = largeurPanel;
            pnlPompiers.Left = pnlEngins.Right + 10;
        }
    }
}