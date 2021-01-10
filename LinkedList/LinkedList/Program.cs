using System;

namespace LinkedList
{
    public class LinkedList
    {

        Node head;
        public class Node
        {
            public Nullable<int> data;
            public Node next;

            public Node(Nullable<int> d)
            {
                data = d;
                next = null;
            }
        }
        public void printList()
        {

            Node printedNode = head;
            while (printedNode != null)
            {
                Console.WriteLine(printedNode.data + " ");
                printedNode = printedNode.next;

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
            if (head == null) {
                head = new Node(data);
            }

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
            
            itareteToNodePosition(position -1, previous);

            tmp = previous;
            After.next = tmp.next;
            previous.next = After;
             
        }

        public void deleteNodePosition(Nullable<int> position) {

            if (position == null) {
                return;
            }

            if (position == 0) {
                head = head.next;
                return;
            }

            Node tmp;
            tmp = head;

            itareteToNodePosition(position, tmp);

            tmp.next = tmp.next.next;
        }

        public void deleteNodeValue(Nullable<int> value) {

            Node dealitingNode = new Node(value);
            Node tmp = head;
            Node prev = null;

            if (tmp == dealitingNode ^ tmp != null ) {
                head = tmp.next;
            }

            while (tmp.next != null) {
                tmp = tmp.next;
                prev = tmp;
                if (tmp == dealitingNode)
                {
                    prev = tmp.next;
                }
            }
        }

        public void deleteLinkedList() {
            head = null;
        }

        public void itareteToNodePosition(Nullable<int> position, Node tmp) {

            for (int i = 0; i < position - 1; i++)
            {
                tmp = tmp.next;
            }
        }

        public  static void Main(string[] args)
        {
            LinkedList firstLinkedList = new LinkedList();
            
            firstLinkedList.head = new LinkedList.Node(1);
            Node second = new Node(2);
            Node third = new Node(3);
 

            int insertAtBeggining = 10;
            int insertAtEnd = 20;
            int insertAfterValue = 5;
            int insertAfterNodeNumber = 4;
            Nullable<int> deleteNode = null;
            Nullable<int> deleteNodeValue = 5;

            firstLinkedList.head.next = second;
            second.next = third;

            firstLinkedList.insertAtFront(insertAtBeggining);
            firstLinkedList.insertAtEnd(insertAtEnd);
            firstLinkedList.insertAfter(insertAfterNodeNumber, insertAfterValue);
            firstLinkedList.deleteNodePosition(deleteNode);
            // firstLinkedList.deleteNodeValue(deleteNodeValue);
            firstLinkedList.printList();
            // firstLinkedList.display(firstLinkedList.head);
        }
    }
}
