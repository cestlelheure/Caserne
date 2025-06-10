using System.Windows.Forms;

namespace Caserne
{
    partial class FrmTableauBord
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTableauBord));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnPersonnel = new System.Windows.Forms.Button();
            this.btnEngins = new System.Windows.Forms.Button();
            this.btnTableauDeBord = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnMission = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.chkEnCours = new System.Windows.Forms.CheckBox();
            this.flowMissions = new System.Windows.Forms.FlowLayoutPanel();
            this.picQuitter = new System.Windows.Forms.PictureBox();
            this.picStat = new System.Windows.Forms.PictureBox();
            this.picPerso = new System.Windows.Forms.PictureBox();
            this.picEng = new System.Windows.Forms.PictureBox();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.IndianRed;
            this.panelMenu.Controls.Add(this.picQuitter);
            this.panelMenu.Controls.Add(this.picStat);
            this.panelMenu.Controls.Add(this.picPerso);
            this.panelMenu.Controls.Add(this.picEng);
            this.panelMenu.Controls.Add(this.picMenu);
            this.panelMenu.Controls.Add(this.btnQuitter);
            this.panelMenu.Controls.Add(this.btnStats);
            this.panelMenu.Controls.Add(this.btnPersonnel);
            this.panelMenu.Controls.Add(this.btnEngins);
            this.panelMenu.Controls.Add(this.btnTableauDeBord);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(380, 673);
            this.panelMenu.TabIndex = 1;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuitter.Location = new System.Drawing.Point(0, 567);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(380, 106);
            this.btnQuitter.TabIndex = 0;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnStats
            // 
            this.btnStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.ForeColor = System.Drawing.Color.Snow;
            this.btnStats.Location = new System.Drawing.Point(0, 267);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(380, 89);
            this.btnStats.TabIndex = 1;
            this.btnStats.Text = "Statistiques";
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnPersonnel
            // 
            this.btnPersonnel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonnel.ForeColor = System.Drawing.Color.Snow;
            this.btnPersonnel.Location = new System.Drawing.Point(0, 178);
            this.btnPersonnel.Name = "btnPersonnel";
            this.btnPersonnel.Size = new System.Drawing.Size(380, 89);
            this.btnPersonnel.TabIndex = 2;
            this.btnPersonnel.Text = "Gestion du personnel";
            this.btnPersonnel.Click += new System.EventHandler(this.btnPersonnel_Click);
            // 
            // btnEngins
            // 
            this.btnEngins.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEngins.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEngins.ForeColor = System.Drawing.Color.Snow;
            this.btnEngins.Location = new System.Drawing.Point(0, 89);
            this.btnEngins.Name = "btnEngins";
            this.btnEngins.Size = new System.Drawing.Size(380, 89);
            this.btnEngins.TabIndex = 3;
            this.btnEngins.Text = "Gestion des engins";
            this.btnEngins.Click += new System.EventHandler(this.btnEngins_Click);
            // 
            // btnTableauDeBord
            // 
            this.btnTableauDeBord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTableauDeBord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableauDeBord.ForeColor = System.Drawing.Color.Snow;
            this.btnTableauDeBord.Location = new System.Drawing.Point(0, 0);
            this.btnTableauDeBord.Name = "btnTableauDeBord";
            this.btnTableauDeBord.Size = new System.Drawing.Size(380, 89);
            this.btnTableauDeBord.TabIndex = 5;
            this.btnTableauDeBord.Text = "Tableau de bord";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMain.Controls.Add(this.btnMission);
            this.panelMain.Controls.Add(this.lblTitre);
            this.panelMain.Controls.Add(this.chkEnCours);
            this.panelMain.Controls.Add(this.flowMissions);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(380, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(882, 673);
            this.panelMain.TabIndex = 0;
            // 
            // btnMission
            // 
            this.btnMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMission.Location = new System.Drawing.Point(573, 8);
            this.btnMission.Name = "btnMission";
            this.btnMission.Size = new System.Drawing.Size(290, 97);
            this.btnMission.TabIndex = 3;
            this.btnMission.Text = "Nouvelle mission";
            this.btnMission.UseVisualStyleBackColor = true;
            this.btnMission.Click += new System.EventHandler(this.btnMission_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Arial", 21F, System.Drawing.FontStyle.Bold);
            this.lblTitre.Location = new System.Drawing.Point(270, 20);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(280, 41);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Tableau de bord";
            // 
            // chkEnCours
            // 
            this.chkEnCours.AutoSize = true;
            this.chkEnCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnCours.Location = new System.Drawing.Point(16, 12);
            this.chkEnCours.Name = "chkEnCours";
            this.chkEnCours.Size = new System.Drawing.Size(108, 28);
            this.chkEnCours.TabIndex = 1;
            this.chkEnCours.Text = "En cours";
            this.chkEnCours.CheckedChanged += new System.EventHandler(this.chkEnCours_CheckedChanged);
            // 
            // flowMissions
            // 
            this.flowMissions.AutoScroll = true;
            this.flowMissions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowMissions.Location = new System.Drawing.Point(6, 111);
            this.flowMissions.Name = "flowMissions";
            this.flowMissions.Size = new System.Drawing.Size(857, 550);
            this.flowMissions.TabIndex = 2;
            this.flowMissions.WrapContents = false;
            // 
            // picQuitter
            // 
            this.picQuitter.Image = global::Caserne.Properties.Resources.quitter;
            this.picQuitter.Location = new System.Drawing.Point(12, 581);
            this.picQuitter.Name = "picQuitter";
            this.picQuitter.Size = new System.Drawing.Size(80, 80);
            this.picQuitter.TabIndex = 10;
            this.picQuitter.TabStop = false;
            // 
            // picStat
            // 
            this.picStat.Image = global::Caserne.Properties.Resources.stat1;
            this.picStat.Location = new System.Drawing.Point(12, 273);
            this.picStat.Name = "picStat";
            this.picStat.Size = new System.Drawing.Size(75, 75);
            this.picStat.TabIndex = 9;
            this.picStat.TabStop = false;
            // 
            // picPerso
            // 
            this.picPerso.Image = global::Caserne.Properties.Resources.personnel;
            this.picPerso.Location = new System.Drawing.Point(12, 186);
            this.picPerso.Name = "picPerso";
            this.picPerso.Size = new System.Drawing.Size(75, 75);
            this.picPerso.TabIndex = 8;
            this.picPerso.TabStop = false;
            // 
            // picEng
            // 
            this.picEng.Image = global::Caserne.Properties.Resources.engins;
            this.picEng.Location = new System.Drawing.Point(12, 97);
            this.picEng.Name = "picEng";
            this.picEng.Size = new System.Drawing.Size(75, 75);
            this.picEng.TabIndex = 7;
            this.picEng.TabStop = false;
            // 
            // picMenu
            // 
            this.picMenu.Image = global::Caserne.Properties.Resources.tableaudebord;
            this.picMenu.Location = new System.Drawing.Point(12, 8);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(75, 75);
            this.picMenu.TabIndex = 6;
            this.picMenu.TabStop = false;
            // 
            // FrmTableauBord
            // 
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTableauBord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les soldats du feu";
            this.Load += new System.EventHandler(this.FrmTableauBord_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnPersonnel;
        private System.Windows.Forms.Button btnEngins;
        private System.Windows.Forms.Button btnTableauDeBord;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.CheckBox chkEnCours;
        private System.Windows.Forms.FlowLayoutPanel flowMissions;
        private PictureBox picQuitter;
        private PictureBox picStat;
        private PictureBox picPerso;
        private PictureBox picEng;
        private PictureBox picMenu;
        private Button btnMission;
    }
}
