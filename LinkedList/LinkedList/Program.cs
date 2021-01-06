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

            previous = head;
            
            for(int i = 0; i < position-1; i++) {
                previous = previous.next;
            }

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
                head.next = head.next.next;
                return;
            }

            Node tmp;
            tmp = head;
            
            for (int i = 0; i < position - 1; i++)
            {
                tmp = tmp.next;
            }

            tmp.next = tmp.next.next;
        }

        public void deleteNodeValue(Nullable<int> value) {

            if (value == null)
            {
                return;
            }

            Node DealitingValue = new Node(value);
            Node current;
            Node tmp;
            tmp = head;
            current = head;

            while (tmp.next != null)
            {
                while (current != DealitingValue ^ current.next != null)
                {

                    current = current.next;

                }
                current.next = current.next.next;
                tmp = current.next;

            }

        }

        public void deleteLinkedList() {
            head = null;
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
            Nullable<int> deleteNode = 1;
            Nullable<int> deleteNodeValue = 5;

            firstLinkedList.head.next = second;
            second.next = third;

            firstLinkedList.insertAtFront(insertAtBeggining);
            firstLinkedList.insertAtEnd(insertAtEnd);
            firstLinkedList.insertAfter(insertAfterNodeNumber, insertAfterValue);
            firstLinkedList.deleteNodePosition(deleteNode);
            firstLinkedList.deleteNodeValue(deleteNodeValue);
            //firstLinkedList.deleteLinkedList();
            firstLinkedList.printList();
            // firstLinkedList.display(firstLinkedList.head);
        }
    }
}
