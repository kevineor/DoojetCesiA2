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
            this.panel1 = new System.Windows.Forms.Panel();
            this.formAuth1 = new DoojetCesiA2.FormAuth();
            this.formFacture1 = new DoojetCesiA2.FormFacture();
            this.panel2 = new System.Windows.Forms.Panel();
            this.formListeResa1 = new DoojetCesiA2.FormListeResa();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.boutonDéconnexion = new System.Windows.Forms.Button();
            this.BoutonFacture = new System.Windows.Forms.Button();
            this.BoutonNefaitRien1 = new System.Windows.Forms.Button();
            this.BoutonNeFaitRien2 = new System.Windows.Forms.Button();
            this.BoutonReservation = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.Controls.Add(this.BoutonReservation);
            this.panel1.Controls.Add(this.BoutonNeFaitRien2);
            this.panel1.Controls.Add(this.BoutonNefaitRien1);
            this.panel1.Controls.Add(this.BoutonFacture);
            this.panel1.Controls.Add(this.boutonDéconnexion);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 548);
            this.panel1.TabIndex = 2;
            // 
            // formAuth1
            // 
            this.formAuth1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.formAuth1.Location = new System.Drawing.Point(398, 127);
            this.formAuth1.Margin = new System.Windows.Forms.Padding(4);
            this.formAuth1.Name = "formAuth1";
            this.formAuth1.Size = new System.Drawing.Size(272, 301);
            this.formAuth1.TabIndex = 3;
            // 
            // formFacture1
            // 
            this.formFacture1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.formFacture1.Location = new System.Drawing.Point(5, 48);
            this.formFacture1.Name = "formFacture1";
            this.formFacture1.Size = new System.Drawing.Size(852, 452);
            this.formFacture1.TabIndex = 1;
            this.formFacture1.Load += new System.EventHandler(this.formFacture1_Load);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.formAuth1);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1069, 554);
            this.panel2.TabIndex = 5;
            // 
            // formListeResa1
            // 
            this.formListeResa1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.formListeResa1.Location = new System.Drawing.Point(66, 79);
            this.formListeResa1.Name = "formListeResa1";
            this.formListeResa1.Size = new System.Drawing.Size(731, 390);
            this.formListeResa1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1069, 554);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.formListeResa1);
            this.panel3.Controls.Add(this.formFacture1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(203, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(863, 548);
            this.panel3.TabIndex = 6;
            // 
            // boutonDéconnexion
            // 
            this.boutonDéconnexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.boutonDéconnexion.Location = new System.Drawing.Point(33, 57);
            this.boutonDéconnexion.Name = "boutonDéconnexion";
            this.boutonDéconnexion.Size = new System.Drawing.Size(128, 50);
            this.boutonDéconnexion.TabIndex = 3;
            this.boutonDéconnexion.Text = "Déconnexion";
            this.boutonDéconnexion.UseVisualStyleBackColor = true;
            this.boutonDéconnexion.Click += new System.EventHandler(this.boutonDéconnexion_Click);
            // 
            // BoutonFacture
            // 
            this.BoutonFacture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BoutonFacture.Location = new System.Drawing.Point(33, 151);
            this.BoutonFacture.Name = "BoutonFacture";
            this.BoutonFacture.Size = new System.Drawing.Size(128, 50);
            this.BoutonFacture.TabIndex = 4;
            this.BoutonFacture.Text = "Facture";
            this.BoutonFacture.UseVisualStyleBackColor = true;
            this.BoutonFacture.Click += new System.EventHandler(this.BoutonFacture_Click);
            // 
            // BoutonNefaitRien1
            // 
            this.BoutonNefaitRien1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BoutonNefaitRien1.Location = new System.Drawing.Point(33, 334);
            this.BoutonNefaitRien1.Name = "BoutonNefaitRien1";
            this.BoutonNefaitRien1.Size = new System.Drawing.Size(128, 50);
            this.BoutonNefaitRien1.TabIndex = 5;
            this.BoutonNefaitRien1.Text = "Ne fait rien 1";
            this.BoutonNefaitRien1.UseVisualStyleBackColor = true;
            // 
            // BoutonNeFaitRien2
            // 
            this.BoutonNeFaitRien2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BoutonNeFaitRien2.Location = new System.Drawing.Point(33, 426);
            this.BoutonNeFaitRien2.Name = "BoutonNeFaitRien2";
            this.BoutonNeFaitRien2.Size = new System.Drawing.Size(128, 50);
            this.BoutonNeFaitRien2.TabIndex = 6;
            this.BoutonNeFaitRien2.Text = "Ne fait rien 2";
            this.BoutonNeFaitRien2.UseVisualStyleBackColor = true;
            // 
            // BoutonReservation
            // 
            this.BoutonReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BoutonReservation.Location = new System.Drawing.Point(33, 241);
            this.BoutonReservation.Name = "BoutonReservation";
            this.BoutonReservation.Size = new System.Drawing.Size(128, 50);
            this.BoutonReservation.TabIndex = 7;
            this.BoutonReservation.Text = "Réservations";
            this.BoutonReservation.UseVisualStyleBackColor = true;
            this.BoutonReservation.Click += new System.EventHandler(this.BoutonReservation_Click);
            // 
            // mainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainFrame";
            this.Text = "mainFrame";
            this.Load += new System.EventHandler(this.mainFrame_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public DoojetCesiA2.FormFacture formFacture1;
        private System.Windows.Forms.Panel panel1;
        private FormAuth formAuth1;
        private System.Windows.Forms.Panel panel2;
        private FormListeResa formListeResa1;
        private System.Windows.Forms.Button BoutonReservation;
        private System.Windows.Forms.Button BoutonNeFaitRien2;
        private System.Windows.Forms.Button BoutonNefaitRien1;
        private System.Windows.Forms.Button BoutonFacture;
        private System.Windows.Forms.Button boutonDéconnexion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
    }
}