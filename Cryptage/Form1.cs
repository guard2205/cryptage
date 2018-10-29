using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CryptageP_Bouton(object sender, EventArgs e)
        {
            DecalEncrypt CeasarCryptage = new DecalEncrypt(TextACrypter.Text, Clef.Text);
            TextCrypte.Text = CeasarCryptage.rst;
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            DecalDecrypt CeasarDecryptage = new DecalDecrypt(TextCrypte.Text, Clef.Text);
            TextDecrypte.Text = CeasarDecryptage.result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CryptorEngine NetCryptage = new CryptorEngine(TextACrypter.Text, Clef.Text, 0);
            TextCrypte.Text = NetCryptage.rst;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CryptorEngine NetDecryptage = new CryptorEngine(TextCrypte.Text, Clef.Text, 1);
            TextDecrypte.Text = NetDecryptage.rst;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void TextCrypte_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
