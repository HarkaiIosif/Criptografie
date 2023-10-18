using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografie
{
    internal class MonalfabeticCipher
    {
        private Dictionary<char, int> Encrypterchartoint = new Dictionary<char, int>();
        private List<char> Encrypterinttochar = new List<char>();
        private List<char> StandardAlphabet = new List<char>();
        private char[] MostCommonEnglishLetter = new char[26];
        public MonalfabeticCipher()
        {
            CreateEncrypterList(Encrypterinttochar);
            CreateEncrypterList(StandardAlphabet);
            CreateEncrypterDictionary1();
            ShuffleList();
            EnglishAlphabetOrder();
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
        private void ShuffleList()
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
        private void EnglishAlphabetOrder()
        {
            MostCommonEnglishLetter[0] = 'e';
            MostCommonEnglishLetter[1] = 't';
            MostCommonEnglishLetter[2] = 'a';
            MostCommonEnglishLetter[3] = 'o';
            MostCommonEnglishLetter[4] = 'i';
            MostCommonEnglishLetter[5] = 'n';
            MostCommonEnglishLetter[6] = 's';
            MostCommonEnglishLetter[7] = 'r';
            MostCommonEnglishLetter[8] = 'h';
            MostCommonEnglishLetter[9] = 'l';
            MostCommonEnglishLetter[10] = 'd';
            MostCommonEnglishLetter[11] = 'c';
            MostCommonEnglishLetter[12] = 'u';
            MostCommonEnglishLetter[13] = 'm';
            MostCommonEnglishLetter[14] = 'f';
            MostCommonEnglishLetter[15] = 'p';
            MostCommonEnglishLetter[16] = 'g';
            MostCommonEnglishLetter[17] = 'w';
            MostCommonEnglishLetter[18] = 'y';
            MostCommonEnglishLetter[19] = 'b';
            MostCommonEnglishLetter[20] = 'v';
            MostCommonEnglishLetter[21] = 'k';
            MostCommonEnglishLetter[22] = 'x';
            MostCommonEnglishLetter[23] = 'j';
            MostCommonEnglishLetter[24] = 'q';
            MostCommonEnglishLetter[25] = 'z';
        }
        public string Analysys(string imputmessage)
        {
            char[] letters=imputmessage.ToCharArray();
            int[] numberof=new int[MostCommonEnglishLetter.Length];
            foreach(char letter in letters)
            {
                if (Char.IsLetter(letter)) 
                {
                    if (Char.IsUpper(letter))
                    {
                        numberof[Encrypterinttochar.IndexOf(Char.ToLower(letter))]++;
                    }
                    else numberof[Encrypterinttochar.IndexOf(letter)]++;
                }
            }
            char[] Sorted=Encrypterinttochar.ToArray();
            for(int i=0;i<numberof.Length-1;i++)
            {
                int index = i;
                for(int j = i+1; j < numberof.Length; j++)
                {
                    if (numberof[j] > numberof[index])
                    {
                        index= j;
                    }
                }
                (numberof[i], numberof[index]) = (numberof[index], numberof[i]);
                (Sorted[i], Sorted[index]) = (Sorted[index], Sorted[i]);
            }
            List<char> SortedList=Sorted.ToList();
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
                    chars[i] = AnalyseLetter(chars[i],SortedList);
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
        private char AnalyseLetter(char letter,List<char>List)
        {
            int intermediary=List.IndexOf(letter);
            char toReturn = MostCommonEnglishLetter[intermediary];
            return toReturn;
        }
    }
}
