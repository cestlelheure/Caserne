using System.Windows.Forms;

namespace Caserne
{
    partial class MenuPanel
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPanel));
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnPersonnel = new System.Windows.Forms.Button();
            this.btnEngins = new System.Windows.Forms.Button();
            this.btnTableauDeBord = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picStat = new System.Windows.Forms.PictureBox();
            this.picPerso = new System.Windows.Forms.PictureBox();
            this.picEng = new System.Windows.Forms.PictureBox();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.IndianRed;
            this.btnQuitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuitter.Location = new System.Drawing.Point(0, 567);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(425, 106);
            this.btnQuitter.TabIndex = 0;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnStats
            // 
            this.btnStats.BackColor = System.Drawing.Color.IndianRed;
            this.btnStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.ForeColor = System.Drawing.Color.Snow;
            this.btnStats.Location = new System.Drawing.Point(0, 267);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(425, 89);
            this.btnStats.TabIndex = 1;
            this.btnStats.Text = "Statistiques";
            this.btnStats.UseVisualStyleBackColor = false;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnPersonnel
            // 
            this.btnPersonnel.BackColor = System.Drawing.Color.IndianRed;
            this.btnPersonnel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonnel.ForeColor = System.Drawing.Color.Snow;
            this.btnPersonnel.Location = new System.Drawing.Point(0, 178);
            this.btnPersonnel.Name = "btnPersonnel";
            this.btnPersonnel.Size = new System.Drawing.Size(425, 89);
            this.btnPersonnel.TabIndex = 2;
            this.btnPersonnel.Text = "Gestion du personnel";
            this.btnPersonnel.UseVisualStyleBackColor = false;
            this.btnPersonnel.Click += new System.EventHandler(this.btnPersonnel_Click);
            // 
            // btnEngins
            // 
            this.btnEngins.BackColor = System.Drawing.Color.IndianRed;
            this.btnEngins.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEngins.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEngins.ForeColor = System.Drawing.Color.Snow;
            this.btnEngins.Location = new System.Drawing.Point(0, 89);
            this.btnEngins.Name = "btnEngins";
            this.btnEngins.Size = new System.Drawing.Size(425, 89);
            this.btnEngins.TabIndex = 3;
            this.btnEngins.Text = "Gestion des engins";
            this.btnEngins.UseVisualStyleBackColor = false;
            this.btnEngins.Click += new System.EventHandler(this.btnEngins_Click);
            // 
            // btnTableauDeBord
            // 
            this.btnTableauDeBord.BackColor = System.Drawing.Color.IndianRed;
            this.btnTableauDeBord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTableauDeBord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableauDeBord.ForeColor = System.Drawing.Color.Snow;
            this.btnTableauDeBord.Location = new System.Drawing.Point(0, 0);
            this.btnTableauDeBord.Name = "btnTableauDeBord";
            this.btnTableauDeBord.Size = new System.Drawing.Size(425, 89);
            this.btnTableauDeBord.TabIndex = 5;
            this.btnTableauDeBord.Text = "Tableau de bord";
            this.btnTableauDeBord.UseVisualStyleBackColor = false;
            this.btnTableauDeBord.Click += new System.EventHandler(this.btnTableauDeBord_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Caserne.Properties.Resources.Logo_1__1_;
            this.pictureBox1.Location = new System.Drawing.Point(116, 361);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // picStat
            // 
            this.picStat.BackColor = System.Drawing.Color.IndianRed;
            this.picStat.Image = ((System.Drawing.Image)(resources.GetObject("picStat.Image")));
            this.picStat.Location = new System.Drawing.Point(12, 273);
            this.picStat.Name = "picStat";
            this.picStat.Size = new System.Drawing.Size(75, 75);
            this.picStat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStat.TabIndex = 9;
            this.picStat.TabStop = false;
            // 
            // picPerso
            // 
            this.picPerso.BackColor = System.Drawing.Color.IndianRed;
            this.picPerso.Image = ((System.Drawing.Image)(resources.GetObject("picPerso.Image")));
            this.picPerso.Location = new System.Drawing.Point(12, 186);
            this.picPerso.Name = "picPerso";
            this.picPerso.Size = new System.Drawing.Size(75, 75);
            this.picPerso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPerso.TabIndex = 8;
            this.picPerso.TabStop = false;
            // 
            // picEng
            // 
            this.picEng.BackColor = System.Drawing.Color.IndianRed;
            this.picEng.Image = ((System.Drawing.Image)(resources.GetObject("picEng.Image")));
            this.picEng.Location = new System.Drawing.Point(12, 97);
            this.picEng.Name = "picEng";
            this.picEng.Size = new System.Drawing.Size(75, 75);
            this.picEng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEng.TabIndex = 7;
            this.picEng.TabStop = false;
            // 
            // picMenu
            // 
            this.picMenu.BackColor = System.Drawing.Color.IndianRed;
            this.picMenu.Image = ((System.Drawing.Image)(resources.GetObject("picMenu.Image")));
            this.picMenu.Location = new System.Drawing.Point(12, 8);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(75, 75);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenu.TabIndex = 6;
            this.picMenu.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 583);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // MenuPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picStat);
            this.Controls.Add(this.picPerso);
            this.Controls.Add(this.picEng);
            this.Controls.Add(this.picMenu);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnPersonnel);
            this.Controls.Add(this.btnEngins);
            this.Controls.Add(this.btnTableauDeBord);
            this.Name = "MenuPanel";
            this.Size = new System.Drawing.Size(425, 673);
            this.Load += new System.EventHandler(this.MenuPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnPersonnel;
        private System.Windows.Forms.Button btnEngins;
        private System.Windows.Forms.Button btnTableauDeBord;
        private System.Windows.Forms.PictureBox picStat;
        private System.Windows.Forms.PictureBox picPerso;
        private System.Windows.Forms.PictureBox picEng;
        private System.Windows.Forms.PictureBox picMenu;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}