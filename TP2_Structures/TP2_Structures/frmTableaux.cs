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
    public partial class frmTableaux : Form
    {
        const int n = 5;
        float[] T = new float[n];
        int i = 0;

        public frmTableaux()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTableaux_FormClosing);
        }

        private void frmTableaux_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmTableaux_Load(object sender, EventArgs e)
        {
            BtnCalc.Enabled = false;
            LblT.Text = "|";
            LblRes.Text = "Entrez la note de l'élève N°: " + (i + 1);
        }

        private void BtnQ_Click(object sender, EventArgs e)
        {
            // Find the existing instance of frmAccueil and show it
            Form accueil = Application.OpenForms["frmAccueil"];
            if (accueil != null)
            {
                accueil.Show();
            }
            this.Hide();
        }

        private void BtnEnreg_Click(object sender, EventArgs e)
        {
            float val;
            if (float.TryParse(TxtN.Text, out val) && val >= 0 && val <= 20)
            {
                T[i] = val;
                LblT.Text = LblT.Text + TxtN.Text + "|";
                i++;
                TxtN.Text = "";
                TxtN.Focus();
                if (i == n)
                {
                    BtnCalc.Enabled = true;
                    BtnEnreg.Enabled = false;
                    TxtN.Enabled = false;
                    BtnCalc.Focus();
                    LblRes.Text = "Saisie terminée. Cliquez sur Calculer.";
                }
                else
                {
                    LblRes.Text = "Entrez la note de l'élève N°: " + (i + 1);
                }
            }
            else
            {
                MessageBox.Show("Veuillez saisir une note valide (nombre positif).", "Erreur");
            }
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            float somme = 0;
            int nbInf = 0;
            int nbSup = 0;
            for (int j = 0; j < n; j++)
            {
                somme += T[j];
                if (T[j] < 10)
                {
                    nbInf++;
                }
                else
                {
                    nbSup++;
                }
            }
            float moyenne = somme / n;
            float sommeEcartsCarres = 0;
            for (int j = 0; j < n; j++)
            {
                sommeEcartsCarres += (float)Math.Pow(T[j] - moyenne, 2);
            }
            double ecartType = Math.Sqrt(sommeEcartsCarres / n);
            LblMoy.Text = moyenne.ToString("F2");
            LblEcart.Text = ecartType.ToString("F5");
            LblInf.Text = nbInf.ToString();
            LblSup.Text = nbSup.ToString();
        }
    }
}
