using System;
using System.Collections;


namespace FirstStack
{
    // All stack methods here https://docs.microsoft.com/pl-pl/dotnet/api/system.collections.stack?view=net-5.0
    class Program
    {
        static void Main(string[] args)
        {
            string testInfixString = "a+b*(c^d-e)^(f+g*h)-i";
            Console.WriteLine(testInfixString);
            infixToPostfix(testInfixString);
        }

        public static void infixToPostfix(string infixText)
        {

            Stack stack = new Stack();
            string postFix = "";
            char temp;
            bool parenthesis = false;

            for (int i = 0; i < infixText.Length; i++)
            {

                if (infixText[i] == '+' || infixText[i] == '-')
                {
                    stack.Push(infixText[i]);
                    continue;
                }
                if (infixText[i] == '(')
                {
                    while (stack.Count != 0)
                    {
                        postFix += stack.Pop();
                    }
                    postFix += '(';

                    parenthesis = true;
                    continue;
                }
                if (infixText[i] == ')' && parenthesis == true)
                {
                                       
                    while (stack.Count != 0)
                    {
                        postFix += stack.Pop();
                    }

                    postFix += ')';

                    parenthesis = false;
                    continue;
                }
                if (stack.Count > 0 )
                {
                    if (infixText[i] == '^' )
                    {
                        while (stack.Count != 0)
                        {
                            postFix += stack.Pop();
                        }
                        continue;
                    }
                    if (infixText[i] == '*' || infixText[i] == '/')
                    {
                        temp = (char)stack.Peek();
                        stack.Push(infixText[i]);

                        if (temp != '^')
                        {
                            while (stack.Count != 0)
                            {
                                postFix += stack.Pop();
                            }
                            continue;
                        }
                    }

                }
                if (((int)infixText[i] >= 65 && (int)infixText[i] <= 90)
                || ((int)infixText[i] >= 97 && (int)infixText[i] <= 122))
                {
                    postFix += infixText[i];
                    continue;
                }
            }
            while (stack.Count > 0)
            {
                postFix += stack.Pop();
            }

            Console.WriteLine(postFix);


        }
    }
}
