using System;
using System.Collections;


namespace FirstStack
{
    // All stack methods here https://docs.microsoft.com/pl-pl/dotnet/api/system.collections.stack?view=net-5.0
    class Program
    {
        static void Main(string[] args)
        {

        Stack firstStack = new Stack();
            firstStack.Push("string");
            firstStack.Push(78);
            firstStack.Push(78.32);
            firstStack.Push('C');
            firstStack.Push(null);

            foreach (var item in firstStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Coount of elements before pop method {firstStack.Count}");

            firstStack.Pop();

            Console.WriteLine($"Coount of elements after pop method {firstStack.Count}");
        }
    }
}
