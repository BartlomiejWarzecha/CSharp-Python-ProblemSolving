using System;

namespace CircularLinkedList
{
    class Program
    {

        public class CircularLinkedList 
        {

            private Node head;
            public class Node
            {
                public int? data;
                public Node next;

                public Node(int? d)
                {
                    data = d;
                    next = null;
                }
            }
        }
        static void Main(string[] args)
        {

            CircularLinkedList firstCircularLinkedList = new CircularLinkedList();
            firstCircularLinkedList.head = new CircularLinkedList.Node(1);

            firstNode = firstCircularLinkedList.head;

        }
    }
}
