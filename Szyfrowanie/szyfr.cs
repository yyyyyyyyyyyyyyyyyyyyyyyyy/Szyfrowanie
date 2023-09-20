using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Szyfrowanie
{
    class szyfr
    {


        public static string Szyfring(string text, int key)
        {
            char[] result = new char[text.Length];



            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];
                if (char.IsLetter(ch))
                {
                    char baseChar = char.IsLower(ch) ? 'a' : 'A';
                    result[i] = (char)(((ch - baseChar + key) % 26 + 26) % 26 + baseChar);
                }
                else
                {
                    result[i] = ch;
                }
            }



            return new string(result);
        }



        public static string NieSzyfring(string text, int key)
        {
            return Szyfring(text, 26 - key);
        }
    }
}