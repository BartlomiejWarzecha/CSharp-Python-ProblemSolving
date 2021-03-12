using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class DoubleLinkedList
    {
        public DoubleNode head;

        public class DoubleNode
        {
            public int? data;
            public DoubleNode next;
            public DoubleNode prev;

            public DoubleNode(int? d)
            {
                data = d;
                next = null;
                prev = null;
            }
        }
    }
}
