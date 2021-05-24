using System;

namespace LinkedList
{
    public class LinkedList : DoubleLinkedList
    {
        protected Node head;

        public class Node
        {
            public int? data;
            public Node next;
            public Node prev;

            public Node(int? d)
            {
                data = d;
                next = null;
                prev = null;
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

        private void printList(Node CurrentNode)
        {
            while (CurrentNode != null)
            {
                Console.WriteLine(CurrentNode.data + " ");
                CurrentNode = CurrentNode.next;
            }
        }

        public int lengthOfLLIterative()
        {
            Node tmp = head;
            int length = 0;
            while (tmp != null)
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

        public void swapValues(int x, int y, int position)
        {
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
        public void insertNodeAtFront(Node after)
        {
            Node tmp = head;
            while (tmp.next != null) {
                tmp = tmp.next;
            }
            tmp.next = after;
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

            iterateToNodePosition(position - 1, ref previous);

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
            iterateToNodePosition(position, ref tmp);

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

        public static void iterateToNodePosition(int? position, ref Node tmp)
        {
            while (position != 0 & tmp != null)
            {
                tmp = tmp.next;
                position--;
            }
        }

        private void middleOfLinkedList(Node tmp)
        {
            int length = lengthOfLLRecursive(tmp);
            int middle;

            if (length % 2 == 0)
            {
                middle = length / 2;
            }
            else
            {
                middle = length / 2 + 1;
            }

            for (int i = 0; i < middle; i++)
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

        public Node mergeTwoSortedLinkedLists(Node first, Node second)
        {

            Node mergedList = first;

            if (first.data > second.data)
            {
                var temp = first;
                first = second;
                second = temp;
            }

            while (first.next != null && second != null)
            {

                if (first.next.data <= second.data)
                {
                    first = first.next;
                }
                else
                {
                    var temp = first.next;
                    var n = second.next;
                    first.next = second;
                    second = temp;
                    first.next = n;
                }
            }

            while (second != null)
            {
                first.next = second;
                second = second.next;
            }

            return first;
        }
        // Not working good 
        // 4 6 instead of First Linked List 1 2 3 4   Second Linked List 3 4 5 6
        public static Node mergeSortedLinkedList(Node firstLL, Node secoundLL)
        {
            Node tmp = firstLL;
            Node first = firstLL;
            Node secound = secoundLL;

            if (first.data > secound.data)
            {
                tmp = secound;
                secound = secound.next;
            }
            else
            {
                tmp = first;
                first = first.next;
            }


            while (first.data != null & secound.data != null)
            {
                if (first.data <= secound.data)
                {
                    tmp.next = first;
                    first = first.next;
                    tmp = tmp.next;

                }

                if (secound.data < first.data)
                {
                    tmp.next = secound;
                    secound = secound.next;
                    tmp = tmp.next;
                }


                if (first.data == null)
                {
                    while (secound.data != null)
                    {
                        tmp.next = secound;
                        secound = secound.next;
                        tmp = tmp.next;
                    }
                }

                if (secound.data == null)
                {
                    while (first.data != null)
                    {
                        tmp.next = first;
                        first = first.next;
                        tmp = tmp.next;
                    }
                }
            }
            return tmp;
        }

        public static void splitCircularLinkedList(Node head)
        {
            LinkedList firstCircularLinkedList = new LinkedList();
            LinkedList secondCircularLinekedlList = new LinkedList();

            Node tmp = head;
            int length = 0;
            while (tmp != null)
            {
                length += 1;
                tmp = tmp.next;
            }
            tmp = head;

            if (length % 2 == 0)
            {

                firstCircularLinkedList.head = tmp;

                for (int i = 1; i < length / 2; i++)
                {
                    firstCircularLinkedList.insertNodeAtFront(tmp.next);
                    tmp = tmp.next;
                }
                firstCircularLinkedList.insertNodeAtFront(firstCircularLinkedList.head);

                secondCircularLinekedlList.head = tmp;
                for (int i = 1; i < length / 2; i++)
                {
                    secondCircularLinekedlList.insertNodeAtFront(tmp.next);
                    tmp = tmp.next;
                }
                secondCircularLinekedlList.insertNodeAtFront(secondCircularLinekedlList.head);

                firstCircularLinkedList.printCurrentList();
                secondCircularLinekedlList.printCurrentList();
            }

        }
        public void addValueAfterNodePositionInDoubleLinkedList(int position, int data)
        {
            Node tmp = head;
            Node newNode = new Node(data);

            iterateToNodePosition(position - 1, ref tmp);

            Node next = tmp.next;
            Node prev = tmp;
            prev.next = newNode;
            newNode.next = next;
            newNode.prev = prev;
        }

        public void reverseDoubleLinkedList()
        {
            Node prev = null;
            Node after = null;
            Node current = head;

            while (current != null)
            {
                after = current.next;
                current.next = current.prev;
                prev = current;
                current.prev = after;
                current = after;
            }
            head = prev;
        }

        public void deleteNodeFromDoubleLinkedList(int position)
        {
            Node current = head;
            Node next;
            Node prev;

            iterateToNodePosition(position - 1, ref current);

            
            prev = current.prev;
            next = current.next;
            if (prev != null)
            {
                prev.next = next;
            }
            if (next != null)
            {
                next.prev = prev;
            }
        
        }



        public static void Main(string[] args)
        {
            LinkedList doubleLinkedList = new LinkedList();
            LinkedList secondLinkedList = new LinkedList();

            doubleLinkedList.head = new LinkedList.Node(1);
            Node second = new Node(2);
            Node third = new Node(3);
            Node fourth = new Node(4);

            doubleLinkedList.head.next = second;
            second.next = third;
            third.next = fourth;

            second.prev = doubleLinkedList.head;
            third.prev = second;
            fourth.prev = third;

            doubleLinkedList.addValueAfterNodePositionInDoubleLinkedList(4, 10);
            doubleLinkedList.printCurrentList();
            doubleLinkedList.deleteNodeFromDoubleLinkedList(5);
            doubleLinkedList.printCurrentList();
            doubleLinkedList.reverseDoubleLinkedList();
            doubleLinkedList.printCurrentList();
           

            secondLinkedList.head = new LinkedList.Node(3);
            Node secondSecondLL = new Node(4);
            Node thirdSecondLL = new Node(5);
            Node fourthSecondLL = new Node(6);

            secondLinkedList.head.next = secondSecondLL;
            secondSecondLL.next = thirdSecondLL;
            thirdSecondLL.next = fourthSecondLL;



            

        }
    }
}