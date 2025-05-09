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
            this.cmbCaserne = new System.Windows.Forms.ComboBox();
            this.lblChoixCaserne = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnPrecedent
            // 
            this.bttnPrecedent.Location = new System.Drawing.Point(276, 363);
            this.bttnPrecedent.Name = "bttnPrecedent";
            this.bttnPrecedent.Size = new System.Drawing.Size(69, 53);
            this.bttnPrecedent.TabIndex = 0;
            this.bttnPrecedent.Text = "<--";
            this.bttnPrecedent.UseVisualStyleBackColor = true;
            this.bttnPrecedent.Click += new System.EventHandler(this.bttnPrecedent_Click);
            // 
            // bttnSuivant
            // 
            this.bttnSuivant.Location = new System.Drawing.Point(402, 363);
            this.bttnSuivant.Name = "bttnSuivant";
            this.bttnSuivant.Size = new System.Drawing.Size(65, 53);
            this.bttnSuivant.TabIndex = 1;
            this.bttnSuivant.Text = "-->";
            this.bttnSuivant.UseVisualStyleBackColor = true;
            this.bttnSuivant.Click += new System.EventHandler(this.bttnSuivant_Click);
            // 
            // cmbCaserne
            // 
            this.cmbCaserne.FormattingEnabled = true;
            this.cmbCaserne.Location = new System.Drawing.Point(276, 12);
            this.cmbCaserne.Name = "cmbCaserne";
            this.cmbCaserne.Size = new System.Drawing.Size(311, 24);
            this.cmbCaserne.TabIndex = 2;
            // 
            // lblChoixCaserne
            // 
            this.lblChoixCaserne.AutoSize = true;
            this.lblChoixCaserne.Location = new System.Drawing.Point(107, 15);
            this.lblChoixCaserne.Name = "lblChoixCaserne";
            this.lblChoixCaserne.Size = new System.Drawing.Size(163, 16);
            this.lblChoixCaserne.TabIndex = 4;
            this.lblChoixCaserne.Text = "Choissisez votre caserne :";
            // 
            // FormParcoursEngins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblChoixCaserne);
            this.Controls.Add(this.cmbCaserne);
            this.Controls.Add(this.bttnSuivant);
            this.Controls.Add(this.bttnPrecedent);
            this.Name = "FormParcoursEngins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormParcoursEngins";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnPrecedent;
        private System.Windows.Forms.Button bttnSuivant;
        private System.Windows.Forms.ComboBox cmbCaserne;
        private System.Windows.Forms.Label lblChoixCaserne;
    }
}