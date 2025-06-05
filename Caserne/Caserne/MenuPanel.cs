using System;
using System.Windows.Forms;

namespace Caserne
{
    public partial class MenuPanel : UserControl
    {
        // Événements pour communiquer avec le formulaire parent
        public event EventHandler TableauDeBordClicked;
        public event EventHandler EnginsClicked;
        public event EventHandler PersonnelClicked;
        public event EventHandler StatsClicked;
        public event EventHandler QuitterClicked;

        public MenuPanel()
        {
            InitializeComponent();
        }

        private void btnTableauDeBord_Click(object sender, EventArgs e)
        {
            TableauDeBordClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnEngins_Click(object sender, EventArgs e)
        {
            EnginsClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            PersonnelClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            StatsClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            QuitterClicked?.Invoke(this, EventArgs.Empty);
        }

        // Méthode pour mettre en évidence le bouton actif
        public void SetActiveButton(string buttonName)
        {
            // Réinitialiser tous les boutons
            ResetButtonStyles();

            // Mettre en évidence le bouton actif
            switch (buttonName.ToLower())
            {
                case "tableaudebord":
                    btnTableauDeBord.BackColor = System.Drawing.Color.DarkRed;
                    break;
                case "engins":
                    btnEngins.BackColor = System.Drawing.Color.DarkRed;
                    break;
                case "personnel":
                    btnPersonnel.BackColor = System.Drawing.Color.DarkRed;
                    break;
                case "stats":
                    btnStats.BackColor = System.Drawing.Color.DarkRed;
                    break;
            }
        }

        private void ResetButtonStyles()
        {
            btnTableauDeBord.BackColor = System.Drawing.Color.IndianRed;
            btnEngins.BackColor = System.Drawing.Color.IndianRed;
            btnPersonnel.BackColor = System.Drawing.Color.IndianRed;
            btnStats.BackColor = System.Drawing.Color.IndianRed;
            btnQuitter.BackColor = System.Drawing.Color.IndianRed;
        }

        private void MenuPanel_Load(object sender, EventArgs e)
        {
            // Initialiser les styles des boutons
            ResetButtonStyles();

            // Définir le bouton Tableau de bord comme actif par défaut
            SetActiveButton("tableaudebord");
        }
    }
}