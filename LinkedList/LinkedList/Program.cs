using System;

namespace LinkedList
{
    public class LinkedLis
    {

        Node head;

        public static class Node
        {
            int data;
            Node next;


            Node(int d)
            {
                data = d;
                next = null;
            }
        }
        public static void printList()
        {

            Node n = head;
            while (n != null)
            {
                Console.WriteLine(n.data + " ");
                n = n.next;

            }

        }
        public 
            static void Main(string[] args)
        {
            LinkedLis firsLinkedList = new LinkedList();

            firsLinkedList.head = new LinkedList.Node(1);
            Node second = new Node(2);
            Node third = new Node(3);

            // Linking nodes 
            firsLinkedList.head.next = second;
            second.next = third;

            firsLinkedList.printList();

        }
    }
}
