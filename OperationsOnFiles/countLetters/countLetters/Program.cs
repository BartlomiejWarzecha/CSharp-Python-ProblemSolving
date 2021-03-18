using System;
using System.IO;

namespace countLetters
{
    class Program
    {
        public static void howManyTimesInTextFile(string fileName, char letter)
        {

            int count = 0;
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        for (int i = 0; i < line.Length; i++)
                        {
                            if (line[i] == letter) 
                            {
                                count++;
                            }
                        }
                    }
                    Console.WriteLine($" Program found {count} letters '{letter}'in the text");
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
            char letterToFind = 'a';
            howManyTimesInTextFile("testFile.txt", letterToFind);
        }
    }
}
