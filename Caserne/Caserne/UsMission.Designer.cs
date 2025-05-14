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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblNature = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            this.missionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // picture1
            // 
            this.picture1.Image = ((System.Drawing.Image)(resources.GetObject("picture1.Image")));
            this.picture1.Location = new System.Drawing.Point(-1, -1);
            this.picture1.Margin = new System.Windows.Forms.Padding(2);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(102, 90);
            this.picture1.TabIndex = 5;
            this.picture1.TabStop = false;
            // 
            // missionPanel
            // 
            this.missionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.missionPanel.Controls.Add(this.lblNature);
            this.missionPanel.Controls.Add(this.picture1);
            this.missionPanel.Controls.Add(this.lblCaserne);
            this.missionPanel.Controls.Add(this.lblDate);
            this.missionPanel.Controls.Add(this.lblID);
            this.missionPanel.Controls.Add(this.lblDesc);
            this.missionPanel.Controls.Add(this.pic1);
            this.missionPanel.Location = new System.Drawing.Point(2, 8);
            this.missionPanel.Margin = new System.Windows.Forms.Padding(8);
            this.missionPanel.Name = "missionPanel";
            this.missionPanel.Size = new System.Drawing.Size(770, 90);
            this.missionPanel.TabIndex = 1;
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaserne.Location = new System.Drawing.Point(436, 2);
            this.lblCaserne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(76, 18);
            this.lblCaserne.TabIndex = 4;
            this.lblCaserne.Text = "Caserne : ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(223, 2);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(66, 18);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Debut le ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(105, 2);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(83, 18);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Id mission :";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(366, 49);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(122, 18);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "--> Description ...";
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(2, 108);
            this.pic1.Margin = new System.Windows.Forms.Padding(2);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(75, 41);
            this.pic1.TabIndex = 2;
            this.pic1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(783, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(783, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNature.Location = new System.Drawing.Point(105, 49);
            this.lblNature.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(115, 18);
            this.lblNature.TabIndex = 6;
            this.lblNature.Text = "NatureSinistre";
            // 
            // UcMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.missionPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UcMission";
            this.Size = new System.Drawing.Size(851, 104);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblNature;
    }
}
