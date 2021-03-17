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


            while (minimum >= maximum)
            {

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

            for (int i = 0; i < phrase.Length; i++)
            {
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
            int subString = 0;

            for (int i = 0; i < lenText; i++)
            {

                if (text[i] == phrase[0] | text[i] == phrase[subString])
                {

                    if (lenPhrase == 1)
                    {
                        count += 1;
                        continue;
                    }

                    for (int l = 1; l < lenPhrase; l++)
                    {
                        if (text[i + l] == phrase[l])
                        {
                            if (l + 1 == lenPhrase)
                            {
                                count += 1;
                                break;
                            }
                        }
                        else
                        {
                            subString = l;
                            break;
                        }
                    }

                    if (subString != 0)
                    {
                        for (int l = 1; l < lenPhrase - subString; l++)
                        {
                            if (text[i + l] == phrase[subString + l])
                            {
                                if (subString + 1 == lenPhrase)
                                {
                                    count += 1;
                                    subString = 0;
                                    break;
                                }
                            }

                        }
                    }
                }
            }
            return count;
        }

        public static void isPalindrom(string text)
        {
            int halfStringLength = text.Length/2;
            int stringLength = text.Length - 1;
            Boolean isPalindrom = false;

                for(int i = 0; i < halfStringLength; i++)
                {
                    if (text[i] == text[stringLength])
                    {
                        isPalindrom = true;
                        stringLength--;
                        continue;
                    }
                    isPalindrom = false;
                    break;
                }

            if (isPalindrom)
            {
                Console.WriteLine($"This string {text} is Palindrom");
            }
            else
            {
                Console.WriteLine($"This string {text} is not Palindrom");
            }
        }

        public static void getMinMax()
        {
            int minValue = 0;
            int maxValue = 0;
            bool success = false;

            while (minValue >= maxValue) {

                while (success != true)
                {
                    Console.WriteLine("Enter minimum value: ");
                    success = Int32.TryParse(Console.ReadLine(), out minValue);

                    if (!success)
                    {
                        Console.WriteLine("Something went wrong please try again");
                        continue;
                    }

                    success = true;
                }

                success = false;

                while (success != true)
                {
                    Console.WriteLine("Enter maximum value: ");
                    success = Int32.TryParse(Console.ReadLine(), out maxValue);

                    if (!success)
                    {
                        Console.WriteLine("Something went wrong please try again");
                        continue;
                    }
                    if (minValue >= maxValue)
                    {
                        Console.WriteLine($"Max value must be larger than min value: > {minValue}");
                        Console.WriteLine($"Please try again");
                        continue;
                    }

                    success = true;
                }
    
            }

            Console.WriteLine($"Minimum number  = {minValue} Maximum number  = {maxValue}");

        }

        public static void printReverseText(string text) 
        {
            int textLength = text.Length;
            string reverseText = "";
            
            while (textLength != 0) 
            {
                reverseText += text[textLength - 1];
                textLength--;
            }
            Console.WriteLine($"Reversed text  = {reverseText}");
        }

        public static string reverseText(string text) 
        {
            if (text.Length <= 1)
            {
                return text;
            }

            char firstLetter = text[0];
            string rest = text.Substring(1);


            return reverseText(rest) + firstLetter;

        }
        public static void Main(string[] args)
        {

            string name = "bartek";
            name = reverseText(name);

            Console.WriteLine(name);

        }     
    }
}

