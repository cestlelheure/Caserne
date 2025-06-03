namespace Caserne
{
    partial class UserControlRessourcesMobilisees
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblStatistiques = new System.Windows.Forms.Label();
            this.pnlEngins = new System.Windows.Forms.Panel();
            this.pnlPompiers = new System.Windows.Forms.Panel();
            this.lblTitreEngins = new System.Windows.Forms.Label();
            this.lblTitrePompiers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitre.Location = new System.Drawing.Point(10, 10);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(278, 27);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Ressources mobilisées";
            // 
            // lblStatistiques
            // 
            this.lblStatistiques.AutoSize = true;
            this.lblStatistiques.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistiques.ForeColor = System.Drawing.Color.Gray;
            this.lblStatistiques.Location = new System.Drawing.Point(300, 15);
            this.lblStatistiques.Name = "lblStatistiques";
            this.lblStatistiques.Size = new System.Drawing.Size(48, 20);
            this.lblStatistiques.TabIndex = 1;
            this.lblStatistiques.Text = "Total:";
            // 
            // pnlEngins
            // 
            this.pnlEngins.AutoScroll = true;
            this.pnlEngins.BackColor = System.Drawing.Color.White;
            this.pnlEngins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEngins.Location = new System.Drawing.Point(10, 70);
            this.pnlEngins.Name = "pnlEngins";
            this.pnlEngins.Size = new System.Drawing.Size(420, 300);
            this.pnlEngins.TabIndex = 2;
            // 
            // pnlPompiers
            // 
            this.pnlPompiers.AutoScroll = true;
            this.pnlPompiers.BackColor = System.Drawing.Color.White;
            this.pnlPompiers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPompiers.Location = new System.Drawing.Point(440, 70);
            this.pnlPompiers.Name = "pnlPompiers";
            this.pnlPompiers.Size = new System.Drawing.Size(420, 300);
            this.pnlPompiers.TabIndex = 3;
            // 
            // lblTitreEngins
            // 
            this.lblTitreEngins.AutoSize = true;
            this.lblTitreEngins.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreEngins.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitreEngins.Location = new System.Drawing.Point(10, 45);
            this.lblTitreEngins.Name = "lblTitreEngins";
            this.lblTitreEngins.Size = new System.Drawing.Size(147, 24);
            this.lblTitreEngins.TabIndex = 4;
            this.lblTitreEngins.Text = "Engins mobilisés";
            // 
            // lblTitrePompiers
            // 
            this.lblTitrePompiers.AutoSize = true;
            this.lblTitrePompiers.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitrePompiers.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitrePompiers.Location = new System.Drawing.Point(440, 45);
            this.lblTitrePompiers.Name = "lblTitrePompiers";
            this.lblTitrePompiers.Size = new System.Drawing.Size(171, 24);
            this.lblTitrePompiers.TabIndex = 5;
            this.lblTitrePompiers.Text = "Pompiers mobilisés";
            // 
            // UserControlRessourcesMobilisees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblTitrePompiers);
            this.Controls.Add(this.lblTitreEngins);
            this.Controls.Add(this.pnlPompiers);
            this.Controls.Add(this.pnlEngins);
            this.Controls.Add(this.lblStatistiques);
            this.Controls.Add(this.lblTitre);
            this.Name = "UserControlRessourcesMobilisees";
            this.Size = new System.Drawing.Size(870, 380);
            this.Resize += new System.EventHandler(this.UserControlRessourcesMobilisees_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblStatistiques;
        private System.Windows.Forms.Panel pnlEngins;
        private System.Windows.Forms.Panel pnlPompiers;
        private System.Windows.Forms.Label lblTitreEngins;
        private System.Windows.Forms.Label lblTitrePompiers;
    }
}