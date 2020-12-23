using System;

namespace LinkedList
{
    public class LinkedList
    {

        Node head;
        public  class Node
        {
             public int data;
             public Node next;


            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
        public void printList()
        {

            Node n = head;
            while (n != null)
            {
                Console.WriteLine(n.data + " ");
                n = n.next;

            }

        }

        public void display(Node head) {

            Node currentNode = head;

            while (currentNode != null) 
            {
                Console.WriteLine(currentNode.data + " ");
            }
        
        
        
        }
        public 
            static void Main(string[] args)
        {
            LinkedList firsLinkedList = new LinkedList();

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
