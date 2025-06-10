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
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnMission = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.chkEnCours = new System.Windows.Forms.CheckBox();
            this.flowMissions = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnPersonnel = new System.Windows.Forms.Button();
            this.btnEngins = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMain.Controls.Add(this.btnMission);
            this.panelMain.Controls.Add(this.flowMissions);
            this.panelMain.Controls.Add(this.chkEnCours);
            this.panelMain.Controls.Add(this.lblTitre);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(471, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1063, 831);
            this.panelMain.TabIndex = 0;
            // 
            // btnMission
            // 
            this.btnMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMission.Location = new System.Drawing.Point(573, 8);
            this.btnMission.Name = "btnMission";
            this.btnMission.Size = new System.Drawing.Size(455, 81);
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
            this.lblTitre.Size = new System.Drawing.Size(232, 33);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Tableau de bord";
            // 
            // chkEnCours
            // 
            this.chkEnCours.AutoSize = true;
            this.chkEnCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnCours.Location = new System.Drawing.Point(16, 12);
            this.chkEnCours.Name = "chkEnCours";
            this.chkEnCours.Size = new System.Drawing.Size(87, 22);
            this.chkEnCours.TabIndex = 1;
            this.chkEnCours.Text = "En cours";
            this.chkEnCours.CheckedChanged += new System.EventHandler(this.chkEnCours_CheckedChanged);
            // 
            // flowMissions
            // 
            this.flowMissions.AutoScroll = true;
            this.flowMissions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowMissions.Location = new System.Drawing.Point(35, 111);
            this.flowMissions.Name = "flowMissions";
            this.flowMissions.Size = new System.Drawing.Size(993, 665);
            this.flowMissions.TabIndex = 2;
            this.flowMissions.WrapContents = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.IndianRed;
            this.panelMenu.Controls.Add(this.pbLogo);
            this.panelMenu.Controls.Add(this.btnQuitter);
            this.panelMenu.Controls.Add(this.btnStats);
            this.panelMenu.Controls.Add(this.btnPersonnel);
            this.panelMenu.Controls.Add(this.btnEngins);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(471, 831);
            this.panelMenu.TabIndex = 1;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuitter.Image = global::Caserne.Properties.Resources.quitter;
            this.btnQuitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitter.Location = new System.Drawing.Point(0, 725);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(471, 106);
            this.btnQuitter.TabIndex = 0;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnStats
            // 
            this.btnStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.ForeColor = System.Drawing.Color.Snow;
            this.btnStats.Image = global::Caserne.Properties.Resources.stat1;
            this.btnStats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStats.Location = new System.Drawing.Point(0, 178);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(471, 89);
            this.btnStats.TabIndex = 1;
            this.btnStats.Text = "Statistiques";
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnPersonnel
            // 
            this.btnPersonnel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonnel.ForeColor = System.Drawing.Color.Snow;
            this.btnPersonnel.Image = global::Caserne.Properties.Resources.personnel;
            this.btnPersonnel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonnel.Location = new System.Drawing.Point(0, 89);
            this.btnPersonnel.Name = "btnPersonnel";
            this.btnPersonnel.Size = new System.Drawing.Size(471, 89);
            this.btnPersonnel.TabIndex = 2;
            this.btnPersonnel.Text = "Gestion du personnel";
            this.btnPersonnel.Click += new System.EventHandler(this.btnPersonnel_Click);
            // 
            // btnEngins
            // 
            this.btnEngins.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEngins.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEngins.ForeColor = System.Drawing.Color.Snow;
            this.btnEngins.Image = global::Caserne.Properties.Resources.engins;
            this.btnEngins.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEngins.Location = new System.Drawing.Point(0, 0);
            this.btnEngins.Name = "btnEngins";
            this.btnEngins.Size = new System.Drawing.Size(471, 89);
            this.btnEngins.TabIndex = 3;
            this.btnEngins.Text = "Gestion des engins";
            this.btnEngins.Click += new System.EventHandler(this.btnEngins_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(24, 285);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(415, 415);
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // FrmTableauBord
            // 
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1534, 831);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmTableauBord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les soldats du feu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTableauBord_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.CheckBox chkEnCours;
        private System.Windows.Forms.FlowLayoutPanel flowMissions;
        private Button btnMission;
        private Button btnEngins;
        private Button btnPersonnel;
        private Button btnStats;
        private Button btnQuitter;
        private Panel panelMenu;
        private PictureBox pbLogo;
    }
}
