using System;

namespace Array
{
    class Array
    {
        
        public static void printArray(int[] array) {

            for (int i = 0; i < array.Length; ++i)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static void mergeSort(int[] array) { 
             
        
        
        }

        static void Main(string[] args)
        {
            int[] array =
            { 1,2,3,4,5,6 };

            printArray(array);
        }
    }
}
