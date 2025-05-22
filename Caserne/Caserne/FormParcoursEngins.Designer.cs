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
            this.cbEnPanne = new System.Windows.Forms.CheckBox();
            this.cbEnMission = new System.Windows.Forms.CheckBox();
            this.lblDateRCP = new System.Windows.Forms.Label();
            this.lblNumeroEngin = new System.Windows.Forms.Label();
            this.lblEnMission = new System.Windows.Forms.Label();
            this.lblEnPanne = new System.Windows.Forms.Label();
            this.pnlChoixCaserne.SuspendLayout();
            this.pnlInfosEngins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEngin)).BeginInit();
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
            this.pnlInfosEngins.Controls.Add(this.pbEngin);
            this.pnlInfosEngins.Controls.Add(this.cbEnPanne);
            this.pnlInfosEngins.Controls.Add(this.cbEnMission);
            this.pnlInfosEngins.Controls.Add(this.lblDateRCP);
            this.pnlInfosEngins.Controls.Add(this.lblNumeroEngin);
            this.pnlInfosEngins.Controls.Add(this.lblEnMission);
            this.pnlInfosEngins.Controls.Add(this.lblEnPanne);
            this.pnlInfosEngins.Location = new System.Drawing.Point(34, 169);
            this.pnlInfosEngins.Name = "pnlInfosEngins";
            this.pnlInfosEngins.Size = new System.Drawing.Size(950, 351);
            this.pnlInfosEngins.TabIndex = 5;
            // 
            // pbEngin
            // 
            this.pbEngin.Location = new System.Drawing.Point(429, 46);
            this.pbEngin.Name = "pbEngin";
            this.pbEngin.Size = new System.Drawing.Size(492, 258);
            this.pbEngin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEngin.TabIndex = 15;
            this.pbEngin.TabStop = false;
            // 
            // cbEnPanne
            // 
            this.cbEnPanne.AutoSize = true;
            this.cbEnPanne.Enabled = false;
            this.cbEnPanne.Location = new System.Drawing.Point(251, 265);
            this.cbEnPanne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEnPanne.Name = "cbEnPanne";
            this.cbEnPanne.Size = new System.Drawing.Size(18, 17);
            this.cbEnPanne.TabIndex = 14;
            this.cbEnPanne.UseVisualStyleBackColor = true;
            // 
            // cbEnMission
            // 
            this.cbEnMission.AutoSize = true;
            this.cbEnMission.Enabled = false;
            this.cbEnMission.Location = new System.Drawing.Point(251, 207);
            this.cbEnMission.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEnMission.Name = "cbEnMission";
            this.cbEnMission.Size = new System.Drawing.Size(18, 17);
            this.cbEnMission.TabIndex = 13;
            this.cbEnMission.UseVisualStyleBackColor = true;
            // 
            // lblDateRCP
            // 
            this.lblDateRCP.AutoSize = true;
            this.lblDateRCP.Location = new System.Drawing.Point(30, 107);
            this.lblDateRCP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateRCP.Name = "lblDateRCP";
            this.lblDateRCP.Size = new System.Drawing.Size(60, 23);
            this.lblDateRCP.TabIndex = 12;
            this.lblDateRCP.Text = "label2";
            // 
            // lblNumeroEngin
            // 
            this.lblNumeroEngin.AutoSize = true;
            this.lblNumeroEngin.Location = new System.Drawing.Point(30, 52);
            this.lblNumeroEngin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroEngin.Name = "lblNumeroEngin";
            this.lblNumeroEngin.Size = new System.Drawing.Size(60, 23);
            this.lblNumeroEngin.TabIndex = 11;
            this.lblNumeroEngin.Text = "label1";
            // 
            // lblEnMission
            // 
            this.lblEnMission.AutoSize = true;
            this.lblEnMission.Location = new System.Drawing.Point(30, 207);
            this.lblEnMission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnMission.Name = "lblEnMission";
            this.lblEnMission.Size = new System.Drawing.Size(97, 23);
            this.lblEnMission.TabIndex = 10;
            this.lblEnMission.Text = "En mission";
            // 
            // lblEnPanne
            // 
            this.lblEnPanne.AutoSize = true;
            this.lblEnPanne.Location = new System.Drawing.Point(30, 265);
            this.lblEnPanne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnPanne.Name = "lblEnPanne";
            this.lblEnPanne.Size = new System.Drawing.Size(84, 23);
            this.lblEnPanne.TabIndex = 9;
            this.lblEnPanne.Text = "En panne";
            // 
            // FormParcoursEngins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Caserne.Properties.Resources.Fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 611);
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
            this.pnlInfosEngins.PerformLayout();
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
        private System.Windows.Forms.CheckBox cbEnPanne;
        private System.Windows.Forms.CheckBox cbEnMission;
        private System.Windows.Forms.Label lblDateRCP;
        private System.Windows.Forms.Label lblNumeroEngin;
        private System.Windows.Forms.Label lblEnMission;
        private System.Windows.Forms.Label lblEnPanne;
    }
}