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
            this.pbEngin = new System.Windows.Forms.PictureBox();
            this.lblEnMission = new System.Windows.Forms.Label();
            this.lblEnPanne = new System.Windows.Forms.Label();
            this.bttnFin = new System.Windows.Forms.Button();
            this.bttnDebut = new System.Windows.Forms.Button();
            this.grpInfos = new System.Windows.Forms.GroupBox();
            this.grpEtat = new System.Windows.Forms.GroupBox();
            this.lblNumeroEngin = new System.Windows.Forms.Label();
            this.lblDateRCP = new System.Windows.Forms.Label();
            this.pnlChoixCaserne.SuspendLayout();
            this.pnlInfosEngins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEngin)).BeginInit();
            this.grpInfos.SuspendLayout();
            this.grpEtat.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnPrecedent
            // 
            this.bttnPrecedent.Location = new System.Drawing.Point(382, 558);
            this.bttnPrecedent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttnPrecedent.Name = "bttnPrecedent";
            this.bttnPrecedent.Size = new System.Drawing.Size(94, 30);
            this.bttnPrecedent.TabIndex = 2;
            this.bttnPrecedent.Text = "<--";
            this.bttnPrecedent.UseVisualStyleBackColor = true;
            this.bttnPrecedent.Click += new System.EventHandler(this.bttnPrecedent_Click);
            // 
            // bttnSuivant
            // 
            this.bttnSuivant.Location = new System.Drawing.Point(534, 558);
            this.bttnSuivant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttnSuivant.Name = "bttnSuivant";
            this.bttnSuivant.Size = new System.Drawing.Size(94, 30);
            this.bttnSuivant.TabIndex = 3;
            this.bttnSuivant.Text = "-->";
            this.bttnSuivant.UseVisualStyleBackColor = true;
            this.bttnSuivant.Click += new System.EventHandler(this.bttnSuivant_Click);
            // 
            // pnlChoixCaserne
            // 
            this.pnlChoixCaserne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlChoixCaserne.Controls.Add(this.lblChoixCaserne);
            this.pnlChoixCaserne.Controls.Add(this.cmbChoixCaserne);
            this.pnlChoixCaserne.Location = new System.Drawing.Point(34, 55);
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
            this.lblChoixCaserne.Size = new System.Drawing.Size(177, 23);
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
            this.cmbChoixCaserne.Size = new System.Drawing.Size(639, 31);
            this.cmbChoixCaserne.TabIndex = 5;
            this.cmbChoixCaserne.SelectedIndexChanged += new System.EventHandler(this.cmbChoixCaserne_SelectedIndexChanged);
            // 
            // pnlInfosEngins
            // 
            this.pnlInfosEngins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInfosEngins.Controls.Add(this.grpEtat);
            this.pnlInfosEngins.Controls.Add(this.grpInfos);
            this.pnlInfosEngins.Controls.Add(this.pbEngin);
            this.pnlInfosEngins.Location = new System.Drawing.Point(34, 169);
            this.pnlInfosEngins.Name = "pnlInfosEngins";
            this.pnlInfosEngins.Size = new System.Drawing.Size(950, 351);
            this.pnlInfosEngins.TabIndex = 5;
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
            // lblEnMission
            // 
            this.lblEnMission.AutoSize = true;
            this.lblEnMission.Location = new System.Drawing.Point(49, 48);
            this.lblEnMission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnMission.Name = "lblEnMission";
            this.lblEnMission.Size = new System.Drawing.Size(129, 23);
            this.lblEnMission.TabIndex = 10;
            this.lblEnMission.Text = "Disponibilité : ";
            // 
            // lblEnPanne
            // 
            this.lblEnPanne.AutoSize = true;
            this.lblEnPanne.Location = new System.Drawing.Point(49, 94);
            this.lblEnPanne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnPanne.Name = "lblEnPanne";
            this.lblEnPanne.Size = new System.Drawing.Size(98, 23);
            this.lblEnPanne.TabIndex = 9;
            this.lblEnPanne.Text = "En panne : ";
            // 
            // bttnFin
            // 
            this.bttnFin.Location = new System.Drawing.Point(636, 558);
            this.bttnFin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttnFin.Name = "bttnFin";
            this.bttnFin.Size = new System.Drawing.Size(94, 30);
            this.bttnFin.TabIndex = 6;
            this.bttnFin.Text = "-->";
            this.bttnFin.UseVisualStyleBackColor = true;
            this.bttnFin.Click += new System.EventHandler(this.bttnFin_Click);
            // 
            // bttnDebut
            // 
            this.bttnDebut.Location = new System.Drawing.Point(280, 558);
            this.bttnDebut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bttnDebut.Name = "bttnDebut";
            this.bttnDebut.Size = new System.Drawing.Size(94, 30);
            this.bttnDebut.TabIndex = 7;
            this.bttnDebut.Text = "<--";
            this.bttnDebut.UseVisualStyleBackColor = true;
            this.bttnDebut.Click += new System.EventHandler(this.bttnDebut_Click);
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
            // grpEtat
            // 
            this.grpEtat.Controls.Add(this.lblEnMission);
            this.grpEtat.Controls.Add(this.lblEnPanne);
            this.grpEtat.Location = new System.Drawing.Point(41, 181);
            this.grpEtat.Name = "grpEtat";
            this.grpEtat.Size = new System.Drawing.Size(340, 142);
            this.grpEtat.TabIndex = 17;
            this.grpEtat.TabStop = false;
            this.grpEtat.Text = "Etat";
            // 
            // lblNumeroEngin
            // 
            this.lblNumeroEngin.AutoSize = true;
            this.lblNumeroEngin.Location = new System.Drawing.Point(49, 41);
            this.lblNumeroEngin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroEngin.Name = "lblNumeroEngin";
            this.lblNumeroEngin.Size = new System.Drawing.Size(91, 23);
            this.lblNumeroEngin.TabIndex = 15;
            this.lblNumeroEngin.Text = "Numéro : ";
            // 
            // lblDateRCP
            // 
            this.lblDateRCP.AutoSize = true;
            this.lblDateRCP.Location = new System.Drawing.Point(49, 83);
            this.lblDateRCP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateRCP.Name = "lblDateRCP";
            this.lblDateRCP.Size = new System.Drawing.Size(171, 23);
            this.lblDateRCP.TabIndex = 16;
            this.lblDateRCP.Text = "Date de récéption : ";
            // 
            // FormParcoursEngins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Caserne.Properties.Resources.Fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 611);
            this.Controls.Add(this.bttnDebut);
            this.Controls.Add(this.bttnFin);
            this.Controls.Add(this.pnlInfosEngins);
            this.Controls.Add(this.pnlChoixCaserne);
            this.Controls.Add(this.bttnSuivant);
            this.Controls.Add(this.bttnPrecedent);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormParcoursEngins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualisation des engins";
            this.pnlChoixCaserne.ResumeLayout(false);
            this.pnlChoixCaserne.PerformLayout();
            this.pnlInfosEngins.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEngin)).EndInit();
            this.grpInfos.ResumeLayout(false);
            this.grpInfos.PerformLayout();
            this.grpEtat.ResumeLayout(false);
            this.grpEtat.PerformLayout();
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
        private System.Windows.Forms.Label lblEnMission;
        private System.Windows.Forms.Label lblEnPanne;
        private System.Windows.Forms.Button bttnFin;
        private System.Windows.Forms.Button bttnDebut;
        private System.Windows.Forms.GroupBox grpEtat;
        private System.Windows.Forms.GroupBox grpInfos;
        private System.Windows.Forms.Label lblNumeroEngin;
        private System.Windows.Forms.Label lblDateRCP;
    }
}