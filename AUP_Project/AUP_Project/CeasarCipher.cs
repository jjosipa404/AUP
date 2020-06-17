using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUP_Project
{
    public static class CeasarCipher
    {
        // Encrypts text using a shift od s 
        public static string Encrypt(string text, int s)
        {
            //StringBuilder result = new StringBuilder();
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    //result.Append(' ');
                    result += ' ';
                }
                if (char.IsUpper(text[i]))
                {
                    char ch = (char)((text[i] + s - 65) % 26 + 65);
                    //result.Append(ch);
                    result += ch;
                    
                }
                //else
                //{
                //    char ch = (char)((text[i] +
                //                    s - 97) % 26 + 97);
                //    result.Append(ch);
                //}
            }

            return result;

        }

    }
}
