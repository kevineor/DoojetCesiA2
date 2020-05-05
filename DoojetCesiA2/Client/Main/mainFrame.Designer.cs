using System.Runtime.CompilerServices;

namespace DoojetCesiA2
{
    partial class mainFrame
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
            this.formFacture1 = new DoojetCesiA2.FormFacture();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BoutonNeFaitRien2 = new System.Windows.Forms.Button();
            this.BoutonNefaitRien1 = new System.Windows.Forms.Button();
            this.BoutonFacture = new System.Windows.Forms.Button();
            this.boutonDéconnexion = new System.Windows.Forms.Button();
            this.formAuth1 = new DoojetCesiA2.FormAuth();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formFacture1
            // 
            this.formFacture1.Location = new System.Drawing.Point(203, 48);
            this.formFacture1.Name = "formFacture1";
            this.formFacture1.Size = new System.Drawing.Size(852, 452);
            this.formFacture1.TabIndex = 1;
            this.formFacture1.Load += new System.EventHandler(this.formFacture1_Load);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BoutonNeFaitRien2);
            this.panel1.Controls.Add(this.BoutonNefaitRien1);
            this.panel1.Controls.Add(this.BoutonFacture);
            this.panel1.Controls.Add(this.boutonDéconnexion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 554);
            this.panel1.TabIndex = 2;
            // 
            // BoutonNeFaitRien2
            // 
            this.BoutonNeFaitRien2.Location = new System.Drawing.Point(31, 401);
            this.BoutonNeFaitRien2.Name = "BoutonNeFaitRien2";
            this.BoutonNeFaitRien2.Size = new System.Drawing.Size(134, 50);
            this.BoutonNeFaitRien2.TabIndex = 6;
            this.BoutonNeFaitRien2.Text = "Ne fait rien 2";
            this.BoutonNeFaitRien2.UseVisualStyleBackColor = true;
            // 
            // BoutonNefaitRien1
            // 
            this.BoutonNefaitRien1.Location = new System.Drawing.Point(31, 294);
            this.BoutonNefaitRien1.Name = "BoutonNefaitRien1";
            this.BoutonNefaitRien1.Size = new System.Drawing.Size(134, 50);
            this.BoutonNefaitRien1.TabIndex = 5;
            this.BoutonNefaitRien1.Text = "Ne fait rien 1";
            this.BoutonNefaitRien1.UseVisualStyleBackColor = true;
            // 
            // BoutonFacture
            // 
            this.BoutonFacture.Location = new System.Drawing.Point(31, 176);
            this.BoutonFacture.Name = "BoutonFacture";
            this.BoutonFacture.Size = new System.Drawing.Size(134, 50);
            this.BoutonFacture.TabIndex = 4;
            this.BoutonFacture.Text = "Facture";
            this.BoutonFacture.UseVisualStyleBackColor = true;
            this.BoutonFacture.Click += new System.EventHandler(this.BoutonFacture_Click);
            // 
            // boutonDéconnexion
            // 
            this.boutonDéconnexion.Location = new System.Drawing.Point(31, 60);
            this.boutonDéconnexion.Name = "boutonDéconnexion";
            this.boutonDéconnexion.Size = new System.Drawing.Size(134, 50);
            this.boutonDéconnexion.TabIndex = 3;
            this.boutonDéconnexion.Text = "Déconnexion";
            this.boutonDéconnexion.UseVisualStyleBackColor = true;
            this.boutonDéconnexion.Click += new System.EventHandler(this.boutonDéconnexion_Click);
            // 
            // formAuth1
            // 
            this.formAuth1.Location = new System.Drawing.Point(382, 130);
            this.formAuth1.Margin = new System.Windows.Forms.Padding(4);
            this.formAuth1.Name = "formAuth1";
            this.formAuth1.Size = new System.Drawing.Size(279, 234);
            this.formAuth1.TabIndex = 3;
            // 
            // mainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.formAuth1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.formFacture1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainFrame";
            this.Text = "mainFrame";
            this.Load += new System.EventHandler(this.mainFrame_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FormAuth formAuth1;
        public DoojetCesiA2.FormFacture formFacture1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BoutonNeFaitRien2;
        private System.Windows.Forms.Button BoutonNefaitRien1;
        private System.Windows.Forms.Button BoutonFacture;
        private System.Windows.Forms.Button boutonDéconnexion;
        
    }
}