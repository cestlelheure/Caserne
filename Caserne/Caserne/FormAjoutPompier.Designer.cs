namespace Caserne
{
    partial class FormAjoutPompier
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
            this.lblNom = new System.Windows.Forms.Label();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtBoxPrenom = new System.Windows.Forms.TextBox();
            this.grpBoxPompier = new System.Windows.Forms.GroupBox();
            this.txtBoxGrade = new System.Windows.Forms.TextBox();
            this.cblHabilitations = new System.Windows.Forms.CheckedListBox();
            this.lblHabilitations = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.cboMois = new System.Windows.Forms.ComboBox();
            this.cboJours = new System.Windows.Forms.ComboBox();
            this.cboAnnee = new System.Windows.Forms.ComboBox();
            this.lblBD = new System.Windows.Forms.Label();
            this.txtBoxBip = new System.Windows.Forms.TextBox();
            this.lblBip = new System.Windows.Forms.Label();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.grpBoxSituation = new System.Windows.Forms.GroupBox();
            this.rdbVolontaire = new System.Windows.Forms.RadioButton();
            this.rdbProfessionnel = new System.Windows.Forms.RadioButton();
            this.txtBoxTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.grpBoxSexe = new System.Windows.Forms.GroupBox();
            this.rdbMasculin = new System.Windows.Forms.RadioButton();
            this.rdbFeminin = new System.Windows.Forms.RadioButton();
            this.grpBoxPompier.SuspendLayout();
            this.grpBoxSituation.SuspendLayout();
            this.grpBoxSexe.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(76, 193);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(51, 19);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom : ";
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(165, 190);
            this.txtBoxNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(132, 24);
            this.txtBoxNom.TabIndex = 2;
            this.txtBoxNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNom_KeyPress);
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(373, 193);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(68, 19);
            this.lblPrenom.TabIndex = 3;
            this.lblPrenom.Text = "Prénom : ";
            // 
            // txtBoxPrenom
            // 
            this.txtBoxPrenom.Location = new System.Drawing.Point(462, 190);
            this.txtBoxPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPrenom.Name = "txtBoxPrenom";
            this.txtBoxPrenom.Size = new System.Drawing.Size(132, 24);
            this.txtBoxPrenom.TabIndex = 3;
            this.txtBoxPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPrenom_KeyPress);
            // 
            // grpBoxPompier
            // 
            this.grpBoxPompier.Controls.Add(this.txtBoxGrade);
            this.grpBoxPompier.Controls.Add(this.cblHabilitations);
            this.grpBoxPompier.Controls.Add(this.lblHabilitations);
            this.grpBoxPompier.Controls.Add(this.btnAjouter);
            this.grpBoxPompier.Controls.Add(this.cboMois);
            this.grpBoxPompier.Controls.Add(this.cboJours);
            this.grpBoxPompier.Controls.Add(this.cboAnnee);
            this.grpBoxPompier.Controls.Add(this.lblBD);
            this.grpBoxPompier.Controls.Add(this.txtBoxBip);
            this.grpBoxPompier.Controls.Add(this.lblBip);
            this.grpBoxPompier.Controls.Add(this.lblCaserne);
            this.grpBoxPompier.Controls.Add(this.cboCaserne);
            this.grpBoxPompier.Controls.Add(this.cboGrade);
            this.grpBoxPompier.Controls.Add(this.lblGrade);
            this.grpBoxPompier.Controls.Add(this.lblMatricule);
            this.grpBoxPompier.Controls.Add(this.grpBoxSituation);
            this.grpBoxPompier.Controls.Add(this.txtBoxTel);
            this.grpBoxPompier.Controls.Add(this.lblTel);
            this.grpBoxPompier.Controls.Add(this.grpBoxSexe);
            this.grpBoxPompier.Controls.Add(this.lblNom);
            this.grpBoxPompier.Controls.Add(this.txtBoxPrenom);
            this.grpBoxPompier.Controls.Add(this.txtBoxNom);
            this.grpBoxPompier.Controls.Add(this.lblPrenom);
            this.grpBoxPompier.Location = new System.Drawing.Point(116, 13);
            this.grpBoxPompier.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxPompier.Name = "grpBoxPompier";
            this.grpBoxPompier.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxPompier.Size = new System.Drawing.Size(720, 812);
            this.grpBoxPompier.TabIndex = 5;
            this.grpBoxPompier.TabStop = false;
            // 
            // txtBoxGrade
            // 
            this.txtBoxGrade.Enabled = false;
            this.txtBoxGrade.Location = new System.Drawing.Point(257, 505);
            this.txtBoxGrade.Name = "txtBoxGrade";
            this.txtBoxGrade.Size = new System.Drawing.Size(74, 24);
            this.txtBoxGrade.TabIndex = 27;
            // 
            // cblHabilitations
            // 
            this.cblHabilitations.FormattingEnabled = true;
            this.cblHabilitations.Location = new System.Drawing.Point(90, 567);
            this.cblHabilitations.Name = "cblHabilitations";
            this.cblHabilitations.Size = new System.Drawing.Size(504, 137);
            this.cblHabilitations.TabIndex = 26;
            // 
            // lblHabilitations
            // 
            this.lblHabilitations.AutoSize = true;
            this.lblHabilitations.Location = new System.Drawing.Point(105, 545);
            this.lblHabilitations.Name = "lblHabilitations";
            this.lblHabilitations.Size = new System.Drawing.Size(100, 19);
            this.lblHabilitations.TabIndex = 25;
            this.lblHabilitations.Text = "Habilatations : ";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.IndianRed;
            this.btnAjouter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAjouter.Location = new System.Drawing.Point(474, 727);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(229, 68);
            this.btnAjouter.TabIndex = 15;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // cboMois
            // 
            this.cboMois.FormattingEnabled = true;
            this.cboMois.Location = new System.Drawing.Point(317, 306);
            this.cboMois.Name = "cboMois";
            this.cboMois.Size = new System.Drawing.Size(54, 27);
            this.cboMois.TabIndex = 7;
            this.cboMois.Text = "Mois";
            this.cboMois.SelectedIndexChanged += new System.EventHandler(this.cboMois_SelectedIndexChanged);
            // 
            // cboJours
            // 
            this.cboJours.FormattingEnabled = true;
            this.cboJours.Location = new System.Drawing.Point(257, 306);
            this.cboJours.Name = "cboJours";
            this.cboJours.Size = new System.Drawing.Size(54, 27);
            this.cboJours.TabIndex = 6;
            this.cboJours.Text = "Jour";
            // 
            // cboAnnee
            // 
            this.cboAnnee.FormattingEnabled = true;
            this.cboAnnee.Location = new System.Drawing.Point(377, 306);
            this.cboAnnee.Name = "cboAnnee";
            this.cboAnnee.Size = new System.Drawing.Size(85, 27);
            this.cboAnnee.TabIndex = 8;
            this.cboAnnee.Text = "Année";
            this.cboAnnee.SelectedIndexChanged += new System.EventHandler(this.cboAnnee_SelectedIndexChanged);
            // 
            // lblBD
            // 
            this.lblBD.AutoSize = true;
            this.lblBD.Location = new System.Drawing.Point(117, 309);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(131, 19);
            this.lblBD.TabIndex = 19;
            this.lblBD.Text = "Date de naissance : ";
            // 
            // txtBoxBip
            // 
            this.txtBoxBip.Location = new System.Drawing.Point(462, 253);
            this.txtBoxBip.Name = "txtBoxBip";
            this.txtBoxBip.Size = new System.Drawing.Size(132, 24);
            this.txtBoxBip.TabIndex = 5;
            this.txtBoxBip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxBip_KeyPress);
            // 
            // lblBip
            // 
            this.lblBip.AutoSize = true;
            this.lblBip.Location = new System.Drawing.Point(373, 256);
            this.lblBip.Name = "lblBip";
            this.lblBip.Size = new System.Drawing.Size(39, 19);
            this.lblBip.TabIndex = 17;
            this.lblBip.Text = "Bip : ";
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Location = new System.Drawing.Point(135, 122);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(170, 19);
            this.lblCaserne.TabIndex = 16;
            this.lblCaserne.Text = "Caserne de ratachement : ";
            // 
            // cboCaserne
            // 
            this.cboCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(311, 119);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(175, 27);
            this.cboCaserne.TabIndex = 1;
            // 
            // cboGrade
            // 
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(344, 502);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(174, 27);
            this.cboGrade.TabIndex = 13;
            this.cboGrade.SelectedIndexChanged += new System.EventHandler(this.cboGrade_SelectedIndexChanged);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(191, 508);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(57, 19);
            this.lblGrade.TabIndex = 13;
            this.lblGrade.Text = "Grade : ";
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricule.Location = new System.Drawing.Point(230, 44);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(141, 31);
            this.lblMatricule.TabIndex = 12;
            this.lblMatricule.Text = "Matricule : ";
            // 
            // grpBoxSituation
            // 
            this.grpBoxSituation.Controls.Add(this.rdbVolontaire);
            this.grpBoxSituation.Controls.Add(this.rdbProfessionnel);
            this.grpBoxSituation.Location = new System.Drawing.Point(90, 426);
            this.grpBoxSituation.Name = "grpBoxSituation";
            this.grpBoxSituation.Size = new System.Drawing.Size(504, 56);
            this.grpBoxSituation.TabIndex = 11;
            this.grpBoxSituation.TabStop = false;
            this.grpBoxSituation.Text = "Situation : ";
            // 
            // rdbVolontaire
            // 
            this.rdbVolontaire.AutoSize = true;
            this.rdbVolontaire.Location = new System.Drawing.Point(272, 24);
            this.rdbVolontaire.Name = "rdbVolontaire";
            this.rdbVolontaire.Size = new System.Drawing.Size(90, 23);
            this.rdbVolontaire.TabIndex = 12;
            this.rdbVolontaire.TabStop = true;
            this.rdbVolontaire.Text = "Volontaire";
            this.rdbVolontaire.UseVisualStyleBackColor = true;
            // 
            // rdbProfessionnel
            // 
            this.rdbProfessionnel.AutoSize = true;
            this.rdbProfessionnel.Location = new System.Drawing.Point(49, 24);
            this.rdbProfessionnel.Name = "rdbProfessionnel";
            this.rdbProfessionnel.Size = new System.Drawing.Size(109, 23);
            this.rdbProfessionnel.TabIndex = 11;
            this.rdbProfessionnel.TabStop = true;
            this.rdbProfessionnel.Text = "Professionnel";
            this.rdbProfessionnel.UseVisualStyleBackColor = true;
            // 
            // txtBoxTel
            // 
            this.txtBoxTel.Location = new System.Drawing.Point(165, 253);
            this.txtBoxTel.Name = "txtBoxTel";
            this.txtBoxTel.Size = new System.Drawing.Size(132, 24);
            this.txtBoxTel.TabIndex = 4;
            this.txtBoxTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxTel_KeyPress);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(76, 256);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(79, 19);
            this.lblTel.TabIndex = 9;
            this.lblTel.Text = "Téléphone :";
            // 
            // grpBoxSexe
            // 
            this.grpBoxSexe.Controls.Add(this.rdbMasculin);
            this.grpBoxSexe.Controls.Add(this.rdbFeminin);
            this.grpBoxSexe.Location = new System.Drawing.Point(90, 344);
            this.grpBoxSexe.Name = "grpBoxSexe";
            this.grpBoxSexe.Size = new System.Drawing.Size(504, 56);
            this.grpBoxSexe.TabIndex = 8;
            this.grpBoxSexe.TabStop = false;
            this.grpBoxSexe.Text = "Sexe : ";
            // 
            // rdbMasculin
            // 
            this.rdbMasculin.AutoSize = true;
            this.rdbMasculin.Location = new System.Drawing.Point(49, 23);
            this.rdbMasculin.Name = "rdbMasculin";
            this.rdbMasculin.Size = new System.Drawing.Size(82, 23);
            this.rdbMasculin.TabIndex = 9;
            this.rdbMasculin.TabStop = true;
            this.rdbMasculin.Text = "Masculin";
            this.rdbMasculin.UseVisualStyleBackColor = true;
            // 
            // rdbFeminin
            // 
            this.rdbFeminin.AutoSize = true;
            this.rdbFeminin.Location = new System.Drawing.Point(272, 23);
            this.rdbFeminin.Name = "rdbFeminin";
            this.rdbFeminin.Size = new System.Drawing.Size(75, 23);
            this.rdbFeminin.TabIndex = 10;
            this.rdbFeminin.TabStop = true;
            this.rdbFeminin.Text = "Féminin";
            this.rdbFeminin.UseVisualStyleBackColor = true;
            // 
            // FormAjoutPompier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 845);
            this.Controls.Add(this.grpBoxPompier);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormAjoutPompier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout d\'un pompier";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAjoutPompier_Load);
            this.grpBoxPompier.ResumeLayout(false);
            this.grpBoxPompier.PerformLayout();
            this.grpBoxSituation.ResumeLayout(false);
            this.grpBoxSituation.PerformLayout();
            this.grpBoxSexe.ResumeLayout(false);
            this.grpBoxSexe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtBoxPrenom;
        private System.Windows.Forms.GroupBox grpBoxPompier;
        private System.Windows.Forms.GroupBox grpBoxSituation;
        private System.Windows.Forms.RadioButton rdbVolontaire;
        private System.Windows.Forms.RadioButton rdbProfessionnel;
        private System.Windows.Forms.TextBox txtBoxTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.GroupBox grpBoxSexe;
        private System.Windows.Forms.RadioButton rdbMasculin;
        private System.Windows.Forms.RadioButton rdbFeminin;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.TextBox txtBoxBip;
        private System.Windows.Forms.Label lblBip;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.ComboBox cboMois;
        private System.Windows.Forms.ComboBox cboJours;
        private System.Windows.Forms.ComboBox cboAnnee;
        private System.Windows.Forms.Label lblBD;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblHabilitations;
        private System.Windows.Forms.CheckedListBox cblHabilitations;
        private System.Windows.Forms.TextBox txtBoxGrade;
    }
}