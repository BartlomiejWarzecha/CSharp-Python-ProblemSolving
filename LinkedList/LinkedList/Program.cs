using System;

namespace LinkedList
{
    public class LinkedList
    {

        Node head;
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
        public void printCurrentList()
        {
            Node printedNode = head;
            printList(printedNode);
        }
        public void printListBasedOnHead(Node head)
        {
            Node currentNode = head;
            printList(currentNode);
        }
        public void insertAtFront(int data)
        {
            if (head == null)
            {
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
        public void insertAfter(int position, int data)
        {
            Node After = new Node(data);
            Node tmp;
            Node previous;

            previous = head;

            itareteToNodePosition(position - 1, previous);

            tmp = previous;
            After.next = tmp.next;
            previous.next = After;
        }

        public void deleteLinkedList()
        {
            head = null;
        }

        public void deleteNodeByPosition(int? position)
        {
            if (position == null)
            {
                return;
            }

            if (position == 0)
            {
                head = head.next;
                return;
            }

            Node tmp;
            tmp = head;
            itareteToNodePosition(position, tmp);

            tmp.next = tmp.next.next;
        }

        public void deleteNodeByValue(int? value)
        {
            Node tmp = head;
            Node prev = null;

            if (head.data == value && head != null)
            {
                head = tmp.next;
            }

            while (tmp.next != null)
            {
                prev = tmp;
                tmp = tmp.next;
                if (tmp.data == value)
                {
                    prev.next = tmp.next;
                }
            }
        }
        public void itareteToNodePosition(int? position, Node tmp)
        {
            for (int i = 0; i < position - 1; i++)
            {
                tmp = tmp.next;
            }
        }
        private void printList(Node CurrentNode)
        {
            while (CurrentNode != null)
            {
                Console.WriteLine(CurrentNode.data + " ");
                CurrentNode = CurrentNode.next;
            }
        }

        public static void Main(string[] args)
        {
            LinkedList firstLinkedList = new LinkedList();

            firstLinkedList.head = new LinkedList.Node(1);
            Node second = new Node(2);
            Node third = new Node(3);


            int insertAtBeggining = 10;
            int insertAtEnd = 20;
            int insertAfterValue = 5;
            int insertAfterNodeNumber = 4;
            int? deleteNode = null;
            int? deleteNodeValue = null;

            firstLinkedList.head.next = second;
            second.next = third;

            firstLinkedList.insertAtFront(insertAtBeggining);
            firstLinkedList.insertAtEnd(insertAtEnd);
            firstLinkedList.insertAfter(insertAfterNodeNumber, insertAfterValue);
            firstLinkedList.deleteNodeByPosition(deleteNode);
            firstLinkedList.deleteNodeByValue(deleteNodeValue);
            firstLinkedList.printCurrentList();
            // firstLinkedList.printListBasedOnHead(firstLinkedList.head);
        }
    }
}
 
