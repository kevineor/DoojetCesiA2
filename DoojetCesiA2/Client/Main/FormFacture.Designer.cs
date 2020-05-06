namespace DoojetCesiA2
{
    partial class FormFacture
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LabelNomClient = new System.Windows.Forms.Label();
            this.boutonRecherche = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LabelDateDebut = new System.Windows.Forms.Label();
            this.LabelDateFin = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxClient = new System.Windows.Forms.CheckBox();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 200);
            this.dataGridView1.TabIndex = 0;
            // 
            // LabelNomClient
            // 
            this.LabelNomClient.AutoSize = true;
            this.LabelNomClient.Location = new System.Drawing.Point(30, 27);
            this.LabelNomClient.Name = "LabelNomClient";
            this.LabelNomClient.Size = new System.Drawing.Size(74, 17);
            this.LabelNomClient.TabIndex = 1;
            this.LabelNomClient.Text = "Nom client";
            this.LabelNomClient.Click += new System.EventHandler(this.label1_Click);
            // 
            // boutonRecherche
            // 
            this.boutonRecherche.Location = new System.Drawing.Point(588, 140);
            this.boutonRecherche.Name = "boutonRecherche";
            this.boutonRecherche.Size = new System.Drawing.Size(221, 57);
            this.boutonRecherche.TabIndex = 2;
            this.boutonRecherche.Text = "Lancer la recherche";
            this.boutonRecherche.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // LabelDateDebut
            // 
            this.LabelDateDebut.AutoSize = true;
            this.LabelDateDebut.Location = new System.Drawing.Point(30, 80);
            this.LabelDateDebut.Name = "LabelDateDebut";
            this.LabelDateDebut.Size = new System.Drawing.Size(26, 17);
            this.LabelDateDebut.TabIndex = 5;
            this.LabelDateDebut.Text = "Du";
            // 
            // LabelDateFin
            // 
            this.LabelDateFin.AutoSize = true;
            this.LabelDateFin.Location = new System.Drawing.Point(411, 80);
            this.LabelDateFin.Name = "LabelDateFin";
            this.LabelDateFin.Size = new System.Drawing.Size(25, 17);
            this.LabelDateFin.TabIndex = 6;
            this.LabelDateFin.Text = "Au";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(481, 78);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(220, 22);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // checkBoxClient
            // 
            this.checkBoxClient.AutoSize = true;
            this.checkBoxClient.Location = new System.Drawing.Point(33, 159);
            this.checkBoxClient.Name = "checkBoxClient";
            this.checkBoxClient.Size = new System.Drawing.Size(112, 21);
            this.checkBoxClient.TabIndex = 8;
            this.checkBoxClient.Text = "Client unique";
            this.checkBoxClient.UseVisualStyleBackColor = true;
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Location = new System.Drawing.Point(283, 159);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(106, 21);
            this.checkBoxDate.TabIndex = 9;
            this.checkBoxDate.Text = "Date définie";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            // 
            // FormFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxDate);
            this.Controls.Add(this.checkBoxClient);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.LabelDateFin);
            this.Controls.Add(this.LabelDateDebut);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.boutonRecherche);
            this.Controls.Add(this.LabelNomClient);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormFacture";
            this.Size = new System.Drawing.Size(852, 452);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LabelNomClient;
        private System.Windows.Forms.Button boutonRecherche;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LabelDateDebut;
        private System.Windows.Forms.Label LabelDateFin;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox checkBoxClient;
        private System.Windows.Forms.CheckBox checkBoxDate;
    }
}
