using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Caserne
{
    public partial class FormParcoursEngins : Form
    {
        private BindingSource bsEngins = new BindingSource();

        public FormParcoursEngins()
        {
            InitializeComponent();
            // Charger les casernes dans la ComboBox
            LoadCasernes();
            // Initialisation des événements
            cmbCaserne.SelectedIndexChanged += CmbCaserne_SelectedIndexChanged;
            bttnPrecedent.Click += bttnPrecedent_Click;
            bttnSuivant.Click += bttnSuivant_Click;
        }

        private void LoadCasernes()
        {
            // Récupère la liste des casernes
            var dt = new DataTable();
            using (var cmd = new SQLiteCommand("SELECT deptno AS Id, dname AS Nom FROM dept", Connexion.Connec))
            using (var da = new SQLiteDataAdapter(cmd))
            {
                da.Fill(dt);
            }
            cmbCaserne.DisplayMember = "Nom";
            cmbCaserne.ValueMember = "Id";
            cmbCaserne.DataSource = dt;
        }

        private void CmbCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCaserne.SelectedValue == null) return;
            int caserneId = (int)cmbCaserne.SelectedValue;
            LoadEngins(caserneId);
        }

        private void bttnPrecedent_Click(object sender, EventArgs e)
        {
            if (bsEngins.Position > 0)
                bsEngins.MovePrevious();
        }

        private void bttnSuivant_Click(object sender, EventArgs e)
        {
            if (bsEngins.Position < bsEngins.Count - 1)
                bsEngins.MoveNext();
        }
    }
}
