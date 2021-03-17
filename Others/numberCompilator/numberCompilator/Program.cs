using System;

namespace numberCompilator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string numberToCheck = "10,,1018120";
            bool coma = false;


            for (int i = 0; i < numberToCheck.Length; i++)
            {
                if (numberToCheck[0] == '0' && numberToCheck[1] == '0') 
                {
                    Console.WriteLine("Number cannot start with muliplied 0");
                    break;
                }

                if (numberToCheck[i] == ',' && coma == true) 
                {
                    Console.WriteLine("Number cannot have muliplied ,");
                    break;
                }

                if (numberToCheck[i] == ',') 
                {
                    coma = true;
                    continue;
                }
            }

        }
    }
}
