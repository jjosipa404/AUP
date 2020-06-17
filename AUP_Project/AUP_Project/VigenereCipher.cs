using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUP_Project
{
    public static class VigenereCipher
    {
        // This function generates the key in 
        // a cyclic manner until it's length isi'nt 
        // equal to the length of original text 
        public static string GenerateKey(string str, string key)
        {
            int x = str.Length;

            for (int i = 0; ; i++)
            {
                if (x == i)
                    i = 0;
                if (key.Length == str.Length)
                    break;
                key += (key[i]);
            }
            return key;
        }

        // This function returns the encrypted text 
        // generated with the help of the key 
        public static string Encription(string str, string key)
        {
            string cipher_text = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    cipher_text += ' ';
                }
                else
                {
                    // converting in range 0-25 
                    int x = (str[i] + key[i]) % 26;

                    // convert into alphabets(ASCII) 
                    x += 'A';

                    cipher_text += (char)(x);
                }
                
            }
            return cipher_text;
        }

        // This function decrypts the encrypted text 
        // and returns the original text 
        public static string Decryption(string cipher_text, string key)
        {
            string orig_text = "";

            for (int i = 0; i < cipher_text.Length && i < key.Length; i++)
            {
                if (cipher_text[i] == ' ')
                {
                    orig_text += ' ';
                }
                else
                {
                    // converting in range 0-25 
                    int x = (cipher_text[i] - key[i] + 26) % 26;
                    // convert into alphabets(ASCII) 
                    x += 'A';
                    orig_text += (char)(x);
                }
            }
            return orig_text;
        }


    }
}
