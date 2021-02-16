using System;

namespace someFunctions
{

    class Program
    {
    public static int fibonacci(int number) {

        int[] fibonacciNumber = new int [number];
        fibonacciNumber[0] = 0;
        fibonacciNumber[1] = 1;

        for (int i = 2; i < number; i++) {
            fibonacciNumber[i] = fibonacciNumber[i - 1] + fibonacciNumber[i - 2];    
        }

        return fibonacciNumber[number-1];
    }

        public static int getInt(int minimum = 0, int maximum = 10) {

            int number;
            string userInput;

            Console.WriteLine("Write a number between {0} and {1}(-1 to end)", minimum, maximum);
            
            userInput = Console.ReadLine();
            number = Convert.ToInt32(userInput);

            if (number >= minimum & number <= maximum)
            {
                Console.WriteLine("This number {0} is correct! Returning your value!", number);
                return number;
            }
            else if (number == -1) {
                return -1; 
            }
            else
            {
                Console.WriteLine("This number {0} is not correct! Please try again(-1 to end)", number);
                return getInt(minimum, maximum);
            }
        
        
        }




        static void Main(string[] args)
        {
            int fibonacciNumber = 10;

            string userInput;
            int minimum;
            int maximum;
            int returnedValue;

            Console.WriteLine("Please write position of fibonacci number ");
            userInput = Console.ReadLine();
            fibonacciNumber = Convert.ToInt32(userInput);

            Console.WriteLine("Fibonacci Number on position {0} = {1}", fibonacciNumber, fibonacci(fibonacciNumber));

            Console.WriteLine("Please write minimum number ");
            userInput = Console.ReadLine();
            minimum = Convert.ToInt32(userInput);

            Console.WriteLine("Please write maximum number ");
            userInput = Console.ReadLine();
            maximum = Convert.ToInt32(userInput);

            returnedValue = getInt(minimum, maximum);
        }



    }
}
