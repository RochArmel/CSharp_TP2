namespace TP2_Structures
{
    partial class frmJeux
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.Txt3 = new System.Windows.Forms.TextBox();
            this.Txt4 = new System.Windows.Forms.TextBox();
            this.btnNouvellePartie = new System.Windows.Forms.Button();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.btnCacher = new System.Windows.Forms.Button();
            this.GrpProposition = new System.Windows.Forms.GroupBox();
            this.LblNbJeux = new System.Windows.Forms.Label();
            this.TxtP1 = new System.Windows.Forms.TextBox();
            this.TxtP2 = new System.Windows.Forms.TextBox();
            this.TxtP3 = new System.Windows.Forms.TextBox();
            this.TxtP4 = new System.Windows.Forms.TextBox();
            this.btnVerifier = new System.Windows.Forms.Button();
            this.btnRejouer = new System.Windows.Forms.Button();
            this.btnQuitterJeu = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.GrpProposition.SuspendLayout();
            this.SuspendLayout();
            //
            // groupBox1
            //
            this.groupBox1.Controls.Add(this.btnCacher);
            this.groupBox1.Controls.Add(this.btnAfficher);
            this.groupBox1.Controls.Add(this.btnNouvellePartie);
            this.groupBox1.Controls.Add(this.Txt4);
            this.groupBox1.Controls.Add(this.Txt3);
            this.groupBox1.Controls.Add(this.Txt2);
            this.groupBox1.Controls.Add(this.Txt1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nombre caché";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro à deviner";
            //
            // Txt1
            //
            this.Txt1.Location = new System.Drawing.Point(23, 60);
            this.Txt1.Name = "Txt1";
            this.Txt1.ReadOnly = true;
            this.Txt1.Size = new System.Drawing.Size(30, 20);
            this.Txt1.TabIndex = 1;
            //
            // Txt2
            //
            this.Txt2.Location = new System.Drawing.Point(63, 60);
            this.Txt2.Name = "Txt2";
            this.Txt2.ReadOnly = true;
            this.Txt2.Size = new System.Drawing.Size(30, 20);
            this.Txt2.TabIndex = 2;
            //
            // Txt3
            //
            this.Txt3.Location = new System.Drawing.Point(103, 60);
            this.Txt3.Name = "Txt3";
            this.Txt3.ReadOnly = true;
            this.Txt3.Size = new System.Drawing.Size(30, 20);
            this.Txt3.TabIndex = 3;
            //
            // Txt4
            //
            this.Txt4.Location = new System.Drawing.Point(143, 60);
            this.Txt4.Name = "Txt4";
            this.Txt4.ReadOnly = true;
            this.Txt4.Size = new System.Drawing.Size(30, 20);
            this.Txt4.TabIndex = 4;
            //
            // btnNouvellePartie
            //
            this.btnNouvellePartie.Location = new System.Drawing.Point(200, 25);
            this.btnNouvellePartie.Name = "btnNouvellePartie";
            this.btnNouvellePartie.Size = new System.Drawing.Size(100, 23);
            this.btnNouvellePartie.TabIndex = 5;
            this.btnNouvellePartie.Text = "Nouvelle partie";
            this.btnNouvellePartie.UseVisualStyleBackColor = true;
            this.btnNouvellePartie.Click += new System.EventHandler(this.btnNouvellePartie_Click);
            //
            // btnAfficher
            //
            this.btnAfficher.Location = new System.Drawing.Point(200, 60);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(75, 23);
            this.btnAfficher.TabIndex = 6;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            //
            // btnCacher
            //
            this.btnCacher.Location = new System.Drawing.Point(280, 60);
            this.btnCacher.Name = "btnCacher";
            this.btnCacher.Size = new System.Drawing.Size(75, 23);
            this.btnCacher.TabIndex = 7;
            this.btnCacher.Text = "Cacher";
            this.btnCacher.UseVisualStyleBackColor = true;
            this.btnCacher.Click += new System.EventHandler(this.btnCacher_Click);
            //
            // GrpProposition
            //
            this.GrpProposition.Controls.Add(this.btnQuitterJeu);
            this.GrpProposition.Controls.Add(this.btnRejouer);
            this.GrpProposition.Controls.Add(this.btnVerifier);
            this.GrpProposition.Controls.Add(this.TxtP4);
            this.GrpProposition.Controls.Add(this.TxtP3);
            this.GrpProposition.Controls.Add(this.TxtP2);
            this.GrpProposition.Controls.Add(this.TxtP1);
            this.GrpProposition.Controls.Add(this.LblNbJeux);
            this.GrpProposition.Location = new System.Drawing.Point(30, 150);
            this.GrpProposition.Name = "GrpProposition";
            this.GrpProposition.Size = new System.Drawing.Size(420, 100);
            this.GrpProposition.TabIndex = 1;
            this.GrpProposition.TabStop = false;
            this.GrpProposition.Text = "Votre proposition";
            //
            // LblNbJeux
            //
            this.LblNbJeux.AutoSize = true;
            this.LblNbJeux.Location = new System.Drawing.Point(20, 30);
            this.LblNbJeux.Name = "LblNbJeux";
            this.LblNbJeux.Size = new System.Drawing.Size(13, 13);
            this.LblNbJeux.TabIndex = 0;
            this.LblNbJeux.Text = "1";
            //
            // TxtP1
            //
            this.TxtP1.Location = new System.Drawing.Point(23, 60);
            this.TxtP1.MaxLength = 1;
            this.TxtP1.Name = "TxtP1";
            this.TxtP1.Size = new System.Drawing.Size(30, 20);
            this.TxtP1.TabIndex = 1;
            //
            // TxtP2
            //
            this.TxtP2.Location = new System.Drawing.Point(63, 60);
            this.TxtP2.MaxLength = 1;
            this.TxtP2.Name = "TxtP2";
            this.TxtP2.Size = new System.Drawing.Size(30, 20);
            this.TxtP2.TabIndex = 2;
            //
            // TxtP3
            //
            this.TxtP3.Location = new System.Drawing.Point(103, 60);
            this.TxtP3.MaxLength = 1;
            this.TxtP3.Name = "TxtP3";
            this.TxtP3.Size = new System.Drawing.Size(30, 20);
            this.TxtP3.TabIndex = 3;
            //
            // TxtP4
            //
            this.TxtP4.Location = new System.Drawing.Point(143, 60);
            this.TxtP4.MaxLength = 1;
            this.TxtP4.Name = "TxtP4";
            this.TxtP4.Size = new System.Drawing.Size(30, 20);
            this.TxtP4.TabIndex = 4;
            //
            // btnVerifier
            //
            this.btnVerifier.Location = new System.Drawing.Point(200, 60);
            this.btnVerifier.Name = "btnVerifier";
            this.btnVerifier.Size = new System.Drawing.Size(75, 23);
            this.btnVerifier.TabIndex = 5;
            this.btnVerifier.Text = "Verifier";
            this.btnVerifier.UseVisualStyleBackColor = true;
            this.btnVerifier.Click += new System.EventHandler(this.btnVerifier_Click);
            //
            // btnRejouer
            //
            this.btnRejouer.Location = new System.Drawing.Point(280, 60);
            this.btnRejouer.Name = "btnRejouer";
            this.btnRejouer.Size = new System.Drawing.Size(75, 23);
            this.btnRejouer.TabIndex = 6;
            this.btnRejouer.Text = "Rejouer";
            this.btnRejouer.UseVisualStyleBackColor = true;
            this.btnRejouer.Click += new System.EventHandler(this.btnRejouer_Click);
            //
            // btnQuitterJeu
            //
            this.btnQuitterJeu.Location = new System.Drawing.Point(340, 60);
            this.btnQuitterJeu.Name = "btnQuitterJeu";
            this.btnQuitterJeu.Size = new System.Drawing.Size(75, 23);
            this.btnQuitterJeu.TabIndex = 7;
            this.btnQuitterJeu.Text = "Quitter";
            this.btnQuitterJeu.UseVisualStyleBackColor = true;
            this.btnQuitterJeu.Click += new System.EventHandler(this.btnQuitterJeu_Click);
            //
            // timer1
            //
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            //
            // frmJeux
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 281);
            this.Controls.Add(this.GrpProposition);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmJeux";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeux";
            this.Load += new System.EventHandler(this.frmJeux_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GrpProposition.ResumeLayout(false);
            this.GrpProposition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCacher;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.Button btnNouvellePartie;
        private System.Windows.Forms.TextBox Txt4;
        private System.Windows.Forms.TextBox Txt3;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrpProposition;
        private System.Windows.Forms.Button btnQuitterJeu;
        private System.Windows.Forms.Button btnRejouer;
        private System.Windows.Forms.Button btnVerifier;
        private System.Windows.Forms.TextBox TxtP4;
        private System.Windows.Forms.TextBox TxtP3;
        private System.Windows.Forms.TextBox TxtP2;
        private System.Windows.Forms.TextBox TxtP1;
        private System.Windows.Forms.Label LblNbJeux;
        private System.Windows.Forms.Timer timer1;
    }
}
