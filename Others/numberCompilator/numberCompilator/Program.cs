using System;

namespace numberCompilator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string numberToCheck = "";
            char digit;
            bool coma = false;
            bool end = false;
            int j = 0;

            while(!end)
            {
                Console.WriteLine("Write one digit, if you want to end write + ");
                digit = Console.ReadLine()[0];
                
                if (digit == '+')
                {
                    Console.WriteLine("Exiting Program");
                    end = true;
                    continue;
                }

                numberToCheck += digit;
                
                if (numberToCheck[j] == ',' && coma == true) 
                {
                    Console.WriteLine("Number cannot have muliplied , try again");
                    numberToCheck = "";
                    j = 0;
                    continue;
                }

                if (numberToCheck[j] == ',') 
                {
                    coma = true;
                }
                
                if (numberToCheck.Length > 1)
                {
                    if (numberToCheck[0] == '0' && numberToCheck[1] == '0')
                    {
                        Console.WriteLine("Number cannot start with muliplied 0, try again");
                        numberToCheck = "";
                        j = 0;
                        continue;
                    }
                }
                j += 1;
                
            }

            Console.WriteLine($"You created number " + numberToCheck);

        }
    }
}
