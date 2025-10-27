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
    public partial class frmJeux : Form
    {
        Random random = new Random();
        List<TextBox> LTxtC = new List<TextBox>();
        List<TextBox> LTxtP = new List<TextBox>();
        int n1, n2, n3, n4;
        int nbJeux = 0;
        bool animation = false;

        public frmJeux()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmJeux_FormClosing);
        }

        private void frmJeux_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmJeux_Load(object sender, EventArgs e)
        {
            LTxtC.Add(Txt1); LTxtC.Add(Txt2); LTxtC.Add(Txt3); LTxtC.Add(Txt4);
            LTxtP.Add(TxtP1); LTxtP.Add(TxtP2); LTxtP.Add(TxtP3); LTxtP.Add(TxtP4);
            InitialiserPartie();
        }

        private void InitialiserPartie()
        {
            n1 = random.Next(0, 10);
            Txt1.Text = n1.ToString();
            do { n2 = random.Next(0, 10); } while (n2 == n1);
            Txt2.Text = n2.ToString();
            do { n3 = random.Next(0, 10); } while (n3 == n2 || n3 == n1);
            Txt3.Text = n3.ToString();
            do { n4 = random.Next(0, 10); } while (n4 == n3 || n4 == n2 || n4 == n1);
            Txt4.Text = n4.ToString();

            nbJeux = 0;
            LblNbJeux.Text = (nbJeux + 1).ToString();
            GrpProposition.Enabled = true;
            timer1.Stop();
            btnCacher_Click(null, null);
            btnRejouer_Click(null, null);
        }

        private void btnNouvellePartie_Click(object sender, EventArgs e)
        {
            InitialiserPartie();
        }

        private void btnCacher_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++) { LTxtC[i].ForeColor = this.BackColor; }
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++) { LTxtC[i].ForeColor = Color.Black; }
        }

        private void btnQuitterJeu_Click(object sender, EventArgs e)
        {
            // Find the existing instance of frmAccueil and show it
            Form accueil = Application.OpenForms["frmAccueil"];
            if (accueil != null)
            {
                accueil.Show();
            }
            this.Hide();
        }

        private void btnRejouer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                LTxtP[i].BackColor = Color.White;
                LTxtP[i].Text = "";
            }
            LTxtP[0].Focus();
        }

        private void btnVerifier_Click(object sender, EventArgs e)
        {
            int correct = 0;
            for (int i = 0; i < 4; i++)
            {
                if (LTxtP[i].Text == LTxtC[i].Text)
                {
                    LTxtP[i].BackColor = Color.Lime;
                    correct++;
                }
                else
                {
                    bool trouve = false;
                    for (int j = 0; j < 4; j++)
                    {
                        if (LTxtP[i].Text == LTxtC[j].Text)
                        {
                            LTxtP[i].BackColor = Color.Yellow;
                            trouve = true;
                            break;
                        }
                    }
                    if (!trouve) LTxtP[i].BackColor = Color.White;
                }
            }

            if (correct == 4)
            {
                timer1.Start();
                btnAfficher_Click(null, null);
                GrpProposition.Enabled = false;
                MessageBox.Show("Bravo ! Vous avez gagné !", "Victoire");
            }
            else
            {
                nbJeux++;
                if (nbJeux == 3)
                {
                    GrpProposition.Enabled = false;
                    btnAfficher_Click(null, null);
                    MessageBox.Show("Vous avez perdu. Le nombre était: " + LTxtC[0].Text + LTxtC[1].Text + LTxtC[2].Text + LTxtC[3].Text, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    LblNbJeux.Text = (nbJeux + 1).ToString();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (animation)
            {
                for (int i = 0; i < 4; i++) LTxtC[i].BackColor = Color.Yellow;
                animation = false;
            }
            else
            {
                for (int i = 0; i < 4; i++) LTxtC[i].BackColor = Color.Red;
                animation = true;
            }
        }
    }
}
