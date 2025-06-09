namespace Caserne
{
    partial class FormGestionPompier
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionPompier));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblSexe = new System.Windows.Forms.Label();
            this.lblBD = new System.Windows.Forms.Label();
            this.grpBoxInfoPompier = new System.Windows.Forms.GroupBox();
            this.grpBoxCarriere = new System.Windows.Forms.GroupBox();
            this.lblBip = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.btnChanger = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.txtBoxGrade = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblED = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdbVolontaire = new System.Windows.Forms.RadioButton();
            this.rdbProfessionnel = new System.Windows.Forms.RadioButton();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.btnVeuillez = new System.Windows.Forms.Button();
            this.btnAfficherPlus = new System.Windows.Forms.Button();
            this.grpBoxInfoCarriere = new System.Windows.Forms.GroupBox();
            this.grpBoxCarriere2 = new System.Windows.Forms.GroupBox();
            this.clbHabilitations = new System.Windows.Forms.CheckedListBox();
            this.lstBoxAffectations = new System.Windows.Forms.ListBox();
            this.lblAffectations = new System.Windows.Forms.Label();
            this.lblHabilitations = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.cBoxConge = new System.Windows.Forms.CheckBox();
            this.btnMaj = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnAfficherMoins = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuPanel1 = new Caserne.MenuPanel();
            this.grpBoxInfoPompier.SuspendLayout();
            this.grpBoxCarriere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBoxInfoCarriere.SuspendLayout();
            this.grpBoxCarriere2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(424, 197);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 27);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(424, 266);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(196, 27);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(18, 61);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(51, 19);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom : ";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(18, 94);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(68, 19);
            this.lblPrenom.TabIndex = 3;
            this.lblPrenom.Text = "Prénom : ";
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Location = new System.Drawing.Point(18, 124);
            this.lblSexe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(49, 19);
            this.lblSexe.TabIndex = 4;
            this.lblSexe.Text = "Sexe : ";
            // 
            // lblBD
            // 
            this.lblBD.AutoSize = true;
            this.lblBD.Location = new System.Drawing.Point(18, 155);
            this.lblBD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(131, 19);
            this.lblBD.TabIndex = 5;
            this.lblBD.Text = "Date de naissance : ";
            // 
            // grpBoxInfoPompier
            // 
            this.grpBoxInfoPompier.Controls.Add(this.grpBoxCarriere);
            this.grpBoxInfoPompier.Controls.Add(this.lblED);
            this.grpBoxInfoPompier.Controls.Add(this.pictureBox1);
            this.grpBoxInfoPompier.Controls.Add(this.rdbVolontaire);
            this.grpBoxInfoPompier.Controls.Add(this.rdbProfessionnel);
            this.grpBoxInfoPompier.Controls.Add(this.lblMatricule);
            this.grpBoxInfoPompier.Controls.Add(this.lblNom);
            this.grpBoxInfoPompier.Controls.Add(this.lblBD);
            this.grpBoxInfoPompier.Controls.Add(this.lblSexe);
            this.grpBoxInfoPompier.Controls.Add(this.lblPrenom);
            this.grpBoxInfoPompier.Location = new System.Drawing.Point(664, 23);
            this.grpBoxInfoPompier.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxInfoPompier.Name = "grpBoxInfoPompier";
            this.grpBoxInfoPompier.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxInfoPompier.Size = new System.Drawing.Size(592, 379);
            this.grpBoxInfoPompier.TabIndex = 6;
            this.grpBoxInfoPompier.TabStop = false;
            this.grpBoxInfoPompier.Visible = false;
            // 
            // grpBoxCarriere
            // 
            this.grpBoxCarriere.Controls.Add(this.lblBip);
            this.grpBoxCarriere.Controls.Add(this.lblTel);
            this.grpBoxCarriere.Controls.Add(this.btnChanger);
            this.grpBoxCarriere.Controls.Add(this.comboBox3);
            this.grpBoxCarriere.Controls.Add(this.txtBoxGrade);
            this.grpBoxCarriere.Controls.Add(this.lblGrade);
            this.grpBoxCarriere.Location = new System.Drawing.Point(61, 261);
            this.grpBoxCarriere.Name = "grpBoxCarriere";
            this.grpBoxCarriere.Size = new System.Drawing.Size(479, 100);
            this.grpBoxCarriere.TabIndex = 11;
            this.grpBoxCarriere.TabStop = false;
            this.grpBoxCarriere.Text = "Carrière";
            // 
            // lblBip
            // 
            this.lblBip.AutoSize = true;
            this.lblBip.Location = new System.Drawing.Point(220, 65);
            this.lblBip.Name = "lblBip";
            this.lblBip.Size = new System.Drawing.Size(39, 19);
            this.lblBip.TabIndex = 5;
            this.lblBip.Text = "Bip : ";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(22, 65);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(83, 19);
            this.lblTel.TabIndex = 4;
            this.lblTel.Text = "Téléphone : ";
            // 
            // btnChanger
            // 
            this.btnChanger.Location = new System.Drawing.Point(364, 24);
            this.btnChanger.Name = "btnChanger";
            this.btnChanger.Size = new System.Drawing.Size(85, 27);
            this.btnChanger.TabIndex = 3;
            this.btnChanger.Text = "Changer";
            this.btnChanger.UseVisualStyleBackColor = true;
            this.btnChanger.Visible = false;
            this.btnChanger.Click += new System.EventHandler(this.btnChanger_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(169, 24);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(176, 27);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // txtBoxGrade
            // 
            this.txtBoxGrade.Enabled = false;
            this.txtBoxGrade.Location = new System.Drawing.Point(74, 27);
            this.txtBoxGrade.Name = "txtBoxGrade";
            this.txtBoxGrade.Size = new System.Drawing.Size(75, 24);
            this.txtBoxGrade.TabIndex = 1;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(22, 30);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(53, 19);
            this.lblGrade.TabIndex = 0;
            this.lblGrade.Text = "Grade :";
            // 
            // lblED
            // 
            this.lblED.AutoSize = true;
            this.lblED.Location = new System.Drawing.Point(18, 229);
            this.lblED.Name = "lblED";
            this.lblED.Size = new System.Drawing.Size(128, 19);
            this.lblED.TabIndex = 10;
            this.lblED.Text = "Date d\'embauche : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(425, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 104);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // rdbVolontaire
            // 
            this.rdbVolontaire.AutoSize = true;
            this.rdbVolontaire.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbVolontaire.Location = new System.Drawing.Point(343, 190);
            this.rdbVolontaire.Name = "rdbVolontaire";
            this.rdbVolontaire.Size = new System.Drawing.Size(90, 23);
            this.rdbVolontaire.TabIndex = 8;
            this.rdbVolontaire.TabStop = true;
            this.rdbVolontaire.Text = "Volontaire";
            this.rdbVolontaire.UseVisualStyleBackColor = true;
            // 
            // rdbProfessionnel
            // 
            this.rdbProfessionnel.AutoSize = true;
            this.rdbProfessionnel.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbProfessionnel.Location = new System.Drawing.Point(101, 190);
            this.rdbProfessionnel.Name = "rdbProfessionnel";
            this.rdbProfessionnel.Size = new System.Drawing.Size(109, 23);
            this.rdbProfessionnel.TabIndex = 7;
            this.rdbProfessionnel.TabStop = true;
            this.rdbProfessionnel.Text = "Professionnel";
            this.rdbProfessionnel.UseVisualStyleBackColor = true;
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricule.Location = new System.Drawing.Point(178, 21);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(115, 28);
            this.lblMatricule.TabIndex = 6;
            this.lblMatricule.Text = "Matricule ";
            // 
            // btnVeuillez
            // 
            this.btnVeuillez.BackColor = System.Drawing.Color.IndianRed;
            this.btnVeuillez.Enabled = false;
            this.btnVeuillez.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeuillez.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVeuillez.Location = new System.Drawing.Point(664, 23);
            this.btnVeuillez.Name = "btnVeuillez";
            this.btnVeuillez.Size = new System.Drawing.Size(592, 750);
            this.btnVeuillez.TabIndex = 16;
            this.btnVeuillez.Text = "Veuillez séléctionner une caserne et un pompier.";
            this.btnVeuillez.UseVisualStyleBackColor = false;
            // 
            // btnAfficherPlus
            // 
            this.btnAfficherPlus.Location = new System.Drawing.Point(1098, 409);
            this.btnAfficherPlus.Name = "btnAfficherPlus";
            this.btnAfficherPlus.Size = new System.Drawing.Size(158, 36);
            this.btnAfficherPlus.TabIndex = 7;
            this.btnAfficherPlus.Text = "Afficher plus ...";
            this.btnAfficherPlus.UseVisualStyleBackColor = true;
            this.btnAfficherPlus.Visible = false;
            this.btnAfficherPlus.Click += new System.EventHandler(this.btnAfficherPlus_Click);
            // 
            // grpBoxInfoCarriere
            // 
            this.grpBoxInfoCarriere.Controls.Add(this.grpBoxCarriere2);
            this.grpBoxInfoCarriere.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grpBoxInfoCarriere.Location = new System.Drawing.Point(664, 446);
            this.grpBoxInfoCarriere.Name = "grpBoxInfoCarriere";
            this.grpBoxInfoCarriere.Size = new System.Drawing.Size(592, 339);
            this.grpBoxInfoCarriere.TabIndex = 8;
            this.grpBoxInfoCarriere.TabStop = false;
            this.grpBoxInfoCarriere.Visible = false;
            // 
            // grpBoxCarriere2
            // 
            this.grpBoxCarriere2.Controls.Add(this.clbHabilitations);
            this.grpBoxCarriere2.Controls.Add(this.lstBoxAffectations);
            this.grpBoxCarriere2.Controls.Add(this.lblAffectations);
            this.grpBoxCarriere2.Controls.Add(this.lblHabilitations);
            this.grpBoxCarriere2.Controls.Add(this.comboBox4);
            this.grpBoxCarriere2.Controls.Add(this.lblCaserne);
            this.grpBoxCarriere2.Controls.Add(this.cBoxConge);
            this.grpBoxCarriere2.Controls.Add(this.btnMaj);
            this.grpBoxCarriere2.Location = new System.Drawing.Point(6, 10);
            this.grpBoxCarriere2.Name = "grpBoxCarriere2";
            this.grpBoxCarriere2.Size = new System.Drawing.Size(580, 323);
            this.grpBoxCarriere2.TabIndex = 0;
            this.grpBoxCarriere2.TabStop = false;
            this.grpBoxCarriere2.Text = "Informations carrière";
            // 
            // clbHabilitations
            // 
            this.clbHabilitations.FormattingEnabled = true;
            this.clbHabilitations.Location = new System.Drawing.Point(55, 85);
            this.clbHabilitations.Name = "clbHabilitations";
            this.clbHabilitations.Size = new System.Drawing.Size(449, 118);
            this.clbHabilitations.TabIndex = 16;
            // 
            // lstBoxAffectations
            // 
            this.lstBoxAffectations.FormattingEnabled = true;
            this.lstBoxAffectations.ItemHeight = 19;
            this.lstBoxAffectations.Location = new System.Drawing.Point(55, 229);
            this.lstBoxAffectations.Name = "lstBoxAffectations";
            this.lstBoxAffectations.Size = new System.Drawing.Size(449, 42);
            this.lstBoxAffectations.TabIndex = 7;
            // 
            // lblAffectations
            // 
            this.lblAffectations.AutoSize = true;
            this.lblAffectations.Location = new System.Drawing.Point(51, 207);
            this.lblAffectations.Name = "lblAffectations";
            this.lblAffectations.Size = new System.Drawing.Size(142, 19);
            this.lblAffectations.TabIndex = 6;
            this.lblAffectations.Text = "Affectations passées :";
            // 
            // lblHabilitations
            // 
            this.lblHabilitations.AutoSize = true;
            this.lblHabilitations.Location = new System.Drawing.Point(51, 63);
            this.lblHabilitations.Name = "lblHabilitations";
            this.lblHabilitations.Size = new System.Drawing.Size(92, 19);
            this.lblHabilitations.TabIndex = 4;
            this.lblHabilitations.Text = "Habilitations :";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(240, 30);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(264, 27);
            this.comboBox4.TabIndex = 3;
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Location = new System.Drawing.Point(51, 33);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(171, 19);
            this.lblCaserne.TabIndex = 2;
            this.lblCaserne.Text = "Caserne de rattachement :";
            // 
            // cBoxConge
            // 
            this.cBoxConge.AutoSize = true;
            this.cBoxConge.Location = new System.Drawing.Point(38, 282);
            this.cBoxConge.Name = "cBoxConge";
            this.cBoxConge.Size = new System.Drawing.Size(85, 23);
            this.cBoxConge.TabIndex = 1;
            this.cBoxConge.Text = "En congé";
            this.cBoxConge.UseVisualStyleBackColor = true;
            // 
            // btnMaj
            // 
            this.btnMaj.Location = new System.Drawing.Point(419, 282);
            this.btnMaj.Name = "btnMaj";
            this.btnMaj.Size = new System.Drawing.Size(145, 26);
            this.btnMaj.TabIndex = 0;
            this.btnMaj.Text = "Mettre à jour";
            this.btnMaj.UseVisualStyleBackColor = true;
            this.btnMaj.Click += new System.EventHandler(this.btnMaj_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.BackColor = System.Drawing.Color.IndianRed;
            this.btnNouveau.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNouveau.Image = ((System.Drawing.Image)(resources.GetObject("btnNouveau.Image")));
            this.btnNouveau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNouveau.Location = new System.Drawing.Point(354, 454);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(265, 84);
            this.btnNouveau.TabIndex = 4;
            this.btnNouveau.Text = "Ajouter un pompier";
            this.btnNouveau.UseVisualStyleBackColor = false;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(355, 317);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(265, 85);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "S\'identifier";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnAfficherMoins
            // 
            this.btnAfficherMoins.Location = new System.Drawing.Point(1098, 409);
            this.btnAfficherMoins.Name = "btnAfficherMoins";
            this.btnAfficherMoins.Size = new System.Drawing.Size(158, 36);
            this.btnAfficherMoins.TabIndex = 13;
            this.btnAfficherMoins.Text = "Afficher moins";
            this.btnAfficherMoins.UseVisualStyleBackColor = true;
            this.btnAfficherMoins.Visible = false;
            this.btnAfficherMoins.Click += new System.EventHandler(this.btnAfficherMoins_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(407, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 143);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Caserne : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Pompier :";
            // 
            // menuPanel1
            // 
            this.menuPanel1.BackColor = System.Drawing.Color.IndianRed;
            this.menuPanel1.Location = new System.Drawing.Point(-1, 0);
            this.menuPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.menuPanel1.Name = "menuPanel1";
            this.menuPanel1.Size = new System.Drawing.Size(326, 797);
            this.menuPanel1.TabIndex = 17;
            // 
            // FormGestionPompier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1287, 798);
            this.Controls.Add(this.menuPanel1);
            this.Controls.Add(this.btnVeuillez);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAfficherMoins);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.grpBoxInfoCarriere);
            this.Controls.Add(this.btnAfficherPlus);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.grpBoxInfoPompier);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormGestionPompier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion du personnel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxInfoPompier.ResumeLayout(false);
            this.grpBoxInfoPompier.PerformLayout();
            this.grpBoxCarriere.ResumeLayout(false);
            this.grpBoxCarriere.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBoxInfoCarriere.ResumeLayout(false);
            this.grpBoxCarriere2.ResumeLayout(false);
            this.grpBoxCarriere2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label lblBD;
        private System.Windows.Forms.GroupBox grpBoxInfoPompier;
        private System.Windows.Forms.Button btnAfficherPlus;
        private System.Windows.Forms.GroupBox grpBoxInfoCarriere;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.RadioButton rdbVolontaire;
        private System.Windows.Forms.RadioButton rdbProfessionnel;
        private System.Windows.Forms.GroupBox grpBoxCarriere;
        private System.Windows.Forms.Label lblED;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChanger;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox txtBoxGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblBip;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.GroupBox grpBoxCarriere2;
        private System.Windows.Forms.Label lblHabilitations;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.CheckBox cBoxConge;
        private System.Windows.Forms.Button btnMaj;
        private System.Windows.Forms.ListBox lstBoxAffectations;
        private System.Windows.Forms.Label lblAffectations;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnAfficherMoins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.CheckedListBox clbHabilitations;
        private System.Windows.Forms.Button btnVeuillez;
        private MenuPanel menuPanel1;
    }
}