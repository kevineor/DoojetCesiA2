﻿namespace DoojetCesiA2
{
    partial class FormAuth
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
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_auth = new System.Windows.Forms.Button();
            this.lb_output = new System.Windows.Forms.Label();
            this.LabelAuthentification = new System.Windows.Forms.Label();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(119, 87);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(132, 22);
            this.txt_username.TabIndex = 0;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(119, 131);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '♫';
            this.txt_password.Size = new System.Drawing.Size(132, 22);
            this.txt_password.TabIndex = 1;
            // 
            // btn_auth
            // 
            this.btn_auth.Location = new System.Drawing.Point(72, 182);
            this.btn_auth.Margin = new System.Windows.Forms.Padding(4);
            this.btn_auth.Name = "btn_auth";
            this.btn_auth.Size = new System.Drawing.Size(133, 28);
            this.btn_auth.TabIndex = 2;
            this.btn_auth.Text = "Se Connecter";
            this.btn_auth.UseVisualStyleBackColor = true;
            this.btn_auth.Click += new System.EventHandler(this.btn_auth_Click);
            // 
            // lb_output
            // 
            this.lb_output.AutoSize = true;
            this.lb_output.Location = new System.Drawing.Point(11, 146);
            this.lb_output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_output.MaximumSize = new System.Drawing.Size(133, 0);
            this.lb_output.Name = "lb_output";
            this.lb_output.Size = new System.Drawing.Size(0, 17);
            this.lb_output.TabIndex = 3;
            this.lb_output.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelAuthentification
            // 
            this.LabelAuthentification.AutoSize = true;
            this.LabelAuthentification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelAuthentification.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAuthentification.Location = new System.Drawing.Point(40, 24);
            this.LabelAuthentification.Name = "LabelAuthentification";
            this.LabelAuthentification.Size = new System.Drawing.Size(197, 29);
            this.LabelAuthentification.TabIndex = 4;
            this.LabelAuthentification.Text = "Authentification";
            this.LabelAuthentification.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Location = new System.Drawing.Point(25, 87);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(73, 17);
            this.LabelUsername.TabIndex = 5;
            this.LabelUsername.Text = "Username";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(25, 131);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(69, 17);
            this.LabelPassword.TabIndex = 6;
            this.LabelPassword.Text = "Password";
            this.LabelPassword.Click += new System.EventHandler(this.label3_Click);
            // 
            // FormAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.LabelAuthentification);
            this.Controls.Add(this.lb_output);
            this.Controls.Add(this.btn_auth);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAuth";
            this.Size = new System.Drawing.Size(277, 291);
            this.Load += new System.EventHandler(this.FormAuth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_auth;
        private System.Windows.Forms.Label lb_output;
        private System.Windows.Forms.Label LabelAuthentification;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label LabelPassword;
    }
}
