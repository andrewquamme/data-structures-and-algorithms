using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    class LList
    {

        public Node Head { get; set; }
        public Node Current { get; set; }

        public LList()
        {
            Node newNode = new Node(0);
            Head = newNode;
        }

        public LList(int value)
        {
            Node newNode = new Node(value);
            Head = newNode;
        }

        public void Insert(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = Head;
            Head = newNode;
        }

        public bool Includes(int value)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    return true;
                }
                Current = Current.Next;
            }
            if (Current.Value == value)
            {
                return true;
            }
            return false;
        }

        public void Print()
        {
            Current = Head;
            while (Current.Next != null)
            {
                Console.WriteLine(Current.Value);
                Current = Current.Next;
            }
            Console.WriteLine(Current.Value);
        }
    }
}
