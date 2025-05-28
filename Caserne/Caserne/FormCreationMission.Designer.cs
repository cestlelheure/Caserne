namespace Caserne
{
    partial class FormCreationMission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreationMission));
            this.lblNumMission = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.gpInfosUsager = new System.Windows.Forms.GroupBox();
            this.tbRueSinistre = new System.Windows.Forms.TextBox();
            this.tbCodePostalSinistre = new System.Windows.Forms.TextBox();
            this.tbVilleSinistre = new System.Windows.Forms.TextBox();
            this.tbMotifMission = new System.Windows.Forms.TextBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblVilleSinistre = new System.Windows.Forms.Label();
            this.lblAdSinistre = new System.Windows.Forms.Label();
            this.lblRueSinistre = new System.Windows.Forms.Label();
            this.lblCodePostalSinistre = new System.Windows.Forms.Label();
            this.grpDecisionRegulateur = new System.Windows.Forms.GroupBox();
            this.bttnEffacerInfos = new System.Windows.Forms.Button();
            this.bttnValiderInfos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCaserneMobiliser = new System.Windows.Forms.ComboBox();
            this.cmbNatureSinistre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bttnCréerMission = new System.Windows.Forms.Button();
            this.bttnAnnuler = new System.Windows.Forms.Button();
            this.grp = new System.Windows.Forms.GroupBox();
            this.dgvPompier = new System.Windows.Forms.DataGridView();
            this.dgvEngins = new System.Windows.Forms.DataGridView();
            this.lblPompiersMobilise = new System.Windows.Forms.Label();
            this.lblEnginMobilise = new System.Windows.Forms.Label();
            this.gpInfosUsager.SuspendLayout();
            this.grpDecisionRegulateur.SuspendLayout();
            this.grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPompier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngins)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumMission
            // 
            this.lblNumMission.AutoSize = true;
            this.lblNumMission.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblNumMission.Location = new System.Drawing.Point(329, 36);
            this.lblNumMission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumMission.Name = "lblNumMission";
            this.lblNumMission.Size = new System.Drawing.Size(96, 23);
            this.lblNumMission.TabIndex = 0;
            this.lblNumMission.Text = "Mission n°";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(569, 36);
            this.lblDateDebut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(207, 23);
            this.lblDateDebut.TabIndex = 1;
            this.lblDateDebut.Text = "Mission déclenchée le : ";
            // 
            // gpInfosUsager
            // 
            this.gpInfosUsager.Controls.Add(this.tbRueSinistre);
            this.gpInfosUsager.Controls.Add(this.tbCodePostalSinistre);
            this.gpInfosUsager.Controls.Add(this.tbVilleSinistre);
            this.gpInfosUsager.Controls.Add(this.tbMotifMission);
            this.gpInfosUsager.Controls.Add(this.lblMotif);
            this.gpInfosUsager.Controls.Add(this.lblVilleSinistre);
            this.gpInfosUsager.Controls.Add(this.lblAdSinistre);
            this.gpInfosUsager.Controls.Add(this.lblRueSinistre);
            this.gpInfosUsager.Controls.Add(this.lblCodePostalSinistre);
            this.gpInfosUsager.Location = new System.Drawing.Point(55, 80);
            this.gpInfosUsager.Margin = new System.Windows.Forms.Padding(4);
            this.gpInfosUsager.Name = "gpInfosUsager";
            this.gpInfosUsager.Padding = new System.Windows.Forms.Padding(4);
            this.gpInfosUsager.Size = new System.Drawing.Size(905, 190);
            this.gpInfosUsager.TabIndex = 12;
            this.gpInfosUsager.TabStop = false;
            this.gpInfosUsager.Text = " Informations usager ";
            // 
            // tbRueSinistre
            // 
            this.tbRueSinistre.Location = new System.Drawing.Point(608, 55);
            this.tbRueSinistre.Margin = new System.Windows.Forms.Padding(4);
            this.tbRueSinistre.Name = "tbRueSinistre";
            this.tbRueSinistre.Size = new System.Drawing.Size(232, 30);
            this.tbRueSinistre.TabIndex = 31;
            this.tbRueSinistre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRueSinistre_KeyPress);
            // 
            // tbCodePostalSinistre
            // 
            this.tbCodePostalSinistre.Location = new System.Drawing.Point(608, 95);
            this.tbCodePostalSinistre.Margin = new System.Windows.Forms.Padding(4);
            this.tbCodePostalSinistre.Name = "tbCodePostalSinistre";
            this.tbCodePostalSinistre.Size = new System.Drawing.Size(94, 30);
            this.tbCodePostalSinistre.TabIndex = 30;
            this.tbCodePostalSinistre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodePostalSinistre_KeyPress);
            // 
            // tbVilleSinistre
            // 
            this.tbVilleSinistre.Location = new System.Drawing.Point(609, 135);
            this.tbVilleSinistre.Margin = new System.Windows.Forms.Padding(4);
            this.tbVilleSinistre.Name = "tbVilleSinistre";
            this.tbVilleSinistre.Size = new System.Drawing.Size(230, 30);
            this.tbVilleSinistre.TabIndex = 29;
            this.tbVilleSinistre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbVilleSinistre_KeyPress);
            // 
            // tbMotifMission
            // 
            this.tbMotifMission.Location = new System.Drawing.Point(129, 39);
            this.tbMotifMission.Margin = new System.Windows.Forms.Padding(4);
            this.tbMotifMission.Name = "tbMotifMission";
            this.tbMotifMission.Size = new System.Drawing.Size(289, 30);
            this.tbMotifMission.TabIndex = 27;
            this.tbMotifMission.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMotifMission_KeyPress);
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(66, 42);
            this.lblMotif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(55, 23);
            this.lblMotif.TabIndex = 26;
            this.lblMotif.Text = "Motif";
            // 
            // lblVilleSinistre
            // 
            this.lblVilleSinistre.AutoSize = true;
            this.lblVilleSinistre.Location = new System.Drawing.Point(488, 139);
            this.lblVilleSinistre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVilleSinistre.Name = "lblVilleSinistre";
            this.lblVilleSinistre.Size = new System.Drawing.Size(47, 23);
            this.lblVilleSinistre.TabIndex = 28;
            this.lblVilleSinistre.Text = "Ville";
            // 
            // lblAdSinistre
            // 
            this.lblAdSinistre.AutoSize = true;
            this.lblAdSinistre.Location = new System.Drawing.Point(635, 23);
            this.lblAdSinistre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdSinistre.Name = "lblAdSinistre";
            this.lblAdSinistre.Size = new System.Drawing.Size(164, 23);
            this.lblAdSinistre.TabIndex = 24;
            this.lblAdSinistre.Text = "Adresse du sinistre";
            // 
            // lblRueSinistre
            // 
            this.lblRueSinistre.AutoSize = true;
            this.lblRueSinistre.Location = new System.Drawing.Point(488, 55);
            this.lblRueSinistre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRueSinistre.Name = "lblRueSinistre";
            this.lblRueSinistre.Size = new System.Drawing.Size(41, 23);
            this.lblRueSinistre.TabIndex = 23;
            this.lblRueSinistre.Text = "Rue";
            // 
            // lblCodePostalSinistre
            // 
            this.lblCodePostalSinistre.AutoSize = true;
            this.lblCodePostalSinistre.Location = new System.Drawing.Point(488, 99);
            this.lblCodePostalSinistre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodePostalSinistre.Name = "lblCodePostalSinistre";
            this.lblCodePostalSinistre.Size = new System.Drawing.Size(108, 23);
            this.lblCodePostalSinistre.TabIndex = 25;
            this.lblCodePostalSinistre.Text = "Code postal";
            // 
            // grpDecisionRegulateur
            // 
            this.grpDecisionRegulateur.Controls.Add(this.bttnEffacerInfos);
            this.grpDecisionRegulateur.Controls.Add(this.bttnValiderInfos);
            this.grpDecisionRegulateur.Controls.Add(this.label1);
            this.grpDecisionRegulateur.Controls.Add(this.cmbCaserneMobiliser);
            this.grpDecisionRegulateur.Controls.Add(this.cmbNatureSinistre);
            this.grpDecisionRegulateur.Controls.Add(this.label3);
            this.grpDecisionRegulateur.Location = new System.Drawing.Point(55, 279);
            this.grpDecisionRegulateur.Margin = new System.Windows.Forms.Padding(4);
            this.grpDecisionRegulateur.Name = "grpDecisionRegulateur";
            this.grpDecisionRegulateur.Padding = new System.Windows.Forms.Padding(4);
            this.grpDecisionRegulateur.Size = new System.Drawing.Size(905, 145);
            this.grpDecisionRegulateur.TabIndex = 13;
            this.grpDecisionRegulateur.TabStop = false;
            this.grpDecisionRegulateur.Text = " Décision du régulateur ";
            // 
            // bttnEffacerInfos
            // 
            this.bttnEffacerInfos.Location = new System.Drawing.Point(604, 85);
            this.bttnEffacerInfos.Name = "bttnEffacerInfos";
            this.bttnEffacerInfos.Size = new System.Drawing.Size(98, 40);
            this.bttnEffacerInfos.TabIndex = 11;
            this.bttnEffacerInfos.Text = "Effacer";
            this.bttnEffacerInfos.UseVisualStyleBackColor = true;
            this.bttnEffacerInfos.Click += new System.EventHandler(this.bttnEffacerInfos_Click);
            // 
            // bttnValiderInfos
            // 
            this.bttnValiderInfos.Location = new System.Drawing.Point(717, 85);
            this.bttnValiderInfos.Name = "bttnValiderInfos";
            this.bttnValiderInfos.Size = new System.Drawing.Size(172, 40);
            this.bttnValiderInfos.TabIndex = 10;
            this.bttnValiderInfos.Text = "Valider les infos";
            this.bttnValiderInfos.UseVisualStyleBackColor = true;
            this.bttnValiderInfos.Click += new System.EventHandler(this.bttnValiderInfos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nature du sinistre ";
            // 
            // cmbCaserneMobiliser
            // 
            this.cmbCaserneMobiliser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCaserneMobiliser.FormattingEnabled = true;
            this.cmbCaserneMobiliser.Location = new System.Drawing.Point(624, 29);
            this.cmbCaserneMobiliser.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCaserneMobiliser.Name = "cmbCaserneMobiliser";
            this.cmbCaserneMobiliser.Size = new System.Drawing.Size(265, 31);
            this.cmbCaserneMobiliser.TabIndex = 7;
            // 
            // cmbNatureSinistre
            // 
            this.cmbNatureSinistre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNatureSinistre.FormattingEnabled = true;
            this.cmbNatureSinistre.Location = new System.Drawing.Point(183, 30);
            this.cmbNatureSinistre.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNatureSinistre.Name = "cmbNatureSinistre";
            this.cmbNatureSinistre.Size = new System.Drawing.Size(265, 31);
            this.cmbNatureSinistre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Caserne à mobiliser ";
            // 
            // bttnCréerMission
            // 
            this.bttnCréerMission.Location = new System.Drawing.Point(789, 668);
            this.bttnCréerMission.Margin = new System.Windows.Forms.Padding(4);
            this.bttnCréerMission.Name = "bttnCréerMission";
            this.bttnCréerMission.Size = new System.Drawing.Size(171, 41);
            this.bttnCréerMission.TabIndex = 11;
            this.bttnCréerMission.Text = "Créer la mission";
            this.bttnCréerMission.UseVisualStyleBackColor = true;
            this.bttnCréerMission.Click += new System.EventHandler(this.bttnValider_Click);
            // 
            // bttnAnnuler
            // 
            this.bttnAnnuler.Location = new System.Drawing.Point(637, 668);
            this.bttnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.bttnAnnuler.Name = "bttnAnnuler";
            this.bttnAnnuler.Size = new System.Drawing.Size(144, 41);
            this.bttnAnnuler.TabIndex = 10;
            this.bttnAnnuler.Text = "Annuler";
            this.bttnAnnuler.UseVisualStyleBackColor = true;
            this.bttnAnnuler.Click += new System.EventHandler(this.bttnAnnuler_Click);
            // 
            // grp
            // 
            this.grp.Controls.Add(this.dgvPompier);
            this.grp.Controls.Add(this.dgvEngins);
            this.grp.Controls.Add(this.lblPompiersMobilise);
            this.grp.Controls.Add(this.lblEnginMobilise);
            this.grp.Location = new System.Drawing.Point(55, 433);
            this.grp.Margin = new System.Windows.Forms.Padding(4);
            this.grp.Name = "grp";
            this.grp.Padding = new System.Windows.Forms.Padding(4);
            this.grp.Size = new System.Drawing.Size(904, 227);
            this.grp.TabIndex = 14;
            this.grp.TabStop = false;
            this.grp.Text = " Pompiers et engins mobilisés ";
            // 
            // dgvPompier
            // 
            this.dgvPompier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPompier.Location = new System.Drawing.Point(451, 75);
            this.dgvPompier.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPompier.Name = "dgvPompier";
            this.dgvPompier.RowHeadersWidth = 51;
            this.dgvPompier.RowTemplate.Height = 24;
            this.dgvPompier.Size = new System.Drawing.Size(445, 125);
            this.dgvPompier.TabIndex = 3;
            // 
            // dgvEngins
            // 
            this.dgvEngins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEngins.Location = new System.Drawing.Point(8, 75);
            this.dgvEngins.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEngins.Name = "dgvEngins";
            this.dgvEngins.RowHeadersWidth = 51;
            this.dgvEngins.RowTemplate.Height = 24;
            this.dgvEngins.Size = new System.Drawing.Size(436, 125);
            this.dgvEngins.TabIndex = 2;
            // 
            // lblPompiersMobilise
            // 
            this.lblPompiersMobilise.AutoSize = true;
            this.lblPompiersMobilise.Location = new System.Drawing.Point(604, 47);
            this.lblPompiersMobilise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPompiersMobilise.Name = "lblPompiersMobilise";
            this.lblPompiersMobilise.Size = new System.Drawing.Size(171, 23);
            this.lblPompiersMobilise.TabIndex = 1;
            this.lblPompiersMobilise.Text = "Pompiers mobilisés";
            // 
            // lblEnginMobilise
            // 
            this.lblEnginMobilise.AutoSize = true;
            this.lblEnginMobilise.Location = new System.Drawing.Point(150, 47);
            this.lblEnginMobilise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnginMobilise.Name = "lblEnginMobilise";
            this.lblEnginMobilise.Size = new System.Drawing.Size(147, 23);
            this.lblEnginMobilise.TabIndex = 0;
            this.lblEnginMobilise.Text = "Engins mobilisés";
            // 
            // FormCreationMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Caserne.Properties.Resources.Fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1022, 722);
            this.Controls.Add(this.bttnAnnuler);
            this.Controls.Add(this.bttnCréerMission);
            this.Controls.Add(this.grp);
            this.Controls.Add(this.grpDecisionRegulateur);
            this.Controls.Add(this.gpInfosUsager);
            this.Controls.Add(this.lblDateDebut);
            this.Controls.Add(this.lblNumMission);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCreationMission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Création d\'une mission";
            this.Load += new System.EventHandler(this.FormCreationMission_Load);
            this.gpInfosUsager.ResumeLayout(false);
            this.gpInfosUsager.PerformLayout();
            this.grpDecisionRegulateur.ResumeLayout(false);
            this.grpDecisionRegulateur.PerformLayout();
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPompier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumMission;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.GroupBox gpInfosUsager;
        private System.Windows.Forms.GroupBox grpDecisionRegulateur;
        private System.Windows.Forms.TextBox tbRueSinistre;
        private System.Windows.Forms.TextBox tbCodePostalSinistre;
        private System.Windows.Forms.TextBox tbVilleSinistre;
        private System.Windows.Forms.TextBox tbMotifMission;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblVilleSinistre;
        private System.Windows.Forms.Label lblAdSinistre;
        private System.Windows.Forms.Label lblRueSinistre;
        private System.Windows.Forms.Label lblCodePostalSinistre;
        private System.Windows.Forms.Button bttnCréerMission;
        private System.Windows.Forms.Button bttnAnnuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCaserneMobiliser;
        private System.Windows.Forms.ComboBox cmbNatureSinistre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.Label lblPompiersMobilise;
        private System.Windows.Forms.Label lblEnginMobilise;
        private System.Windows.Forms.DataGridView dgvPompier;
        private System.Windows.Forms.DataGridView dgvEngins;
        private System.Windows.Forms.Button bttnEffacerInfos;
        private System.Windows.Forms.Button bttnValiderInfos;
    }
}