using System;

namespace LinkedList
{
    public class LinkedList
    {

        Node head;
        public class Node
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
                currentNode = currentNode.next;
            }

        }

        public void insertAtFront(Node newHead)
        {
            Node tmp = head;
            head = newHead;
            head.next = tmp;
        }

       public void insertAtEnd(Node newTail)
        {
            Node tmp;
            tmp = head;

            while (tmp != null)
            {
                tmp = tmp.next;
            }

            tmp.next = newTail;
        } 
        
    

          public  static void Main(string[] args)
        {
            LinkedList firstLinkedList = new LinkedList();

            firstLinkedList.head = new LinkedList.Node(1);
            Node second = new Node(2);
            Node third = new Node(3);
            Node insertAtBeggining = new Node(10);
            Node insertAtEnd = new Node(20);

            firstLinkedList.head.next = second;
            second.next = third;

            firstLinkedList.insertAtFront(insertAtBeggining);
            firstLinkedList.insertAtEnd(insertAtEnd);
            firstLinkedList.printList();
        }
    }
}
