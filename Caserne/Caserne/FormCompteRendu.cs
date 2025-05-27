using System;
using System.Drawing;
using System.Windows.Forms;

namespace Caserne
{
    public partial class FormCompteRendu : Form
    {
        public string CompteRendu { get; private set; }

        public FormCompteRendu()
        {
            InitializeComponent();
        }

        public FormCompteRendu(string idMission) : this()
        {
            this.Text = $"Compte Rendu - Mission ID: {idMission}";
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            CompteRendu = txtCompteRendu.Text.Trim();
            
            if (string.IsNullOrEmpty(CompteRendu))
            {
                DialogResult result = MessageBox.Show(
                    "Le compte rendu est vide. Voulez-vous continuer sans compte rendu ?",
                    "Compte rendu vide",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                
                if (result == DialogResult.No)
                {
                    txtCompteRendu.Focus();
                    return;
                }
            }
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtCompteRendu_KeyDown(object sender, KeyEventArgs e)
        {
            // Permettre Ctrl+A pour sélectionner tout
            if (e.Control && e.KeyCode == Keys.A)
            {
                txtCompteRendu.SelectAll();
                e.Handled = true;
            }
        }

        private void FormCompteRendu_Load(object sender, EventArgs e)
        {
            txtCompteRendu.Focus();
        }
    }
}