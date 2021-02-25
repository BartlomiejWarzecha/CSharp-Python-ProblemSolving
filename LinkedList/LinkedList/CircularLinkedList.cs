using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class CircularLinkedList : LinkedList
    {
        public void printCircularList()
        {
            Node currentNode = head;
            do
            {
                Console.WriteLine(currentNode.data + " ");
                currentNode = currentNode.next;
            }
            while (currentNode != head);
        }

        

    }
}
