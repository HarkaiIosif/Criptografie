using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografie
{
    internal class MonalfabeticCifer
    {
        private Dictionary<char, int> Encrypterchartoint = new Dictionary<char, int>();
        private List<char> Encrypterinttochar = new List<char>();
        private List<char> StandardAlphabet = new List<char>();
        public MonalfabeticCifer()
        {
            CreateEncrypterList(Encrypterinttochar);
            CreateEncrypterList(StandardAlphabet);
            CreateEncrypterDictionary1();
            ShuffleArray();

        }
        private void CreateEncrypterDictionary1()
        {
            Encrypterchartoint.Add('a', 0);
            Encrypterchartoint.Add('b', 1);
            Encrypterchartoint.Add('c', 2);
            Encrypterchartoint.Add('d', 3);
            Encrypterchartoint.Add('e', 4);
            Encrypterchartoint.Add('f', 5);
            Encrypterchartoint.Add('g', 6);
            Encrypterchartoint.Add('h', 7);
            Encrypterchartoint.Add('i', 8);
            Encrypterchartoint.Add('j', 9);
            Encrypterchartoint.Add('k', 10);
            Encrypterchartoint.Add('l', 11);
            Encrypterchartoint.Add('m', 12);
            Encrypterchartoint.Add('n', 13);
            Encrypterchartoint.Add('o', 14);
            Encrypterchartoint.Add('p', 15);
            Encrypterchartoint.Add('q', 16);
            Encrypterchartoint.Add('r', 17);
            Encrypterchartoint.Add('s', 18);
            Encrypterchartoint.Add('t', 19);
            Encrypterchartoint.Add('u', 20);
            Encrypterchartoint.Add('v', 21);
            Encrypterchartoint.Add('w', 22);
            Encrypterchartoint.Add('x', 23);
            Encrypterchartoint.Add('y', 24);
            Encrypterchartoint.Add('z', 25);
        }
        private void CreateEncrypterList(List<char> list)
        {
            list.Add('a');
            list.Add('b');
            list.Add('c');
            list.Add('d');
            list.Add('e');
            list.Add('f');
            list.Add('g');
            list.Add('h');
            list.Add('i');
            list.Add('j');
            list.Add('k');
            list.Add('l');
            list.Add('m');
            list.Add('n');
            list.Add('o');
            list.Add('p');
            list.Add('q');
            list.Add('r');
            list.Add('s');
            list.Add('t');
            list.Add('u');
            list.Add('v');
            list.Add('w');
            list.Add('x');
            list.Add('y');
            list.Add('z');
        }   
        private void ShuffleArray()
        {
            Random rnd = new Random();
            for (int i = 0; i < Encrypterinttochar.Count; i++)
            {
                int changeto = rnd.Next(0, Encrypterinttochar.Count);
                (Encrypterinttochar[i], Encrypterinttochar[changeto]) = (Encrypterinttochar[changeto], Encrypterinttochar[i]);
            }
        }
        public string Encrypt(string imputmessage)
        {
            bool uppercase = false;
            char[] chars = imputmessage.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (Char.IsLetter(chars[i]))
                {
                    if (Char.IsUpper(chars[i]))
                    {
                        uppercase = true;
                        chars[i] = Char.ToLower(chars[i]);
                    }
                    chars[i] = EncryptLetter(chars[i]);
                    if (uppercase == true)
                    {
                        chars[i] = Char.ToUpper(chars[i]);
                        uppercase = false;
                    }
                }
            }
            string encryptedmessage = new string(chars);
            return encryptedmessage;
        }
        private char EncryptLetter(char letter)
        {
            int intermediary = Encrypterchartoint[letter];
            char toReturn = Encrypterinttochar[intermediary];
            return toReturn;
        }
        public string Decrypt(string imputmessage)
        {
            bool uppercase = false;
            char[] chars = imputmessage.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (Char.IsLetter(chars[i]))
                {
                    if (Char.IsUpper(chars[i]))
                    {
                        uppercase = true;
                        chars[i] = Char.ToLower(chars[i]);
                    }
                    chars[i] = DecryptLetter(chars[i]);
                    if (uppercase == true)
                    {
                        chars[i] = Char.ToUpper(chars[i]);
                        uppercase = false;
                    }
                }
            }
            string decryptedmessage = new string(chars);
            return decryptedmessage;
        }
        public char DecryptLetter(char letter)
        {
           int intermediary=Encrypterinttochar.IndexOf(letter);
           char toReturn = StandardAlphabet[intermediary];    
           return toReturn;
        }
    }
}
