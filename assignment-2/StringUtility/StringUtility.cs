using System;

namespace StringUtility
{
    public class StringUtility
    {
        public string ReverseString(string str)
        {
            string newStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                newStr += str[i];
            }
            return newStr;
        }
        public string ToUppercase(string str)
        {
            string newStr = "";
            foreach (char c in str)
            {
                if (c >= 'a' && c <= 'z' || (c == 'æ' || c == 'ø' || c == 'å'))
                {
                    newStr += (char)(c - 32);
                }
                else
                {
                    newStr += c;
                }
            }
            return newStr;
        }
        public string ToLowercase(string str)
        {
            string newStr = "";
            foreach (char c in str)
            {
                if (c >= 'A' && c <= 'Z' || (c == 'Æ' || c == 'Ø' || c == 'Å'))
                {
                    newStr += (char)(c + 32);
                }
                else
                {
                    newStr += c;
                }
            }
            return newStr;
        }

    }
}
