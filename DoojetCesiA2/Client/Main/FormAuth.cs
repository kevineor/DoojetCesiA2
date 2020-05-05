using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoojetCesiA2
{
    public partial class FormAuth : UserControl
    {
        CUT.TraitementUtilisateur traitementUtilisateur;
        public FormAuth()
        {
            InitializeComponent();
        }

        private void FormAuth_Load(object sender, EventArgs e)
        {
            traitementUtilisateur = new CUT.TraitementUtilisateur();
        }

        private void btn_auth_Click(object sender, EventArgs e)
        {
            STR_MSG msg = new STR_MSG();
            msg.username = txt_username.Text;
            msg.userpass = txt_password.Text;
            msg = traitementUtilisateur.authentifier(msg);
            lb_output.Text = msg.info;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
