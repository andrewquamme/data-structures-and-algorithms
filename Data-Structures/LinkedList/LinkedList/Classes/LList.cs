using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LList
    {

        public Node Head { get; set; }
        public Node Current { get; set; }

        public LList()
        {
            Head = null;
        }

        //public LList(int value)
        //{
        //    Node newNode = new Node(value);
        //    Head = newNode;
        //}

        public void Insert(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = Head;
            Head = newNode;
        }

        public bool Includes(int value)
        {
            if (Head != null)
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
            }
            return false;
        }

        public void Print()
        {
            if(Head != null)
            {
                Current = Head;
                while (Current.Next != null)
                {
                    Console.WriteLine(Current.Value);
                    Current = Current.Next;
                }
                Console.WriteLine(Current.Value);
            }
            else
            {
                Console.WriteLine("The linked list is empty");
            }
            
        }
    }
}
