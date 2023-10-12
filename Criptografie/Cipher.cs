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
        public string Decrypt(string imputmessage)
        {
            return Decrypt(imputmessage,this.Key);
        }
        public string Decrypt(string imputmessage,int DecryptionKey)
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
                    chars[i] = DecryptLetter(chars[i],DecryptionKey);
                    if (uppercase == true)
                    {
                        chars[i] = Char.ToUpper(chars[i]);
                        uppercase = false;
                    }
                }
            }
            string decryptedmessage=new string(chars);
            return decryptedmessage;
        }
        public virtual void Analasys(string imputmessage)
        {
            for(int i=0;i<26;i++)
            {
                Console.WriteLine(Decrypt(imputmessage, i));
            }
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
        private void CreateEncrypterDictionary2()
        {
            Encrypterinttochar.Add(0, 'a');
            Encrypterinttochar.Add(1, 'b');
            Encrypterinttochar.Add(2, 'c');
            Encrypterinttochar.Add(3, 'd');
            Encrypterinttochar.Add(4, 'e');
            Encrypterinttochar.Add(5, 'f');
            Encrypterinttochar.Add(6, 'g');
            Encrypterinttochar.Add(7, 'h');
            Encrypterinttochar.Add(8, 'i')  ;
            Encrypterinttochar.Add(9, 'j');
            Encrypterinttochar.Add(10, 'k');
            Encrypterinttochar.Add(11, 'l');
            Encrypterinttochar.Add(12, 'm');
            Encrypterinttochar.Add(13, 'n');
            Encrypterinttochar.Add(14, 'o');
            Encrypterinttochar.Add(15, 'p');
            Encrypterinttochar.Add(16, 'q');
            Encrypterinttochar.Add(17, 'r');
            Encrypterinttochar.Add(18, 's');
            Encrypterinttochar.Add(19, 't');
            Encrypterinttochar.Add(20, 'u');
            Encrypterinttochar.Add(21, 'v');
            Encrypterinttochar.Add(22, 'w');
            Encrypterinttochar.Add(23, 'x');
            Encrypterinttochar.Add(24, 'y');
            Encrypterinttochar.Add(25,'z');
        }
        private char EncryptLetter(char letter)
        {
            int intermediary = Encrypterchartoint[letter];
            intermediary = (intermediary + this.Key) % 26;
            char toReturn = Encrypterinttochar[intermediary];
            return toReturn;
        }
        private char DecryptLetter(char letter,int DecryptionKey)
        {
            int intermediary = Encrypterchartoint[letter];
            intermediary = (intermediary - DecryptionKey);
            if (intermediary < 0) intermediary += 26;
            char toReturn = Encrypterinttochar[intermediary];
            return toReturn;
        }
    }
}
