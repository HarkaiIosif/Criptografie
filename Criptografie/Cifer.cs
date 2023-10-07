using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Criptografie
{
    internal class Cifer
    {
        private int Key;
        private Dictionary<char, int> Encrypterchartoint = new Dictionary<char, int>();
        private Dictionary<int,char> Encrypterinttochar= new Dictionary<int,char>();
        public Cifer(int key)
        {
            Key = key;
            CreateEncrypterDictionary1();
            CreateEncrypterDictionary2();
        }
        public string Encrypt(string imputmessage)
        {
            bool uppercase = false;
            char[] chars = imputmessage.ToCharArray();
            for(int i=0; i<chars.Length; i++)
            {
                if (Char.IsLetter(chars[i]))
                {
                    if (Char.IsUpper(chars[i]))
                    {
                        uppercase=true;
                        chars[i]=Char.ToLower(chars[i]);
                    }
                    chars[i] = EncryptLetter(chars[i]);
                    if (uppercase == true)
                    {
                        chars[i] = Char.ToUpper(chars[i]);
                        uppercase = false;
                    }
                }
            }
            string encryptedmessage =new string(chars);
            return encryptedmessage;
        }
        public string Decrypt()
        {
            string decryptedmessage=string.Empty;
            return decryptedmessage;
        }
        public string Analasys(string imputmessage)
        {
            string analasysresult=string.Empty;
            return analasysresult;
        }
        private void CreateEncrypterDictionary1()
        {
            Encrypterchartoint.Add('a', 1);
            Encrypterchartoint.Add('b', 2);
            Encrypterchartoint.Add('c', 3);
            Encrypterchartoint.Add('d', 4);
            Encrypterchartoint.Add('e', 5);
            Encrypterchartoint.Add('f', 6);
            Encrypterchartoint.Add('g', 7);
            Encrypterchartoint.Add('h', 8);
            Encrypterchartoint.Add('i', 9);
            Encrypterchartoint.Add('j', 10);
            Encrypterchartoint.Add('k', 11);
            Encrypterchartoint.Add('l', 12);
            Encrypterchartoint.Add('m', 13);
            Encrypterchartoint.Add('n', 14);
            Encrypterchartoint.Add('o', 15);
            Encrypterchartoint.Add('p', 16);
            Encrypterchartoint.Add('q', 17);
            Encrypterchartoint.Add('r', 18);
            Encrypterchartoint.Add('s', 19);
            Encrypterchartoint.Add('t', 20);
            Encrypterchartoint.Add('u', 21);
            Encrypterchartoint.Add('v', 22);
            Encrypterchartoint.Add('w', 23);
            Encrypterchartoint.Add('x', 24);
            Encrypterchartoint.Add('y', 25);
            Encrypterchartoint.Add('z', 26);
        }
        private void CreateEncrypterDictionary2()
        {
            Encrypterinttochar.Add(1, 'a');
            Encrypterinttochar.Add(2, 'b');
            Encrypterinttochar.Add(3, 'c');
            Encrypterinttochar.Add(4, 'd');
            Encrypterinttochar.Add(5, 'e');
            Encrypterinttochar.Add(6, 'f');
            Encrypterinttochar.Add(7, 'g');
            Encrypterinttochar.Add(8, 'h');
            Encrypterinttochar.Add(9, 'i')  ;
            Encrypterinttochar.Add(10, 'j');
            Encrypterinttochar.Add(11, 'k');
            Encrypterinttochar.Add(12, 'l');
            Encrypterinttochar.Add(13, 'm');
            Encrypterinttochar.Add(14, 'n');
            Encrypterinttochar.Add(15, 'o');
            Encrypterinttochar.Add(16, 'p');
            Encrypterinttochar.Add(17, 'q');
            Encrypterinttochar.Add(18, 'r');
            Encrypterinttochar.Add(19, 's');
            Encrypterinttochar.Add(20, 't');
            Encrypterinttochar.Add(21, 'u');
            Encrypterinttochar.Add(22, 'v');
            Encrypterinttochar.Add(23, 'w');
            Encrypterinttochar.Add(24, 'x');
            Encrypterinttochar.Add(25, 'y');
            Encrypterinttochar.Add(26,'z');
        }
        private char EncryptLetter(char letter)
        {
            int intermediary = Encrypterchartoint[letter];
            intermediary = (intermediary + this.Key) % 26;
            char toReturn = Encrypterinttochar[intermediary];
            return toReturn;
        }
    }
}
