using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptage
{
    
    class DecalEncrypt
    {
        private List<char> alphabet = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',' '};
        private int clef;
        private int nouvposition;
        private bool check ;
        private List<char> Texte = new List<char> { };
        public string rst;
        private List<char> reschar = new List<char> { };

        public DecalEncrypt(string message, string skey)
        {
            this.Texte = message.ToList<char>(); // transforme un string en une chaîne de caractère
            try
            {
                this.clef = Int32.Parse(skey); // la clef transmise à la classe est initialisé dans le code 
                                              // Transforme la clef transmise de string en int 
            }
            catch (FormatException e)   //exception
            {
                Console.WriteLine(e.Message);
            }
            
            for (int i = 0; i < this.Texte.Count; i++)   //messchar.Count permet de contrer le nombre de caractère dans la list
            {
                check = false;  // found = false car 
                for (int j = 0; j < this.alphabet.Count; j++) // j  plus petit que nos possibilités de nombres
                {
                    if (this.Texte[i] == this.alphabet[j])
                    {
                        nouvposition = j + clef; // nous donne notre position avec le décalage
                        while (nouvposition >= this.alphabet.Count)  // permet de retourner au début de notre chaine avec nos caractère si on 
                        nouvposition -= this.alphabet.Count;     // excede la taille limite 
                        this.reschar.Insert(i, this.alphabet[nouvposition]); // on réinsire dans notre chaine encrypté le résultat avec le décalage
                        check = true;
                        break;
                    }
                }
                if (!check)
                    this.reschar.Insert(i, '#');
                    // si caractère non trouvé on met un ! pour signaler que le caractère n'est pas disponible
            }
            this.rst = new string(this.reschar.ToArray<char>());
        }
    }
}