using System;
using System.Collections.Generic;
using System.Text;

namespace Enkrypter
{
    class Encrypter
    {
        public static string Encrypt(string text)
        {
            int intLetter;
            char encriptedLetter;
            string encriptedText = "";

            for (int i = 0; i < text.Length; i++)
            {
                intLetter = (int)text[i] + 1;
                encriptedLetter = (char)intLetter;
                encriptedText += encriptedLetter.ToString();
            }
            return encriptedText;
        }
    

        public static string Decrypt(string text)
        {
            int intLetter;
            char decriptedLetter;
            string decriptedText = "";

            for (int i = 0; i < text.Length; i++)
            {
                intLetter = (int)text[i] - 1;
                decriptedLetter = (char)intLetter;
                decriptedText += decriptedLetter.ToString();
            }
            return decriptedText;
        }
    }
}
