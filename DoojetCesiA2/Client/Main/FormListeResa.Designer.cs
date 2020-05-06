namespace DoojetCesiA2
{
    partial class FormListeResa
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LabelClient = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.LabelDateDebut = new System.Windows.Forms.Label();
            this.LabelDateFin = new System.Windows.Forms.Label();
            this.LabelEquipement = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Créer Facture";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Nouvel équipement";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LabelClient
            // 
            this.LabelClient.AutoSize = true;
            this.LabelClient.Location = new System.Drawing.Point(44, 34);
            this.LabelClient.Name = "LabelClient";
            this.LabelClient.Size = new System.Drawing.Size(43, 17);
            this.LabelClient.TabIndex = 2;
            this.LabelClient.Text = "Client";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(103, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(47, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(293, 110);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(220, 22);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // LabelDateDebut
            // 
            this.LabelDateDebut.AutoSize = true;
            this.LabelDateDebut.Location = new System.Drawing.Point(44, 90);
            this.LabelDateDebut.Name = "LabelDateDebut";
            this.LabelDateDebut.Size = new System.Drawing.Size(26, 17);
            this.LabelDateDebut.TabIndex = 6;
            this.LabelDateDebut.Text = "Du";
            // 
            // LabelDateFin
            // 
            this.LabelDateFin.AutoSize = true;
            this.LabelDateFin.Location = new System.Drawing.Point(290, 90);
            this.LabelDateFin.Name = "LabelDateFin";
            this.LabelDateFin.Size = new System.Drawing.Size(25, 17);
            this.LabelDateFin.TabIndex = 7;
            this.LabelDateFin.Text = "Au";
            // 
            // LabelEquipement
            // 
            this.LabelEquipement.AutoSize = true;
            this.LabelEquipement.Location = new System.Drawing.Point(548, 90);
            this.LabelEquipement.Name = "LabelEquipement";
            this.LabelEquipement.Size = new System.Drawing.Size(83, 17);
            this.LabelEquipement.TabIndex = 8;
            this.LabelEquipement.Text = "Équipement";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(551, 112);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 20);
            this.listBox1.TabIndex = 9;
            // 
            // FormListeResa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.LabelEquipement);
            this.Controls.Add(this.LabelDateFin);
            this.Controls.Add(this.LabelDateDebut);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LabelClient);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormListeResa";
            this.Size = new System.Drawing.Size(710, 407);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LabelClient;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label LabelDateDebut;
        private System.Windows.Forms.Label LabelDateFin;
        private System.Windows.Forms.Label LabelEquipement;
        private System.Windows.Forms.ListBox listBox1;
    }
}
