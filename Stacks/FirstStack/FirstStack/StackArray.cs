using System;

namespace FirstStack
{
    class StackArray
    {

        protected static int n { get; set; }
        private int?[] array { get; set; }
        private int top1 { get; set; }
        private int top2 { get; set; } = 0;
        public StackArray(int nn)
        {
            n = nn;

            if (isEven(nn))
            {
                top1 = nn / 2;
            }
            else
            {
                top1 = nn / 2 + 1;
            }

            array = new int?[n];
        }


        public void push1(int x)
        {
            if (top1 < n)
            {
                array[top1] = x;
                top1++;
            }
            else
            {
                Console.WriteLine("Array is full");
                return;
            }
        }
        public void push2(int x)
        {
            if (top2 < n / 2 + 1 && !isEven(n))
            {
                array[top2++] = x;
            }
            if (top2 < n / 2 && isEven(n))
            {
                array[top2++] = x;
            }
            else
            {
                Console.WriteLine("Array is full");
                return;
            }
        }
        public int? pop1()
        {

            if (top1 == n / 2 + 1 && !isEven(n))
            {
                return -1;
            }
            if (top1 == n / 2 && isEven(n))
            {
                return -1;
            }
            else
            {
                return (array[--top1]);
            }

        }
        public int? pop2()
        {
            if (top2 == 0)
            {
                return -1;
            }
            else
            {
                return (array[--top2]);
            }
        }

        public bool isEven(int x)
        {
            if (x % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void printStackArray()
        {

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
    }
}
