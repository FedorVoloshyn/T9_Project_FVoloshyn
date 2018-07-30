using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T9_Project_FVoloshyn
{
    class T9Engine : IT9Encodeble
    {
        private Dictionary<char, string> dictionary;

        public T9Engine()
        {
            InitDictionary();
        }

        public string LetterToNumber(char letter)
        {
            string numberKeyOfLetter;
            dictionary.TryGetValue(letter, out numberKeyOfLetter);
            return numberKeyOfLetter;
        }

        public string TextToNumber(string text)
        {
            if (text.Length == 0)
                return "";

            StringBuilder t9EncodeRusult = new StringBuilder();
            t9EncodeRusult.AppendFormat(this.LetterToNumber(text[0]));
            
            for (int i = 1; i < text.Length; i++)
            {
                char previousNumber = t9EncodeRusult[t9EncodeRusult.Length - 1];
                string currentNumber = this.LetterToNumber(text[i]);
                if (previousNumber == currentNumber[0])
                {
                    t9EncodeRusult.AppendFormat(" ");
                }
                t9EncodeRusult.AppendFormat(currentNumber);
            }

            return t9EncodeRusult.ToString();
        }

        private void InitDictionary()
        {
            this.dictionary = new Dictionary<char, string>();

            dictionary.Add('a', "2");
            dictionary.Add('b', "22");
            dictionary.Add('c', "222");

            dictionary.Add('d', "3");
            dictionary.Add('e', "33");
            dictionary.Add('f', "333");

            dictionary.Add('g', "4");
            dictionary.Add('h', "44");
            dictionary.Add('i', "444");

            dictionary.Add('j', "5");
            dictionary.Add('k', "55");
            dictionary.Add('l', "555");

            dictionary.Add('m', "6");
            dictionary.Add('n', "66");
            dictionary.Add('o', "666");

            dictionary.Add('p', "7");
            dictionary.Add('q', "77");
            dictionary.Add('r', "777");
            dictionary.Add('s', "7777");

            dictionary.Add('t', "8");
            dictionary.Add('u', "88");
            dictionary.Add('v', "888");

            dictionary.Add('w', "9");
            dictionary.Add('x', "99");
            dictionary.Add('y', "999");
            dictionary.Add('z', "9999");

            dictionary.Add(' ', "0");
        }
    }
}
