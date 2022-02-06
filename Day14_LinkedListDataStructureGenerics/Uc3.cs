using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class UC3_LinkedList
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
                    temp = GetNext(temp);
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", "Node.data");
        }

        private static Node GetNext(Node temp)
        {
            return (Node)temp.next;
        }

        public void AddFirst(int data)
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
                node.next = temp;
                head = temp;
            }
            Console.WriteLine("{0} inserted into linked list", "Node.data");
        }

        public void AddLast(int data)
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
            Console.WriteLine("{0} inserted into linked list", arg0:" Node.data");
        }
    }
}