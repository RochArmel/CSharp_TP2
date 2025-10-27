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
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        private void BtnFactoriel_Click(object sender, EventArgs e)
        {
            frmFactoriel f = new frmFactoriel();
            f.Show();
            this.Hide();
        }

        private void BtnTab_Click(object sender, EventArgs e)
        {
            frmTableaux t = new frmTableaux();
            t.Show();
            this.Hide();
        }

        private void BtnJouer_Click(object sender, EventArgs e)
        {
            frmJeux j = new frmJeux();
            j.Show();
            this.Hide();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
