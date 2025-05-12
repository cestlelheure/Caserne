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
            this.grpChoixCaserne = new System.Windows.Forms.GroupBox();
            this.lblChoixCaserne = new System.Windows.Forms.Label();
            this.cmbChoixCaserne = new System.Windows.Forms.ComboBox();
            this.grpInfosEngin = new System.Windows.Forms.GroupBox();
            this.lblDateRCP = new System.Windows.Forms.Label();
            this.lblEnMission = new System.Windows.Forms.Label();
            this.lblEnPanne = new System.Windows.Forms.Label();
            this.lblNumEngin = new System.Windows.Forms.Label();
            this.bttnPrecedent = new System.Windows.Forms.Button();
            this.bttnSuivant = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.cbEnMission = new System.Windows.Forms.CheckBox();
            this.cbEnPanne = new System.Windows.Forms.CheckBox();
            this.grpChoixCaserne.SuspendLayout();
            this.grpInfosEngin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpChoixCaserne
            // 
            this.grpChoixCaserne.Controls.Add(this.lblChoixCaserne);
            this.grpChoixCaserne.Controls.Add(this.cmbChoixCaserne);
            this.grpChoixCaserne.Location = new System.Drawing.Point(26, 38);
            this.grpChoixCaserne.Name = "grpChoixCaserne";
            this.grpChoixCaserne.Size = new System.Drawing.Size(762, 46);
            this.grpChoixCaserne.TabIndex = 0;
            this.grpChoixCaserne.TabStop = false;
            // 
            // lblChoixCaserne
            // 
            this.lblChoixCaserne.AutoSize = true;
            this.lblChoixCaserne.Location = new System.Drawing.Point(24, 18);
            this.lblChoixCaserne.Name = "lblChoixCaserne";
            this.lblChoixCaserne.Size = new System.Drawing.Size(131, 16);
            this.lblChoixCaserne.TabIndex = 4;
            this.lblChoixCaserne.Text = "Choix de la caserne :";
            // 
            // cmbChoixCaserne
            // 
            this.cmbChoixCaserne.FormattingEnabled = true;
            this.cmbChoixCaserne.Location = new System.Drawing.Point(240, 18);
            this.cmbChoixCaserne.Name = "cmbChoixCaserne";
            this.cmbChoixCaserne.Size = new System.Drawing.Size(512, 24);
            this.cmbChoixCaserne.TabIndex = 0;
            this.cmbChoixCaserne.SelectedIndexChanged += new System.EventHandler(this.cmbChoixCaserne_SelectedIndexChanged_1);
            // 
            // grpInfosEngin
            // 
            this.grpInfosEngin.Controls.Add(this.cbEnPanne);
            this.grpInfosEngin.Controls.Add(this.cbEnMission);
            this.grpInfosEngin.Controls.Add(this.lblDate);
            this.grpInfosEngin.Controls.Add(this.lblNumero);
            this.grpInfosEngin.Controls.Add(this.lblDateRCP);
            this.grpInfosEngin.Controls.Add(this.lblEnMission);
            this.grpInfosEngin.Controls.Add(this.lblEnPanne);
            this.grpInfosEngin.Controls.Add(this.lblNumEngin);
            this.grpInfosEngin.Location = new System.Drawing.Point(26, 117);
            this.grpInfosEngin.Name = "grpInfosEngin";
            this.grpInfosEngin.Size = new System.Drawing.Size(762, 240);
            this.grpInfosEngin.TabIndex = 1;
            this.grpInfosEngin.TabStop = false;
            // 
            // lblDateRCP
            // 
            this.lblDateRCP.AutoSize = true;
            this.lblDateRCP.Location = new System.Drawing.Point(24, 70);
            this.lblDateRCP.Name = "lblDateRCP";
            this.lblDateRCP.Size = new System.Drawing.Size(114, 16);
            this.lblDateRCP.TabIndex = 3;
            this.lblDateRCP.Text = "Date de récéption";
            // 
            // lblEnMission
            // 
            this.lblEnMission.AutoSize = true;
            this.lblEnMission.Location = new System.Drawing.Point(24, 148);
            this.lblEnMission.Name = "lblEnMission";
            this.lblEnMission.Size = new System.Drawing.Size(72, 16);
            this.lblEnMission.TabIndex = 2;
            this.lblEnMission.Text = "En mission";
            // 
            // lblEnPanne
            // 
            this.lblEnPanne.AutoSize = true;
            this.lblEnPanne.Location = new System.Drawing.Point(24, 189);
            this.lblEnPanne.Name = "lblEnPanne";
            this.lblEnPanne.Size = new System.Drawing.Size(64, 16);
            this.lblEnPanne.TabIndex = 1;
            this.lblEnPanne.Text = "En panne";
            // 
            // lblNumEngin
            // 
            this.lblNumEngin.AutoSize = true;
            this.lblNumEngin.Location = new System.Drawing.Point(24, 28);
            this.lblNumEngin.Name = "lblNumEngin";
            this.lblNumEngin.Size = new System.Drawing.Size(55, 16);
            this.lblNumEngin.TabIndex = 0;
            this.lblNumEngin.Text = "Numéro";
            // 
            // bttnPrecedent
            // 
            this.bttnPrecedent.Location = new System.Drawing.Point(306, 388);
            this.bttnPrecedent.Name = "bttnPrecedent";
            this.bttnPrecedent.Size = new System.Drawing.Size(75, 21);
            this.bttnPrecedent.TabIndex = 2;
            this.bttnPrecedent.Text = "<--";
            this.bttnPrecedent.UseVisualStyleBackColor = true;
            // 
            // bttnSuivant
            // 
            this.bttnSuivant.Location = new System.Drawing.Point(427, 388);
            this.bttnSuivant.Name = "bttnSuivant";
            this.bttnSuivant.Size = new System.Drawing.Size(75, 21);
            this.bttnSuivant.TabIndex = 3;
            this.bttnSuivant.Text = "-->";
            this.bttnSuivant.UseVisualStyleBackColor = true;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(198, 28);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 16);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "label1";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(198, 70);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 16);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "label2";
            // 
            // cbEnMission
            // 
            this.cbEnMission.AutoSize = true;
            this.cbEnMission.Location = new System.Drawing.Point(201, 148);
            this.cbEnMission.Name = "cbEnMission";
            this.cbEnMission.Size = new System.Drawing.Size(18, 17);
            this.cbEnMission.TabIndex = 6;
            this.cbEnMission.UseVisualStyleBackColor = true;
            // 
            // cbEnPanne
            // 
            this.cbEnPanne.AutoSize = true;
            this.cbEnPanne.Location = new System.Drawing.Point(201, 189);
            this.cbEnPanne.Name = "cbEnPanne";
            this.cbEnPanne.Size = new System.Drawing.Size(18, 17);
            this.cbEnPanne.TabIndex = 7;
            this.cbEnPanne.UseVisualStyleBackColor = true;
            // 
            // FormParcoursEngins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnSuivant);
            this.Controls.Add(this.bttnPrecedent);
            this.Controls.Add(this.grpInfosEngin);
            this.Controls.Add(this.grpChoixCaserne);
            this.Name = "FormParcoursEngins";
            this.Text = "FormParcoursEngins";
            this.grpChoixCaserne.ResumeLayout(false);
            this.grpChoixCaserne.PerformLayout();
            this.grpInfosEngin.ResumeLayout(false);
            this.grpInfosEngin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpChoixCaserne;
        private System.Windows.Forms.GroupBox grpInfosEngin;
        private System.Windows.Forms.Label lblChoixCaserne;
        private System.Windows.Forms.ComboBox cmbChoixCaserne;
        private System.Windows.Forms.Label lblDateRCP;
        private System.Windows.Forms.Label lblEnMission;
        private System.Windows.Forms.Label lblEnPanne;
        private System.Windows.Forms.Label lblNumEngin;
        private System.Windows.Forms.Button bttnPrecedent;
        private System.Windows.Forms.Button bttnSuivant;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.CheckBox cbEnPanne;
        private System.Windows.Forms.CheckBox cbEnMission;
    }
}