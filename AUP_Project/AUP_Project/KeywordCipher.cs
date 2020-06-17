using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUP_Project
{
    public static class KeywordCipher
    {
        public static string Encoder(char[] key)
        {
            string encoded = "";

            // This array represents the 
            // 26 letters of alphabets 
            bool[] arr = new bool[26];

            // This loop inserts the keyword 
            // at the start of the encoded string 
            for (int i = 0; i < key.Length; i++)
            {
                if (key[i] >= 'A' && key[i] <= 'Z')
                {
                    // To check whether the character is inserted 
                    // earlier in the encoded string or not 
                    if (arr[key[i] - 65] == false)
                    {
                        encoded += key[i];
                        arr[key[i] - 65] = true;
                    }
                }
                //else if (key[i] >= 'a' && key[i] <= 'z')
                //{
                //    if (arr[key[i] - 97] == false)
                //    {
                //        encoded += (char)(key[i] - 32);
                //        arr[key[i] - 97] = true;
                //    }
                //}
            }

            // This loop inserts the remaining 
            // characters in the encoded string. 
            for (int i = 0; i < 26; i++)
            {
                if (arr[i] == false)
                {
                    arr[i] = true;
                    encoded += (char)(i + 65);
                }
            }
            return encoded;

        }


        // Function that generates encodes(cipher) the message 
        public static string CipherIt(string msg, string encoded)
        {
            string cipher = "";

            // This loop ciphered the message. 
            // Spaces, special characters and numbers remain same. 
            for (int i = 0; i < msg.Length; i++)
            {
                if (msg[i] >= 'a' && msg[i] <= 'z')
                {
                    int pos = msg[i] - 97;
                    cipher += encoded[pos];
                }
                else if (msg[i] >= 'A' && msg[i] <= 'Z')
                {
                    int pos = msg[i] - 65;
                    cipher += encoded[pos];
                }
                else
                {
                    cipher += msg[i];
                }
            }
            return cipher;
        }


        public static string DecipherIt(string msg, string encoded)
        {
            string plaintext = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // Hold the position of every character (A-Z) 
            // from encoded string 
            Dictionary<char, int> enc = new Dictionary<char, int>();
            for (int i = 0; i < encoded.Count(); i++)
            {
                enc[encoded[i]] = i;
            }

            string decipher = "";

            // This loop deciphered the message. 
            // Spaces, special characters and numbers remain same. 
            for (int i = 0; i < msg.Count(); i++)
            {
                //if (msg[i] >= 'a' && msg[i] <= 'z')
                //{
                //    int pos = enc[(char)(msg[i] - 32)];
                //    decipher += plaintext[pos];
                //}
                if (msg[i] >= 'A' && msg[i] <= 'Z')
                {
                    int pos = enc[msg[i]];
                    decipher += plaintext[pos];
                }
                else
                {
                    decipher += msg[i];
                }
            }
            return decipher;
        }
    }
}
