using System.Windows.Forms;

namespace Caserne
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnPersonnel = new System.Windows.Forms.Button();
            this.btnEngins = new System.Windows.Forms.Button();
            this.btnTableauDeBord = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.chkEnCours = new System.Windows.Forms.CheckBox();
            this.flowMissions = new System.Windows.Forms.FlowLayoutPanel();
            this.missionPanel = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.picEng = new System.Windows.Forms.PictureBox();
            this.picPerso = new System.Windows.Forms.PictureBox();
            this.picStat = new System.Windows.Forms.PictureBox();
            this.picQuitter = new System.Windows.Forms.PictureBox();
            this.btnMission = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.flowMissions.SuspendLayout();
            this.missionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).BeginInit();
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
            // 
            // flowMissions
            // 
            this.flowMissions.AutoScroll = true;
            this.flowMissions.Controls.Add(this.missionPanel);
            this.flowMissions.Location = new System.Drawing.Point(6, 111);
            this.flowMissions.Name = "flowMissions";
            this.flowMissions.Size = new System.Drawing.Size(864, 550);
            this.flowMissions.TabIndex = 2;
            // 
            // missionPanel
            // 
            this.missionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.missionPanel.Controls.Add(this.picture1);
            this.missionPanel.Controls.Add(this.label1);
            this.missionPanel.Controls.Add(this.lblDate);
            this.missionPanel.Controls.Add(this.lblID);
            this.missionPanel.Controls.Add(this.lblDesc);
            this.missionPanel.Controls.Add(this.pic1);
            this.missionPanel.Location = new System.Drawing.Point(10, 10);
            this.missionPanel.Margin = new System.Windows.Forms.Padding(10);
            this.missionPanel.Name = "missionPanel";
            this.missionPanel.Size = new System.Drawing.Size(847, 110);
            this.missionPanel.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(113, 3);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(104, 24);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Id mission :";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(508, 56);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(152, 24);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "--> Description ...";
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(3, 133);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(100, 50);
            this.pic1.TabIndex = 2;
            this.pic1.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(306, 3);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(85, 24);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Debut le ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Caserne : ";
            // 
            // picture1
            // 
            this.picture1.Image = ((System.Drawing.Image)(resources.GetObject("picture1.Image")));
            this.picture1.Location = new System.Drawing.Point(3, 3);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(104, 102);
            this.picture1.TabIndex = 5;
            this.picture1.TabStop = false;
            // 
            // picMenu
            // 
            this.picMenu.Location = new System.Drawing.Point(12, 8);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(75, 75);
            this.picMenu.TabIndex = 6;
            this.picMenu.TabStop = false;
            // 
            // picEng
            // 
            this.picEng.Location = new System.Drawing.Point(12, 97);
            this.picEng.Name = "picEng";
            this.picEng.Size = new System.Drawing.Size(75, 75);
            this.picEng.TabIndex = 7;
            this.picEng.TabStop = false;
            // 
            // picPerso
            // 
            this.picPerso.Location = new System.Drawing.Point(12, 186);
            this.picPerso.Name = "picPerso";
            this.picPerso.Size = new System.Drawing.Size(75, 75);
            this.picPerso.TabIndex = 8;
            this.picPerso.TabStop = false;
            // 
            // picStat
            // 
            this.picStat.Image = ((System.Drawing.Image)(resources.GetObject("picStat.Image")));
            this.picStat.Location = new System.Drawing.Point(12, 273);
            this.picStat.Name = "picStat";
            this.picStat.Size = new System.Drawing.Size(75, 75);
            this.picStat.TabIndex = 9;
            this.picStat.TabStop = false;
            // 
            // picQuitter
            // 
            this.picQuitter.Image = ((System.Drawing.Image)(resources.GetObject("picQuitter.Image")));
            this.picQuitter.Location = new System.Drawing.Point(12, 581);
            this.picQuitter.Name = "picQuitter";
            this.picQuitter.Size = new System.Drawing.Size(80, 80);
            this.picQuitter.TabIndex = 10;
            this.picQuitter.TabStop = false;
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
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Les soldats du feu";
            this.panelMenu.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.flowMissions.ResumeLayout(false);
            this.missionPanel.ResumeLayout(false);
            this.missionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuitter)).EndInit();
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
        private Panel missionPanel;
        private Label lblID;
        private Label lblDesc;
        private PictureBox pic1;
        private PictureBox picture1;
        private Label label1;
        private Label lblDate;
        private PictureBox picQuitter;
        private PictureBox picStat;
        private PictureBox picPerso;
        private PictureBox picEng;
        private PictureBox picMenu;
        private Button btnMission;
    }
}
