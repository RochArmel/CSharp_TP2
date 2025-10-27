using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_Structures
{
    public partial class frmFactoriel : Form
    {
        public frmFactoriel()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFactoriel_FormClosing);
        }

        private void frmFactoriel_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If the user closes the form, show the main menu instead of exiting
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Form accueil = Application.OpenForms["frmAccueil"];
                if (accueil != null)
                {
                    accueil.Show();
                }
            }
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            // Find the existing instance of frmAccueil and show it
            Form accueil = Application.OpenForms["frmAccueil"];
            if (accueil != null)
            {
                accueil.Show();
            }
            this.Hide();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(TxtN.Text, out n) && n >= 0)
            {
                long resultat = 1;
                for (int i = 1; i <= n; i++)
                {
                    resultat *= i;
                }
                LblRes.Text = "Factoriel ( " + n + " ) = " + resultat.ToString();
            }
            else
            {
                MessageBox.Show("Veuillez saisir un entier positif.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LblRes.Text = "";
            }
        }
    }
}
