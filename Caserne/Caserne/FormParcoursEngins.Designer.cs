namespace Caserne
{
    partial class FormParcoursEngins
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParcoursEngins));
            this.bttnPrecedent = new System.Windows.Forms.Button();
            this.bttnSuivant = new System.Windows.Forms.Button();
            this.pnlChoixCaserne = new System.Windows.Forms.Panel();
            this.lblChoixCaserne = new System.Windows.Forms.Label();
            this.cmbChoixCaserne = new System.Windows.Forms.ComboBox();
            this.pnlInfosEngins = new System.Windows.Forms.Panel();
            this.grpEtat = new System.Windows.Forms.GroupBox();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.lblEnPanne = new System.Windows.Forms.Label();
            this.grpInfos = new System.Windows.Forms.GroupBox();
            this.lblNumeroEngin = new System.Windows.Forms.Label();
            this.lblDateRCP = new System.Windows.Forms.Label();
            this.bttnFin = new System.Windows.Forms.Button();
            this.bttnDebut = new System.Windows.Forms.Button();
            this.bttnQuitter = new System.Windows.Forms.Button();
            this.pbEngin = new System.Windows.Forms.PictureBox();
            this.pnlChoixCaserne.SuspendLayout();
            this.pnlInfosEngins.SuspendLayout();
            this.grpEtat.SuspendLayout();
            this.grpInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEngin)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnPrecedent
            // 
            this.bttnPrecedent.BackColor = System.Drawing.Color.IndianRed;
            this.bttnPrecedent.Font = new System.Drawing.Font("MS PGothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPrecedent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttnPrecedent.Location = new System.Drawing.Point(628, 622);
            this.bttnPrecedent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttnPrecedent.Name = "bttnPrecedent";
            this.bttnPrecedent.Size = new System.Drawing.Size(77, 67);
            this.bttnPrecedent.TabIndex = 2;
            this.bttnPrecedent.Text = "<";
            this.bttnPrecedent.UseVisualStyleBackColor = false;
            this.bttnPrecedent.Click += new System.EventHandler(this.bttnPrecedent_Click);
            // 
            // bttnSuivant
            // 
            this.bttnSuivant.BackColor = System.Drawing.Color.IndianRed;
            this.bttnSuivant.Font = new System.Drawing.Font("MS PGothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSuivant.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttnSuivant.Location = new System.Drawing.Point(780, 622);
            this.bttnSuivant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttnSuivant.Name = "bttnSuivant";
            this.bttnSuivant.Size = new System.Drawing.Size(77, 67);
            this.bttnSuivant.TabIndex = 3;
            this.bttnSuivant.Text = ">";
            this.bttnSuivant.UseVisualStyleBackColor = false;
            this.bttnSuivant.Click += new System.EventHandler(this.bttnSuivant_Click);
            // 
            // pnlChoixCaserne
            // 
            this.pnlChoixCaserne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlChoixCaserne.Controls.Add(this.lblChoixCaserne);
            this.pnlChoixCaserne.Controls.Add(this.cmbChoixCaserne);
            this.pnlChoixCaserne.Location = new System.Drawing.Point(262, 123);
            this.pnlChoixCaserne.Name = "pnlChoixCaserne";
            this.pnlChoixCaserne.Size = new System.Drawing.Size(954, 68);
            this.pnlChoixCaserne.TabIndex = 4;
            // 
            // lblChoixCaserne
            // 
            this.lblChoixCaserne.AutoSize = true;
            this.lblChoixCaserne.Location = new System.Drawing.Point(20, 23);
            this.lblChoixCaserne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChoixCaserne.Name = "lblChoixCaserne";
            this.lblChoixCaserne.Size = new System.Drawing.Size(146, 20);
            this.lblChoixCaserne.TabIndex = 6;
            this.lblChoixCaserne.Text = "Choix de la caserne :";
            // 
            // cmbChoixCaserne
            // 
            this.cmbChoixCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChoixCaserne.FormattingEnabled = true;
            this.cmbChoixCaserne.Location = new System.Drawing.Point(295, 20);
            this.cmbChoixCaserne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbChoixCaserne.Name = "cmbChoixCaserne";
            this.cmbChoixCaserne.Size = new System.Drawing.Size(639, 28);
            this.cmbChoixCaserne.TabIndex = 5;
            this.cmbChoixCaserne.SelectedIndexChanged += new System.EventHandler(this.cmbChoixCaserne_SelectedIndexChanged);
            // 
            // pnlInfosEngins
            // 
            this.pnlInfosEngins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInfosEngins.Controls.Add(this.grpEtat);
            this.pnlInfosEngins.Controls.Add(this.grpInfos);
            this.pnlInfosEngins.Controls.Add(this.pbEngin);
            this.pnlInfosEngins.Location = new System.Drawing.Point(262, 237);
            this.pnlInfosEngins.Name = "pnlInfosEngins";
            this.pnlInfosEngins.Size = new System.Drawing.Size(950, 351);
            this.pnlInfosEngins.TabIndex = 5;
            // 
            // grpEtat
            // 
            this.grpEtat.Controls.Add(this.lblDisponible);
            this.grpEtat.Controls.Add(this.lblEnPanne);
            this.grpEtat.Location = new System.Drawing.Point(41, 181);
            this.grpEtat.Name = "grpEtat";
            this.grpEtat.Size = new System.Drawing.Size(340, 142);
            this.grpEtat.TabIndex = 17;
            this.grpEtat.TabStop = false;
            this.grpEtat.Text = "Etat";
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Location = new System.Drawing.Point(49, 48);
            this.lblDisponible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(106, 20);
            this.lblDisponible.TabIndex = 10;
            this.lblDisponible.Text = "Disponibilité : ";
            // 
            // lblEnPanne
            // 
            this.lblEnPanne.AutoSize = true;
            this.lblEnPanne.Location = new System.Drawing.Point(49, 94);
            this.lblEnPanne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnPanne.Name = "lblEnPanne";
            this.lblEnPanne.Size = new System.Drawing.Size(84, 20);
            this.lblEnPanne.TabIndex = 9;
            this.lblEnPanne.Text = "En panne : ";
            // 
            // grpInfos
            // 
            this.grpInfos.Controls.Add(this.lblNumeroEngin);
            this.grpInfos.Controls.Add(this.lblDateRCP);
            this.grpInfos.Location = new System.Drawing.Point(41, 42);
            this.grpInfos.Name = "grpInfos";
            this.grpInfos.Size = new System.Drawing.Size(340, 133);
            this.grpInfos.TabIndex = 16;
            this.grpInfos.TabStop = false;
            this.grpInfos.Text = "Informations";
            // 
            // lblNumeroEngin
            // 
            this.lblNumeroEngin.AutoSize = true;
            this.lblNumeroEngin.Location = new System.Drawing.Point(49, 41);
            this.lblNumeroEngin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroEngin.Name = "lblNumeroEngin";
            this.lblNumeroEngin.Size = new System.Drawing.Size(75, 20);
            this.lblNumeroEngin.TabIndex = 15;
            this.lblNumeroEngin.Text = "Numéro : ";
            // 
            // lblDateRCP
            // 
            this.lblDateRCP.AutoSize = true;
            this.lblDateRCP.Location = new System.Drawing.Point(49, 83);
            this.lblDateRCP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateRCP.Name = "lblDateRCP";
            this.lblDateRCP.Size = new System.Drawing.Size(141, 20);
            this.lblDateRCP.TabIndex = 16;
            this.lblDateRCP.Text = "Date de récéption : ";
            // 
            // bttnFin
            // 
            this.bttnFin.BackColor = System.Drawing.Color.IndianRed;
            this.bttnFin.Font = new System.Drawing.Font("MS PGothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnFin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttnFin.Location = new System.Drawing.Point(882, 622);
            this.bttnFin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttnFin.Name = "bttnFin";
            this.bttnFin.Size = new System.Drawing.Size(77, 67);
            this.bttnFin.TabIndex = 6;
            this.bttnFin.Text = ">>\r\n";
            this.bttnFin.UseVisualStyleBackColor = false;
            this.bttnFin.Click += new System.EventHandler(this.bttnFin_Click);
            // 
            // bttnDebut
            // 
            this.bttnDebut.BackColor = System.Drawing.Color.IndianRed;
            this.bttnDebut.Font = new System.Drawing.Font("MS PGothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDebut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttnDebut.Location = new System.Drawing.Point(526, 622);
            this.bttnDebut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttnDebut.Name = "bttnDebut";
            this.bttnDebut.Size = new System.Drawing.Size(77, 67);
            this.bttnDebut.TabIndex = 7;
            this.bttnDebut.Text = "<<";
            this.bttnDebut.UseVisualStyleBackColor = false;
            this.bttnDebut.Click += new System.EventHandler(this.bttnDebut_Click);
            // 
            // bttnQuitter
            // 
            this.bttnQuitter.BackColor = System.Drawing.Color.IndianRed;
            this.bttnQuitter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttnQuitter.Location = new System.Drawing.Point(1061, 617);
            this.bttnQuitter.Name = "bttnQuitter";
            this.bttnQuitter.Size = new System.Drawing.Size(154, 76);
            this.bttnQuitter.TabIndex = 8;
            this.bttnQuitter.Text = "Quitter";
            this.bttnQuitter.UseVisualStyleBackColor = false;
            this.bttnQuitter.Click += new System.EventHandler(this.bttnQuitter_Click);
            // 
            // pbEngin
            // 
            this.pbEngin.Location = new System.Drawing.Point(416, 54);
            this.pbEngin.Name = "pbEngin";
            this.pbEngin.Size = new System.Drawing.Size(500, 269);
            this.pbEngin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEngin.TabIndex = 15;
            this.pbEngin.TabStop = false;
            // 
            // FormParcoursEngins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1518, 754);
            this.Controls.Add(this.bttnQuitter);
            this.Controls.Add(this.bttnDebut);
            this.Controls.Add(this.bttnFin);
            this.Controls.Add(this.pnlInfosEngins);
            this.Controls.Add(this.pnlChoixCaserne);
            this.Controls.Add(this.bttnSuivant);
            this.Controls.Add(this.bttnPrecedent);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormParcoursEngins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualisation des engins";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlChoixCaserne.ResumeLayout(false);
            this.pnlChoixCaserne.PerformLayout();
            this.pnlInfosEngins.ResumeLayout(false);
            this.grpEtat.ResumeLayout(false);
            this.grpEtat.PerformLayout();
            this.grpInfos.ResumeLayout(false);
            this.grpInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEngin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bttnPrecedent;
        private System.Windows.Forms.Button bttnSuivant;
        private System.Windows.Forms.Panel pnlChoixCaserne;
        private System.Windows.Forms.Label lblChoixCaserne;
        private System.Windows.Forms.ComboBox cmbChoixCaserne;
        private System.Windows.Forms.Panel pnlInfosEngins;
        private System.Windows.Forms.PictureBox pbEngin;
        private System.Windows.Forms.Label lblDisponible;
        private System.Windows.Forms.Label lblEnPanne;
        private System.Windows.Forms.Button bttnFin;
        private System.Windows.Forms.Button bttnDebut;
        private System.Windows.Forms.GroupBox grpEtat;
        private System.Windows.Forms.GroupBox grpInfos;
        private System.Windows.Forms.Label lblNumeroEngin;
        private System.Windows.Forms.Label lblDateRCP;
        private System.Windows.Forms.Button bttnQuitter;
    }
}