namespace Cryptage
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button CryptageP_Bouton;
            this.TextACrypter = new System.Windows.Forms.TextBox();
            this.TextCrypte = new System.Windows.Forms.TextBox();
            this.TextDecrypte = new System.Windows.Forms.TextBox();
            this.Clef = new System.Windows.Forms.TextBox();
            this.CryptageN_Bouton = new System.Windows.Forms.Button();
            this.DecryptageN_Bouton = new System.Windows.Forms.Button();
            this.Decryptage_Bouton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            CryptageP_Bouton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CryptageP_Bouton
            // 
            CryptageP_Bouton.Location = new System.Drawing.Point(173, 34);
            CryptageP_Bouton.Name = "CryptageP_Bouton";
            CryptageP_Bouton.Size = new System.Drawing.Size(111, 49);
            CryptageP_Bouton.TabIndex = 4;
            CryptageP_Bouton.Text = "Cryptage perso";
            CryptageP_Bouton.UseVisualStyleBackColor = true;
            CryptageP_Bouton.Click += new System.EventHandler(this.CryptageP_Bouton);
            // 
            // TextACrypter
            // 
            this.TextACrypter.Location = new System.Drawing.Point(27, 44);
            this.TextACrypter.Name = "TextACrypter";
            this.TextACrypter.Size = new System.Drawing.Size(100, 22);
            this.TextACrypter.TabIndex = 0;
            // 
            // TextCrypte
            // 
            this.TextCrypte.Location = new System.Drawing.Point(315, 44);
            this.TextCrypte.Name = "TextCrypte";
            this.TextCrypte.Size = new System.Drawing.Size(100, 22);
            this.TextCrypte.TabIndex = 1;
            this.TextCrypte.TextChanged += new System.EventHandler(this.TextCrypte_TextChanged);
            // 
            // TextDecrypte
            // 
            this.TextDecrypte.Location = new System.Drawing.Point(618, 44);
            this.TextDecrypte.Name = "TextDecrypte";
            this.TextDecrypte.Size = new System.Drawing.Size(100, 22);
            this.TextDecrypte.TabIndex = 2;
            // 
            // Clef
            // 
            this.Clef.Location = new System.Drawing.Point(315, 129);
            this.Clef.Name = "Clef";
            this.Clef.Size = new System.Drawing.Size(100, 22);
            this.Clef.TabIndex = 3;
            // 
            // CryptageN_Bouton
            // 
            this.CryptageN_Bouton.Location = new System.Drawing.Point(173, 119);
            this.CryptageN_Bouton.Name = "CryptageN_Bouton";
            this.CryptageN_Bouton.Size = new System.Drawing.Size(111, 48);
            this.CryptageN_Bouton.TabIndex = 5;
            this.CryptageN_Bouton.Text = "Cryptage .NET";
            this.CryptageN_Bouton.UseVisualStyleBackColor = true;
            this.CryptageN_Bouton.Click += new System.EventHandler(this.button2_Click);
            // 
            // DecryptageN_Bouton
            // 
            this.DecryptageN_Bouton.Location = new System.Drawing.Point(474, 119);
            this.DecryptageN_Bouton.Name = "DecryptageN_Bouton";
            this.DecryptageN_Bouton.Size = new System.Drawing.Size(135, 48);
            this.DecryptageN_Bouton.TabIndex = 6;
            this.DecryptageN_Bouton.Text = "Decryptage .NET";
            this.DecryptageN_Bouton.UseVisualStyleBackColor = true;
            this.DecryptageN_Bouton.Click += new System.EventHandler(this.button3_Click);
            // 
            // Decryptage_Bouton
            // 
            this.Decryptage_Bouton.Location = new System.Drawing.Point(474, 34);
            this.Decryptage_Bouton.Name = "Decryptage_Bouton";
            this.Decryptage_Bouton.Size = new System.Drawing.Size(135, 49);
            this.Decryptage_Bouton.TabIndex = 7;
            this.Decryptage_Bouton.Text = "Decryptage perso";
            this.Decryptage_Bouton.UseVisualStyleBackColor = true;
            this.Decryptage_Bouton.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Clé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Texte à crypter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Texte crypté";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(615, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Texte décrypté";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(765, 296);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Decryptage_Bouton);
            this.Controls.Add(this.DecryptageN_Bouton);
            this.Controls.Add(this.CryptageN_Bouton);
            this.Controls.Add(CryptageP_Bouton);
            this.Controls.Add(this.Clef);
            this.Controls.Add(this.TextDecrypte);
            this.Controls.Add(this.TextCrypte);
            this.Controls.Add(this.TextACrypter);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextACrypter;
        private System.Windows.Forms.TextBox TextCrypte;
        private System.Windows.Forms.TextBox TextDecrypte;
        private System.Windows.Forms.TextBox Clef;
        private System.Windows.Forms.Button CryptageN_Bouton;
        private System.Windows.Forms.Button DecryptageN_Bouton;
        private System.Windows.Forms.Button Decryptage_Bouton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

