using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptage
{
    class DecalDecrypt
    {
        private List<char> alphabet = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ' ' };
        private int clef; // clé qu'on va initiliser avec celle qu'on nous donne
        private int nouvposition; // donne la future position de la lettre
        private bool check; // booléan qui nous permettra de savoir si on a trouvé le bon caractere ou non
        private List<char> Texte = new List<char> { };
        public string result;
        private List<char> reschar = new List<char> { };

        public DecalDecrypt(string TexteTransmis, string ClefCryptage)
        {
            this.Texte = TexteTransmis.ToList<char>();
            try
            {
                this.clef = Int32.Parse(ClefCryptage); // transforme string en int et on initialise a la valeur transmise
            }
            catch (FormatException e) // exception
            {
                Console.WriteLine(e.Message);
            }

            for (int i = 0; i < this.Texte.Count; i++) // tant qu'il y a des char dans la list
            {  
                 check = false;
                 for (int j = 0; j < this.alphabet.Count; j++)
                 {
                      if (this.Texte[i] == this.alphabet[j])
                      {
                           nouvposition = j - clef;          //ici, on supprime le décalage qu'on ajouté
                           while (nouvposition < 0)         //au cas ou on sera on de la liste, 
                               nouvposition += this.alphabet.Count;// nous permet de revenir dedans
                            this.reschar.Insert(i, this.alphabet[nouvposition]); // insert le char décrypté
                            check = true; // false vrai car on l'a trouvé
                            break;
                        }
                    }
                    if (!check)
                        this.reschar.Insert(i, '#');
            }
            this.result = new string(this.reschar.ToArray<char>());

        }
    }
}

