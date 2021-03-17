using System;
using System.IO;

namespace DisplayContext
{
    class Program
    {
        public static void displayFileText(string fileName) 
        {
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

        }
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
