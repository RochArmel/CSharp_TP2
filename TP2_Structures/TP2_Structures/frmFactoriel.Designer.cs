namespace TP2_Structures
{
    partial class frmFactoriel
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtN = new System.Windows.Forms.TextBox();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.LblRes = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factoriel";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Donner un entier positif:";
            //
            // TxtN
            //
            this.TxtN.Location = new System.Drawing.Point(170, 67);
            this.TxtN.Name = "TxtN";
            this.TxtN.Size = new System.Drawing.Size(100, 20);
            this.TxtN.TabIndex = 2;
            //
            // BtnCalc
            //
            this.BtnCalc.Location = new System.Drawing.Point(280, 65);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(75, 23);
            this.BtnCalc.TabIndex = 3;
            this.BtnCalc.Text = "Calculer";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            //
            // LblRes
            //
            this.LblRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblRes.Location = new System.Drawing.Point(33, 110);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(322, 23);
            this.LblRes.TabIndex = 4;
            this.LblRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // BtnBack
            //
            this.BtnBack.Location = new System.Drawing.Point(100, 160);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 5;
            this.BtnBack.Text = "Retour";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            //
            // BtnQuitter
            //
            this.BtnQuitter.Location = new System.Drawing.Point(200, 160);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(75, 23);
            this.BtnQuitter.TabIndex = 6;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            //
            // frmFactoriel
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.TxtN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmFactoriel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcul factoriel";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtN;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnQuitter;
    }
}
