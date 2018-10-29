using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Cryptage
{
    public class CryptorEngine
    {
        public string rst;

        public CryptorEngine(string texte, string clef, int direction)
        {
            if (direction == 0) rst = Crypter(texte, clef);
            else rst = Decrypter(texte, clef);
        }
        public static string Crypter(string texte_clair, string clef)
        {
            int i = 0;
            byte[] buffer;
            byte[] keyArray = new byte[16];
            for (i = 0; i < 16; i++)
            {
                keyArray[i] = (byte)'a';
            }
            byte[] textAsByte = UTF8Encoding.UTF8.GetBytes(texte_clair);
            buffer = UTF8Encoding.UTF8.GetBytes(clef);
            for (i = 0; i < buffer.Length; i++)
            {
                keyArray[i] = buffer[i];
            }

            AesCryptoServiceProvider ACSP = new AesCryptoServiceProvider();
            ACSP.Key = keyArray;
            ACSP.Mode = CipherMode.ECB;
            ACSP.Padding = PaddingMode.PKCS7;

            ICryptoTransform encryptor = ACSP.CreateEncryptor();
            byte[] cryptedTextAsByte = encryptor.TransformFinalBlock(textAsByte, 0, textAsByte.Length);
            ACSP.Clear();

            return Convert.ToBase64String(cryptedTextAsByte);
        }

        public static string Decrypter(string texte_crypte, string clef)
        {
            int i = 0;
            byte[] buffer;
            byte[] keyArray = new byte[16];
            for (i = 0; i < 16; i++)
            {
                keyArray[i] = (byte)'a';
            }
            byte[] cryptedTextAsByte = Convert.FromBase64String(texte_crypte);
            buffer = UTF8Encoding.UTF8.GetBytes(clef);
            for (i = 0; i < buffer.Length; i++)
            {
                keyArray[i] = buffer[i];
            }

            AesCryptoServiceProvider ACSP = new AesCryptoServiceProvider();
            ACSP.Key = keyArray;
            ACSP.Mode = CipherMode.ECB;
            ACSP.Padding = PaddingMode.PKCS7;

            ICryptoTransform decryptor = ACSP.CreateDecryptor();
            byte[] decryptedTextAsByte = decryptor.TransformFinalBlock(cryptedTextAsByte, 0, cryptedTextAsByte.Length);

            return Encoding.Default.GetString(decryptedTextAsByte);
        }
    }
}
