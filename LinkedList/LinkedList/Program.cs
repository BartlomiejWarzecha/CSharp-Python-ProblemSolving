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
        public int lengthOfLLIterative()
        {
            Node tmp = head;
            int length = 0;
            while(tmp != null)
            {
                length += 1;
                tmp = tmp.next;
            }
            return length;
        }
        public int lengthOfLLRecursive(Node tmp, int length = 0)
        {
            if (tmp == null)
            {
                return length;
            }
            else
            {
                return lengthOfLLRecursive(tmp.next, length += 1);
            }
        }
        public void swapValuesInLinkedList(int x, int y)
        { 
            Node tmp = head;
            int firstSwapNumber;
            int secondSwapNumber;

            firstSwapNumber = positionOfValueInLinkedList(x);
            secondSwapNumber = positionOfValueInLinkedList(y);

            Console.WriteLine("first swap position = {0}, second swap position = {1}", firstSwapNumber, secondSwapNumber);

            if (firstSwapNumber == -1 || secondSwapNumber == -1)
            {
                if (firstSwapNumber == -1 & secondSwapNumber == -1)
                {
                    Console.WriteLine("Both values {0} and {1} are not in Linked List", x, y);
                    return;
                }

                if (firstSwapNumber == -1) 
                { 
                    Console.WriteLine("One value {0} is not in Linked List", x);
                    return;
                }
                else
                { 
                    Console.WriteLine("One value {0} is not in Linked List", y);
                    return;
                }
            }
           
            swapValues(x, y, firstSwapNumber);
            swapValues(x, y, secondSwapNumber);
        }
        public int positionOfValueInLinkedList(int value)
        {
            Node tmp = head;
            int position = 0;
            while (tmp.next != null)
            {
                if (value == tmp.data)
                {
                    return position;
                }
                tmp = tmp.next;
                position++;
            }
            return -1;
        }
        public void swapValues(int x, int y, int position) {
            Node tmp = head;

            while (position != 0 & tmp.next != null) 
            {
                tmp = tmp.next;
                position--;
            }

            if (tmp.data == x) 
            {
                tmp.data = y;
                return;
            }

            if (tmp.data == y) 
            {
                tmp.data = x;
                return;
            }
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

            iterateToNodePosition(position - 1, previous);

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
            iterateToNodePosition(position, tmp);

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
        public void iterateToNodePosition(int? position, Node tmp)
        {
            while (position != 0 & tmp != null) 
            {
                tmp = tmp.next;
                position--;
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

        private void middleOfLinkedList(Node tmp) 
        {
            int length = lengthOfLLRecursive(tmp);
            int middle;

            if (length % 2 == 0)
            {
                middle = length / 2;
            }else
            {
                middle = length / 2 + 1;
            }

            for(int i = 0; i < middle; i++)
            {
                tmp = tmp.next;
            }
            Console.WriteLine("Middle of this linked list is {0} on position {1}", tmp.data, middle);
        }
        public void howManyTimesInLinkedList(int value)
        {
            Node tmp = head;
            int count = 0;
            while (tmp != null) 
            {
                if (tmp.data == value)
                {
                    count++;
                }
                tmp = tmp.next;
            }
            Console.WriteLine("Value {0} is in Linked list {1} times", value, count);
        }

        public void reverseLinkedList(Node current)
        {
            current = head;
            Node prev = null;
            Node after = null;

            while (current != null) 
            {
                after = current.next;
                current.next = prev;
                prev = current;
                current = after;
            }
            head = prev;
        }

        public void mergeSortedLinkedList(
        { 
        
        
        }


        public static void Main(string[] args)
        {
            LinkedList firstLinkedList = new LinkedList();

            firstLinkedList.head = new LinkedList.Node(1);
            Node second = new Node(2);
            Node third = new Node(3);


            int insertAtBeggining = 10;
            int insertAtEnd = 18;
            int valueForInsertAfter = 18;
            int nodePositionForInsertAfter = 1;
            int? deleteNode = null;
            int? deleteNodeValue = null;
            int LLlengthIterative;
            int LLlengthRecursive;
            
            firstLinkedList.head.next = second;
            second.next = third;

            firstLinkedList.insertAtFront(insertAtBeggining);
            firstLinkedList.insertAtEnd(insertAtEnd);
            firstLinkedList.insertAfter(nodePositionForInsertAfter, valueForInsertAfter);
            firstLinkedList.deleteNodeByPosition(deleteNode);
            firstLinkedList.deleteNodeByValue(deleteNodeValue);

            firstLinkedList.printCurrentList();
            firstLinkedList.swapValuesInLinkedList(41, 30);

            LLlengthIterative = firstLinkedList.lengthOfLLIterative();
            Console.WriteLine("This Linked List have " + LLlengthIterative + ((LLlengthIterative > 1) ? " Nodes" : (LLlengthIterative == 0) ? " Nodes so it's empty" : " Node"));

            firstLinkedList.reverseLinkedList(firstLinkedList.head);

            firstLinkedList.printCurrentList(); 

            LLlengthRecursive = firstLinkedList.lengthOfLLRecursive(firstLinkedList.head);
            Console.WriteLine("This Linked List have " + LLlengthRecursive + ((LLlengthRecursive > 1) ? " Nodes" : (LLlengthRecursive == 0) ? " Nodes so it's empty" : " Node"));

            firstLinkedList.howManyTimesInLinkedList(22);
            
            
        }

    }
}
 
