using System;

namespace Enkrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;


            Console.WriteLine("Write text to encrypt");
            text = Console.ReadLine();
            Console.WriteLine($"Text for encription = {text}");
            text = Encrypter.Encrypt(text);
            Console.WriteLine($"Text after encription = {text}");
            text = Encrypter.Decrypt(text);
            Console.WriteLine($"Text after decription = {text}");
        }
    }
}
