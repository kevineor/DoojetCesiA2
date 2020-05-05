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
            this.formAuth2 = new DoojetCesiA2.FormAuth();
            this.formFacture1 = new DoojetCesiA2.FormFacture();
            this.SuspendLayout();
            // 
            // formAuth2
            // 
            this.formAuth2.Location = new System.Drawing.Point(461, 207);
            this.formAuth2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.formAuth2.Name = "formAuth2";
            this.formAuth2.Size = new System.Drawing.Size(144, 219);
            this.formAuth2.TabIndex = 0;
            // 
            // formFacture1
            // 
            this.formFacture1.Location = new System.Drawing.Point(114, 50);
            this.formFacture1.Name = "formFacture1";
            this.formFacture1.Size = new System.Drawing.Size(852, 452);
            this.formFacture1.TabIndex = 1;
            // 
            // mainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.formFacture1);
            this.Controls.Add(this.formAuth2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "mainFrame";
            this.Text = "mainFrame";
            this.ResumeLayout(false);

        }

        #endregion

        private DoojetCesiA2.FormAuth formAuth1;
        private DoojetCesiA2.FormAuth formAuth2;
        private FormFacture formFacture1;
    }
}