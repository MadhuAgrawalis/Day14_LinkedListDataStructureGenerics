using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class UC1_LinkedList
    {
        public Node head;

        public void Add(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = (Node)temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine(value: NewMethod(node));
        }

        private static string NewMethod(Node Node)
        {
            return $"{"Node.data"} inserted into linked list";
        }
    }
}