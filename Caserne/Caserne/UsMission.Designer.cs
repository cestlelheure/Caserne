namespace Caserne
{
    partial class UcMission
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcMission));
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.missionPanel = new System.Windows.Forms.Panel();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            this.missionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // picture1
            // 
            this.picture1.Image = ((System.Drawing.Image)(resources.GetObject("picture1.Image")));
            this.picture1.Location = new System.Drawing.Point(3, 3);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(104, 102);
            this.picture1.TabIndex = 5;
            this.picture1.TabStop = false;
            // 
            // missionPanel
            // 
            this.missionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.missionPanel.Controls.Add(this.picture1);
            this.missionPanel.Controls.Add(this.lblCaserne);
            this.missionPanel.Controls.Add(this.lblDate);
            this.missionPanel.Controls.Add(this.lblID);
            this.missionPanel.Controls.Add(this.lblDesc);
            this.missionPanel.Controls.Add(this.pic1);
            this.missionPanel.Location = new System.Drawing.Point(10, 10);
            this.missionPanel.Margin = new System.Windows.Forms.Padding(10);
            this.missionPanel.Name = "missionPanel";
            this.missionPanel.Size = new System.Drawing.Size(1125, 110);
            this.missionPanel.TabIndex = 1;
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaserne.Location = new System.Drawing.Point(582, 3);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(96, 24);
            this.lblCaserne.TabIndex = 4;
            this.lblCaserne.Text = "Caserne : ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(306, 3);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(85, 24);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Debut le ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(113, 3);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(104, 24);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Id mission :";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(582, 56);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(152, 24);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "--> Description ...";
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(3, 133);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(100, 50);
            this.pic1.TabIndex = 2;
            this.pic1.TabStop = false;
            // 
            // UcMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.missionPanel);
            this.Name = "UcMission";
            this.Size = new System.Drawing.Size(1146, 128);
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            this.missionPanel.ResumeLayout(false);
            this.missionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.Panel missionPanel;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.PictureBox pic1;
    }
}
