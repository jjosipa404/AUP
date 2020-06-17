using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUP_Project
{
    public static class XORCipher
    {
        // The same function is used to encrypt and 
        // decrypt 
        public static string EncryptDecrypt(string inputString)
        {
            // Define XOR key
            // Any character value will work
            string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random g = new Random();
            int x = g.Next(0, 25);
            char xorKey = abc[x];

            // Define String to store encrypted/decrypted String 
            string outputString = "";
            inputString = inputString.ToLower();
            // calculate length of input string 
            int len = inputString.Length;

            // perform XOR operation of key 
            // with every character in string 
            for (int i = 0; i < len; i++)
            {
                char ch = (char)(inputString[i] ^ xorKey);
                outputString += ch;
            }
            return outputString;
        }

    }
}
