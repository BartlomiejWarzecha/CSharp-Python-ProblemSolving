using System;

namespace someFunctions
{

    class Program
    {
        public static int fibonacci(int number)
        {
            if (number == 0 | number == 1)
            {

                return number;

            }

            int[] fibonacciNumber = new int[number + 1];
            fibonacciNumber[0] = 0;
            fibonacciNumber[1] = 1;

            for (int i = 2; i <= number; i++)
            {
                fibonacciNumber[i] = fibonacciNumber[i - 1] + fibonacciNumber[i - 2];
            }

            return fibonacciNumber[number];
        }

        public static int getInt(int minimum = 0, int maximum = 10)
        {

            int number;
            string userInput;
            

            while (minimum >= maximum) {

                Console.WriteLine("Minimum value must be lower than maximum value, Please try again!");

            Console.WriteLine("What is minimum number?");
            userInput = Console.ReadLine();
            minimum = Convert.ToInt32(userInput);

            Console.WriteLine("What is maximum number?");
            userInput = Console.ReadLine();
            maximum = Convert.ToInt32(userInput);


            
            }

            Console.WriteLine("Write a number between {0} and {1}(-1 to end)", minimum, maximum);

            userInput = Console.ReadLine();
            number = Convert.ToInt32(userInput);

            if (number >= minimum & number <= maximum)
            {
                Console.WriteLine("This number {0} is correct! Returning your value!", number);
                return number;
            }
            else if (number == -1)
            {
                return -1;
            }
            else
            {
                Console.WriteLine("This number {0} is not correct! Please try again(-1 to end)", number);
                return getInt(minimum, maximum);
            }

        }

        public static void printNumberOfVowelsAndDigits(string phrase = "2312", int amountOfDigits = 0, int amountOfVowels = 0)
        {

            for (int i = 0; i < phrase.Length; i++) { 
                amountOfVowels += isVowel(phrase[i]);
                amountOfDigits += isDigit(phrase[i]);
            }

            Console.WriteLine("Number of digits in string \" {0} \" = {1} " +
                "Number of vowels = {2} ", phrase, amountOfDigits, amountOfVowels); 
        }

        public static int isVowel(char character)
        {
                switch (Char.ToLower(character))
                {
                    case 'a':
                    case 'o':
                    case 'e':
                    case 'i':
                    case 'u':
                    case 'y':
                        return 1;
                default: 
                    return 0;
                }
        }

        public static int isDigit(char character) 
        {
            if (character >= 48 & character <= 57)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        /*        public static void merge(int[n] tablica, int left = 0 , int right) {

            merge(tablica, left, right / 2);
            merge(tablica, , right / 2);

            if (tablica[left] > tablica[right]) {
                tmp = tablica[left]
            }

        }
        public static void divide(int left, int right) { 
            
        }
*/
        public static int howManyTimesInText(string phrase, string text) 
        {
            int count = 0;
            int lenPhrase = phrase.Length;
            int lenText = text.Length;

            for (int i = 0; i < lenText; i++) 
            { 

                    if (text[i] == phrase[0]) 
                    {

                    if (lenPhrase == 1) 
                    { 
                        count += 1;
                        continue;
                    }
                        for (int l = 1; l < lenPhrase;l++)
                        {
                            if (text[i + l] == phrase[l])
                            {
                                if (l + 1 == lenPhrase)
                                {
                                    count += 1;
                                    break;
                                }
                            } else
                            {
                                break;
                            }

                        } 
                    }
            }
            return count;
        }


        static void Main(string[] args)
        {
            string randomPhrase = "l";
            string randomText = "hello world hello c#";

            int countPhraseReapeating = howManyTimesInText(randomPhrase, randomText);

            Console.WriteLine($"String \"  {randomPhrase} \" is in text \" {randomText} \": {countPhraseReapeating} times ");
        }

    }

}


