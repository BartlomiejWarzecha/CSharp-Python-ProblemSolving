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

        public void insertAtFront(int data)
        {
            Node newHead = new Node(data);
            Node tmp = head;
            head = newHead;
            head.next = tmp;
        }

       public void insertAtEnd(int data)
        {
            Node newTail = new Node(data);
            Node tmp;
            tmp = head;

            while (tmp.next != null)
            {
                tmp = tmp.next;
            }

            tmp.next = newTail;
            newTail.next = null;
        }

        public void insertAfter(int position, int data) {

            Node After = new Node(data);
            Node tmp;
            Node previous;
            previous = head;

            previous = head;
            
            for(int i = 0; i < position-1; i++) {
                previous = previous.next;
            }

            tmp = previous;
            After.next = tmp.next;
            previous.next = After;
             
        }
          public  static void Main(string[] args)
        {
            LinkedList firstLinkedList = new LinkedList();

            firstLinkedList.head = new LinkedList.Node(1);
            Node second = new Node(2);
            Node third = new Node(3);

            int insertAtBeggining = 10;
            int insertAtEnd = 20;
            int insertAfterValue = 15;
            int insertAfterNodeNumber = 2;

            firstLinkedList.head.next = second;
            second.next = third;

            firstLinkedList.insertAtFront(insertAtBeggining);
            firstLinkedList.insertAtEnd(insertAtEnd);
            firstLinkedList.insertAfter(insertAfterNodeNumber, insertAfterValue);
            firstLinkedList.printList();
        }
    }
}
