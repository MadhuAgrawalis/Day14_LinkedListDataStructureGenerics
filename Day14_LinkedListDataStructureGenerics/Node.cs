using System;

namespace LinkedList
{
    internal class Node
    {
        internal object next;
        internal bool data;
        private readonly int next;

        public Node(int data)
        {
            (Node)            this.next = data;
        }

        public static explicit operator Node(bool v)
        {
            throw new NotImplementedException();
        }
    }
}