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
            this.cbEnPanne = new System.Windows.Forms.CheckBox();
            this.cbEnMission = new System.Windows.Forms.CheckBox();
            this.lblDateRCP = new System.Windows.Forms.Label();
            this.lblNumeroEngin = new System.Windows.Forms.Label();
            this.lblEnMission = new System.Windows.Forms.Label();
            this.lblEnPanne = new System.Windows.Forms.Label();
            this.bttnPrecedent = new System.Windows.Forms.Button();
            this.bttnSuivant = new System.Windows.Forms.Button();
            this.pbEngin = new System.Windows.Forms.PictureBox();
            this.grpChoixCaserne.SuspendLayout();
            this.grpInfosEngin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEngin)).BeginInit();
            this.SuspendLayout();
            // 
            // grpChoixCaserne
            // 
            this.grpChoixCaserne.Controls.Add(this.lblChoixCaserne);
            this.grpChoixCaserne.Controls.Add(this.cmbChoixCaserne);
            this.grpChoixCaserne.Location = new System.Drawing.Point(32, 54);
            this.grpChoixCaserne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpChoixCaserne.Name = "grpChoixCaserne";
            this.grpChoixCaserne.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpChoixCaserne.Size = new System.Drawing.Size(952, 67);
            this.grpChoixCaserne.TabIndex = 0;
            this.grpChoixCaserne.TabStop = false;
            // 
            // lblChoixCaserne
            // 
            this.lblChoixCaserne.AutoSize = true;
            this.lblChoixCaserne.Location = new System.Drawing.Point(30, 25);
            this.lblChoixCaserne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChoixCaserne.Name = "lblChoixCaserne";
            this.lblChoixCaserne.Size = new System.Drawing.Size(177, 23);
            this.lblChoixCaserne.TabIndex = 4;
            this.lblChoixCaserne.Text = "Choix de la caserne :";
            // 
            // cmbChoixCaserne
            // 
            this.cmbChoixCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChoixCaserne.FormattingEnabled = true;
            this.cmbChoixCaserne.Location = new System.Drawing.Point(305, 22);
            this.cmbChoixCaserne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbChoixCaserne.Name = "cmbChoixCaserne";
            this.cmbChoixCaserne.Size = new System.Drawing.Size(639, 31);
            this.cmbChoixCaserne.TabIndex = 0;
            this.cmbChoixCaserne.SelectedIndexChanged += new System.EventHandler(this.cmbChoixCaserne_SelectedIndexChanged_1);
            // 
            // grpInfosEngin
            // 
            this.grpInfosEngin.Controls.Add(this.pbEngin);
            this.grpInfosEngin.Controls.Add(this.cbEnPanne);
            this.grpInfosEngin.Controls.Add(this.cbEnMission);
            this.grpInfosEngin.Controls.Add(this.lblDateRCP);
            this.grpInfosEngin.Controls.Add(this.lblNumeroEngin);
            this.grpInfosEngin.Controls.Add(this.lblEnMission);
            this.grpInfosEngin.Controls.Add(this.lblEnPanne);
            this.grpInfosEngin.Location = new System.Drawing.Point(32, 168);
            this.grpInfosEngin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpInfosEngin.Name = "grpInfosEngin";
            this.grpInfosEngin.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpInfosEngin.Size = new System.Drawing.Size(952, 345);
            this.grpInfosEngin.TabIndex = 1;
            this.grpInfosEngin.TabStop = false;
            // 
            // cbEnPanne
            // 
            this.cbEnPanne.AutoSize = true;
            this.cbEnPanne.Enabled = false;
            this.cbEnPanne.Location = new System.Drawing.Point(251, 271);
            this.cbEnPanne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEnPanne.Name = "cbEnPanne";
            this.cbEnPanne.Size = new System.Drawing.Size(18, 17);
            this.cbEnPanne.TabIndex = 7;
            this.cbEnPanne.UseVisualStyleBackColor = true;
            // 
            // cbEnMission
            // 
            this.cbEnMission.AutoSize = true;
            this.cbEnMission.Enabled = false;
            this.cbEnMission.Location = new System.Drawing.Point(251, 213);
            this.cbEnMission.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEnMission.Name = "cbEnMission";
            this.cbEnMission.Size = new System.Drawing.Size(18, 17);
            this.cbEnMission.TabIndex = 6;
            this.cbEnMission.UseVisualStyleBackColor = true;
            // 
            // lblDateRCP
            // 
            this.lblDateRCP.AutoSize = true;
            this.lblDateRCP.Location = new System.Drawing.Point(30, 113);
            this.lblDateRCP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateRCP.Name = "lblDateRCP";
            this.lblDateRCP.Size = new System.Drawing.Size(60, 23);
            this.lblDateRCP.TabIndex = 5;
            this.lblDateRCP.Text = "label2";
            // 
            // lblNumeroEngin
            // 
            this.lblNumeroEngin.AutoSize = true;
            this.lblNumeroEngin.Location = new System.Drawing.Point(30, 58);
            this.lblNumeroEngin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroEngin.Name = "lblNumeroEngin";
            this.lblNumeroEngin.Size = new System.Drawing.Size(60, 23);
            this.lblNumeroEngin.TabIndex = 4;
            this.lblNumeroEngin.Text = "label1";
            // 
            // lblEnMission
            // 
            this.lblEnMission.AutoSize = true;
            this.lblEnMission.Location = new System.Drawing.Point(30, 213);
            this.lblEnMission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnMission.Name = "lblEnMission";
            this.lblEnMission.Size = new System.Drawing.Size(97, 23);
            this.lblEnMission.TabIndex = 2;
            this.lblEnMission.Text = "En mission";
            // 
            // lblEnPanne
            // 
            this.lblEnPanne.AutoSize = true;
            this.lblEnPanne.Location = new System.Drawing.Point(30, 271);
            this.lblEnPanne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnPanne.Name = "lblEnPanne";
            this.lblEnPanne.Size = new System.Drawing.Size(84, 23);
            this.lblEnPanne.TabIndex = 1;
            this.lblEnPanne.Text = "En panne";
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
            // pbEngin
            // 
            this.pbEngin.Location = new System.Drawing.Point(429, 52);
            this.pbEngin.Name = "pbEngin";
            this.pbEngin.Size = new System.Drawing.Size(492, 258);
            this.pbEngin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEngin.TabIndex = 8;
            this.pbEngin.TabStop = false;
            // 
            // FormParcoursEngins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 646);
            this.Controls.Add(this.bttnSuivant);
            this.Controls.Add(this.bttnPrecedent);
            this.Controls.Add(this.grpInfosEngin);
            this.Controls.Add(this.grpChoixCaserne);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormParcoursEngins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormParcoursEngins";
            this.grpChoixCaserne.ResumeLayout(false);
            this.grpChoixCaserne.PerformLayout();
            this.grpInfosEngin.ResumeLayout(false);
            this.grpInfosEngin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEngin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpChoixCaserne;
        private System.Windows.Forms.GroupBox grpInfosEngin;
        private System.Windows.Forms.Label lblChoixCaserne;
        private System.Windows.Forms.ComboBox cmbChoixCaserne;
        private System.Windows.Forms.Label lblEnMission;
        private System.Windows.Forms.Label lblEnPanne;
        private System.Windows.Forms.Button bttnPrecedent;
        private System.Windows.Forms.Button bttnSuivant;
        private System.Windows.Forms.Label lblDateRCP;
        private System.Windows.Forms.Label lblNumeroEngin;
        private System.Windows.Forms.CheckBox cbEnPanne;
        private System.Windows.Forms.CheckBox cbEnMission;
        private System.Windows.Forms.PictureBox pbEngin;
    }
}