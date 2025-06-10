namespace Caserne
{
    partial class FormStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStats));
            this.cboChoixCaserne = new System.Windows.Forms.ComboBox();
            this.lblChoixCaserne = new System.Windows.Forms.Label();
            this.lblHeuresUtilisations = new System.Windows.Forms.Label();
            this.lblEnginsPlusUtilise = new System.Windows.Forms.Label();
            this.lblStatsToutesCasernes = new System.Windows.Forms.Label();
            this.lblListePompierPArHabilitation = new System.Windows.Forms.Label();
            this.lblHabiPlusSolicite = new System.Windows.Forms.Label();
            this.lblNbInterventionParSinistre = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelCaserne = new System.Windows.Forms.Panel();
            this.panelGlobal = new System.Windows.Forms.Panel();
            this.bttnQuitter = new System.Windows.Forms.Button();
            this.panelCaserne.SuspendLayout();
            this.panelGlobal.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboChoixCaserne
            // 
            this.cboChoixCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChoixCaserne.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChoixCaserne.FormattingEnabled = true;
            this.cboChoixCaserne.Location = new System.Drawing.Point(459, 39);
            this.cboChoixCaserne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboChoixCaserne.Name = "cboChoixCaserne";
            this.cboChoixCaserne.Size = new System.Drawing.Size(276, 31);
            this.cboChoixCaserne.TabIndex = 0;
            // 
            // lblChoixCaserne
            // 
            this.lblChoixCaserne.AutoSize = true;
            this.lblChoixCaserne.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoixCaserne.Location = new System.Drawing.Point(33, 39);
            this.lblChoixCaserne.Name = "lblChoixCaserne";
            this.lblChoixCaserne.Size = new System.Drawing.Size(420, 27);
            this.lblChoixCaserne.TabIndex = 1;
            this.lblChoixCaserne.Text = "Choix de la caserne pour ses statistiques";
            // 
            // lblHeuresUtilisations
            // 
            this.lblHeuresUtilisations.AutoSize = true;
            this.lblHeuresUtilisations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeuresUtilisations.Location = new System.Drawing.Point(556, 24);
            this.lblHeuresUtilisations.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblHeuresUtilisations.Name = "lblHeuresUtilisations";
            this.lblHeuresUtilisations.Size = new System.Drawing.Size(308, 17);
            this.lblHeuresUtilisations.TabIndex = 2;
            this.lblHeuresUtilisations.Text = "Total d\'heures d\'utilisation pour chaque engin : ";
            // 
            // lblEnginsPlusUtilise
            // 
            this.lblEnginsPlusUtilise.AutoSize = true;
            this.lblEnginsPlusUtilise.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnginsPlusUtilise.Location = new System.Drawing.Point(14, 24);
            this.lblEnginsPlusUtilise.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblEnginsPlusUtilise.Name = "lblEnginsPlusUtilise";
            this.lblEnginsPlusUtilise.Size = new System.Drawing.Size(162, 17);
            this.lblEnginsPlusUtilise.TabIndex = 3;
            this.lblEnginsPlusUtilise.Text = "Engins les plus utilisés : ";
            // 
            // lblStatsToutesCasernes
            // 
            this.lblStatsToutesCasernes.AutoSize = true;
            this.lblStatsToutesCasernes.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatsToutesCasernes.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblStatsToutesCasernes.Location = new System.Drawing.Point(33, 314);
            this.lblStatsToutesCasernes.Name = "lblStatsToutesCasernes";
            this.lblStatsToutesCasernes.Size = new System.Drawing.Size(411, 27);
            this.lblStatsToutesCasernes.TabIndex = 4;
            this.lblStatsToutesCasernes.Text = "Statistiques de l\'ensemble des casernes";
            // 
            // lblListePompierPArHabilitation
            // 
            this.lblListePompierPArHabilitation.AutoSize = true;
            this.lblListePompierPArHabilitation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListePompierPArHabilitation.Location = new System.Drawing.Point(377, 12);
            this.lblListePompierPArHabilitation.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblListePompierPArHabilitation.Name = "lblListePompierPArHabilitation";
            this.lblListePompierPArHabilitation.Size = new System.Drawing.Size(224, 17);
            this.lblListePompierPArHabilitation.TabIndex = 5;
            this.lblListePompierPArHabilitation.Text = "Liste des pompiers par habilitation";
            // 
            // lblHabiPlusSolicite
            // 
            this.lblHabiPlusSolicite.AutoSize = true;
            this.lblHabiPlusSolicite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabiPlusSolicite.Location = new System.Drawing.Point(749, 12);
            this.lblHabiPlusSolicite.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblHabiPlusSolicite.Name = "lblHabiPlusSolicite";
            this.lblHabiPlusSolicite.Size = new System.Drawing.Size(202, 17);
            this.lblHabiPlusSolicite.TabIndex = 10;
            this.lblHabiPlusSolicite.Text = "Habilitations les plus sollicitées";
            // 
            // lblNbInterventionParSinistre
            // 
            this.lblNbInterventionParSinistre.AutoSize = true;
            this.lblNbInterventionParSinistre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbInterventionParSinistre.Location = new System.Drawing.Point(15, 12);
            this.lblNbInterventionParSinistre.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblNbInterventionParSinistre.Name = "lblNbInterventionParSinistre";
            this.lblNbInterventionParSinistre.Size = new System.Drawing.Size(291, 17);
            this.lblNbInterventionParSinistre.TabIndex = 11;
            this.lblNbInterventionParSinistre.Text = "Nombre d\'interventions par type de sinistre : ";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(892, 37);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 33);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Actualiser";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panelCaserne
            // 
            this.panelCaserne.BackColor = System.Drawing.Color.LightGray;
            this.panelCaserne.Controls.Add(this.lblHeuresUtilisations);
            this.panelCaserne.Controls.Add(this.lblEnginsPlusUtilise);
            this.panelCaserne.Location = new System.Drawing.Point(20, 83);
            this.panelCaserne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelCaserne.Name = "panelCaserne";
            this.panelCaserne.Size = new System.Drawing.Size(1078, 210);
            this.panelCaserne.TabIndex = 13;
            // 
            // panelGlobal
            // 
            this.panelGlobal.BackColor = System.Drawing.Color.LightBlue;
            this.panelGlobal.Controls.Add(this.lblHabiPlusSolicite);
            this.panelGlobal.Controls.Add(this.lblNbInterventionParSinistre);
            this.panelGlobal.Controls.Add(this.lblListePompierPArHabilitation);
            this.panelGlobal.Location = new System.Drawing.Point(20, 354);
            this.panelGlobal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelGlobal.Name = "panelGlobal";
            this.panelGlobal.Size = new System.Drawing.Size(1078, 310);
            this.panelGlobal.TabIndex = 14;
            // 
            // bttnQuitter
            // 
            this.bttnQuitter.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnQuitter.Location = new System.Drawing.Point(998, 37);
            this.bttnQuitter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttnQuitter.Name = "bttnQuitter";
            this.bttnQuitter.Size = new System.Drawing.Size(100, 33);
            this.bttnQuitter.TabIndex = 15;
            this.bttnQuitter.Text = "Quitter";
            this.bttnQuitter.UseVisualStyleBackColor = true;
            this.bttnQuitter.Click += new System.EventHandler(this.bttnQuitter_Click);
            // 
            // FormStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 680);
            this.Controls.Add(this.bttnQuitter);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblStatsToutesCasernes);
            this.Controls.Add(this.lblChoixCaserne);
            this.Controls.Add(this.cboChoixCaserne);
            this.Controls.Add(this.panelCaserne);
            this.Controls.Add(this.panelGlobal);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistiques pour le régulateur";
            this.panelCaserne.ResumeLayout(false);
            this.panelCaserne.PerformLayout();
            this.panelGlobal.ResumeLayout(false);
            this.panelGlobal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboChoixCaserne;
        private System.Windows.Forms.Label lblChoixCaserne;
        private System.Windows.Forms.Label lblHeuresUtilisations;
        private System.Windows.Forms.Label lblEnginsPlusUtilise;
        private System.Windows.Forms.Label lblStatsToutesCasernes;
        private System.Windows.Forms.Label lblListePompierPArHabilitation;
        private System.Windows.Forms.Label lblHabiPlusSolicite;
        private System.Windows.Forms.Label lblNbInterventionParSinistre;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panelCaserne;
        private System.Windows.Forms.Panel panelGlobal;

        // Gestionnaire d'événement pour le bouton Actualiser
        private void btnRefresh_Click(object sender, System.EventArgs e)
        {
            RefreshStats();
        }

        private System.Windows.Forms.Button bttnQuitter;
    }
}