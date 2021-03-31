using System;
using System.Collections;


namespace FirstStack
{
    // All stack methods here https://docs.microsoft.com/pl-pl/dotnet/api/system.collections.stack?view=net-5.0
    class Program
    {
        static void Main(string[] args)
        {
            string testInfixString = "a-b--+++c*d+g/";
            infixToPostfix(testInfixString);
        }

        public static void infixToPostfix(string infixText)
        {

            Stack stack = new Stack();
            string postFix;
            string temp;

            for (int i = 0; i < infixText.Length; i++)
            {
                if (infixText[i] == '+' || infixText[i] == '-')
                {
                    stack.Push(infixText[i]);
                    continue;
                }
                if (infixText[i] == '*' || infixText[i] == '/') 
                {
                    temp = (string)stack.Peek();
                    stack.Push(infixText[i]);

                    if (temp == "+"
                        || temp == "-")
                    {
                        while (stack.Count > 0) 
                        {
                            postFix += stack.Pop(); 
                        }
                    
                    }
                }
                postFix += infixText[i];
            }

            Console.WriteLine(postFix);


        }
    }
}
