namespace Caserne
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lblID = new System.Windows.Forms.Label();
            this.lblMDP = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.txtBoxMDP = new System.Windows.Forms.TextBox();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnOeil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(59, 60);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(79, 19);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Identifiant :";
            // 
            // lblMDP
            // 
            this.lblMDP.AutoSize = true;
            this.lblMDP.Location = new System.Drawing.Point(59, 112);
            this.lblMDP.Name = "lblMDP";
            this.lblMDP.Size = new System.Drawing.Size(103, 19);
            this.lblMDP.TabIndex = 1;
            this.lblMDP.Text = "Mot de passe : ";
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(184, 58);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(152, 24);
            this.txtBoxID.TabIndex = 1;
            // 
            // txtBoxMDP
            // 
            this.txtBoxMDP.Location = new System.Drawing.Point(184, 112);
            this.txtBoxMDP.Name = "txtBoxMDP";
            this.txtBoxMDP.Size = new System.Drawing.Size(152, 24);
            this.txtBoxMDP.TabIndex = 2;
            this.txtBoxMDP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxMDP_KeyDown);
            this.txtBoxMDP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtBoxMDP_MouseDown);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(351, 196);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(90, 36);
            this.btnConfirmer.TabIndex = 4;
            this.btnConfirmer.Text = "Valider";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // btnOeil
            // 
            this.btnOeil.Location = new System.Drawing.Point(342, 112);
            this.btnOeil.Name = "btnOeil";
            this.btnOeil.Size = new System.Drawing.Size(35, 24);
            this.btnOeil.TabIndex = 3;
            this.btnOeil.Text = "👁";
            this.btnOeil.UseVisualStyleBackColor = true;
            this.btnOeil.Click += new System.EventHandler(this.btnOeil_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 248);
            this.Controls.Add(this.btnOeil);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.txtBoxMDP);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.lblMDP);
            this.Controls.Add(this.lblID);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S\'identifier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblMDP;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.TextBox txtBoxMDP;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnOeil;
    }
}