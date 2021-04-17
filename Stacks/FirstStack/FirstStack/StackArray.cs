using System;
using System.Collections.Generic;
using System.Text;

namespace FirstStack
{
    class StackArray
    {
        protected int[] array1 { get; set; }
        protected int[] array2 { get; set; }

        private int count1 = 0;
        private int count2 = 0;
        public StackArray(int[] array, int[] array2) {
            this.array1 = array;
            this.array2 = array2;
        }
        public void push1(int x)
        {
            array1[count1] = x;
            count1 += 1;
        }
        public void push2(int x)
        {
            array2[count2] = x;
            count2 += 1;
        }
        public int pop1(int x)
        {


        }
        public int pop2(int x)
        {

        }
    }
}
