using System;
using System.IO;

namespace DisplayContext
{
    class Program
    {

        static void Main(string[] args)
        {
            string nameOfFile;
            if (args[0] != null)
            {
                nameOfFile = args[0];
                Console.WriteLine($"Name of file = {nameOfFile} ");
                Console.WriteLine($"Opening file = {nameOfFile} ");
                displayFileText(nameOfFile);
            }else{
                Console.WriteLine("Write name of file you want to open, with its extension ");
                nameOfFile = Console.ReadLine();
                Console.WriteLine($"Opening file = {nameOfFile}");
                displayFileText(nameOfFile);
            }

        }
    }
}
