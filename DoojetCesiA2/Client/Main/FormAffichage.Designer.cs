namespace DoojetCesiA2
{
    partial class FormAffichage
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
            this.BoutonAfficherAuthentification = new System.Windows.Forms.Button();
            this.BoutonAfficherFacture = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoutonAfficherAuthentification
            // 
            this.BoutonAfficherAuthentification.Location = new System.Drawing.Point(18, 26);
            this.BoutonAfficherAuthentification.Name = "BoutonAfficherAuthentification";
            this.BoutonAfficherAuthentification.Size = new System.Drawing.Size(141, 46);
            this.BoutonAfficherAuthentification.TabIndex = 0;
            this.BoutonAfficherAuthentification.Text = "Authentification";
            this.BoutonAfficherAuthentification.UseVisualStyleBackColor = true;
            this.BoutonAfficherAuthentification.Click += new System.EventHandler(this.BoutonAfficherAuthentification_Click);
            // 
            // BoutonAfficherFacture
            // 
            this.BoutonAfficherFacture.Location = new System.Drawing.Point(18, 96);
            this.BoutonAfficherFacture.Name = "BoutonAfficherFacture";
            this.BoutonAfficherFacture.Size = new System.Drawing.Size(141, 46);
            this.BoutonAfficherFacture.TabIndex = 1;
            this.BoutonAfficherFacture.Text = "Facture";
            this.BoutonAfficherFacture.UseVisualStyleBackColor = true;
            this.BoutonAfficherFacture.Click += new System.EventHandler(this.BoutonAfficherFacture_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 233);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FormAffichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BoutonAfficherFacture);
            this.Controls.Add(this.BoutonAfficherAuthentification);
            this.Name = "FormAffichage";
            this.Size = new System.Drawing.Size(181, 313);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BoutonAfficherAuthentification;
        private System.Windows.Forms.Button BoutonAfficherFacture;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
