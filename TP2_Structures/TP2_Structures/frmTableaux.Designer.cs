namespace TP2_Structures
{
    partial class frmTableaux
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblRes = new System.Windows.Forms.Label();
            this.TxtN = new System.Windows.Forms.TextBox();
            this.BtnEnreg = new System.Windows.Forms.Button();
            this.LblT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblMoy = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblEcart = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblInf = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblSup = new System.Windows.Forms.Label();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.BtnQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enregistrement des Notes:";
            //
            // LblRes
            //
            this.LblRes.AutoSize = true;
            this.LblRes.Location = new System.Drawing.Point(30, 60);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(146, 13);
            this.LblRes.TabIndex = 1;
            this.LblRes.Text = "Entrez la note de l\'élève N°: 1";
            //
            // TxtN
            //
            this.TxtN.Location = new System.Drawing.Point(190, 57);
            this.TxtN.Name = "TxtN";
            this.TxtN.Size = new System.Drawing.Size(100, 20);
            this.TxtN.TabIndex = 2;
            //
            // BtnEnreg
            //
            this.BtnEnreg.Location = new System.Drawing.Point(300, 55);
            this.BtnEnreg.Name = "BtnEnreg";
            this.BtnEnreg.Size = new System.Drawing.Size(75, 23);
            this.BtnEnreg.TabIndex = 3;
            this.BtnEnreg.Text = "Enregistrer";
            this.BtnEnreg.UseVisualStyleBackColor = true;
            this.BtnEnreg.Click += new System.EventHandler(this.BtnEnreg_Click);
            //
            // LblT
            //
            this.LblT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblT.Location = new System.Drawing.Point(33, 90);
            this.LblT.Name = "LblT";
            this.LblT.Size = new System.Drawing.Size(342, 23);
            this.LblT.TabIndex = 4;
            this.LblT.Text = "|";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Moyenne de la classe:";
            //
            // LblMoy
            //
            this.LblMoy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMoy.Location = new System.Drawing.Point(190, 135);
            this.LblMoy.Name = "LblMoy";
            this.LblMoy.Size = new System.Drawing.Size(100, 23);
            this.LblMoy.TabIndex = 6;
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "L'écart-type:";
            //
            // LblEcart
            //
            this.LblEcart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblEcart.Location = new System.Drawing.Point(190, 165);
            this.LblEcart.Name = "LblEcart";
            this.LblEcart.Size = new System.Drawing.Size(100, 23);
            this.LblEcart.TabIndex = 8;
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nombre des Notes < 10:";
            //
            // LblInf
            //
            this.LblInf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblInf.Location = new System.Drawing.Point(190, 195);
            this.LblInf.Name = "LblInf";
            this.LblInf.Size = new System.Drawing.Size(100, 23);
            this.LblInf.TabIndex = 10;
            //
            // label9
            //
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Nombre des Notes >= 10:";
            //
            // LblSup
            //
            this.LblSup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblSup.Location = new System.Drawing.Point(190, 225);
            this.LblSup.Name = "LblSup";
            this.LblSup.Size = new System.Drawing.Size(100, 23);
            this.LblSup.TabIndex = 12;
            //
            // BtnCalc
            //
            this.BtnCalc.Location = new System.Drawing.Point(300, 165);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(75, 23);
            this.BtnCalc.TabIndex = 13;
            this.BtnCalc.Text = "Calculer";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            //
            // BtnQ
            //
            this.BtnQ.Location = new System.Drawing.Point(150, 270);
            this.BtnQ.Name = "BtnQ";
            this.BtnQ.Size = new System.Drawing.Size(75, 23);
            this.BtnQ.TabIndex = 14;
            this.BtnQ.Text = "Retour";
            this.BtnQ.UseVisualStyleBackColor = true;
            this.BtnQ.Click += new System.EventHandler(this.BtnQ_Click);
            //
            // frmTableaux
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 311);
            this.Controls.Add(this.BtnQ);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.LblSup);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LblInf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblEcart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblMoy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblT);
            this.Controls.Add(this.BtnEnreg);
            this.Controls.Add(this.TxtN);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTableaux";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les Tableaux";
            this.Load += new System.EventHandler(this.frmTableaux_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.TextBox TxtN;
        private System.Windows.Forms.Button BtnEnreg;
        private System.Windows.Forms.Label LblT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblMoy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblEcart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblInf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblSup;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Button BtnQ;
    }
}
