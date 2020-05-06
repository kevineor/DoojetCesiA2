using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoojetCesiA2
{
    public partial class mainFrame : Form
    {
        public mainFrame()
        {
            InitializeComponent();
        }

        private void formAuth1_Load(object sender, EventArgs e)
        {
            
        }

        private void formFacture1_Load(object sender, EventArgs e)
        {

        }

        private void mainFrame_Load(object sender, EventArgs e)
        {
            formAuth1.Show();
            formFacture1.Hide();
            formListeResa1.Hide();
        }

        private void formAffichage1_Load(object sender, EventArgs e)
        {

        }

        private void boutonDéconnexion_Click(object sender, EventArgs e)
        {
            formAuth1.Show();
            formFacture1.Hide();
            formListeResa1.Hide();
        }

        private void BoutonFacture_Click(object sender, EventArgs e)
        {
            formFacture1.Show();
            formAuth1.Hide();
            formListeResa1.Hide();
        }

        private void BoutonReservation_Click(object sender, EventArgs e)
        {
            formListeResa1.Show();
            formFacture1.Hide();
            formAuth1.Hide();
        }
    }
}
