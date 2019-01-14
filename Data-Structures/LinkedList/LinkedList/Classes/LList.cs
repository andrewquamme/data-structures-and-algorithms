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

        /// <summary>
        /// Insert Node at Head
        /// </summary>
        /// <param name="value">value of new Node</param>
        public void Insert(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = Head;
            Head = newNode;
        }

        public void Append(int value)
        {

        }

        /// <summary>
        /// Insert Node Before a Value
        /// </summary>
        /// <param name="value">value of new Node</param>
        /// <param name="insertionPoint">Value to insert before</param>
        public void InsertBefore(int value, int insertionPoint)
        {
            Current = Head;

            if(Current.Value == insertionPoint)
            {
                Insert(value);
                return;
            }

            while (Current.Next != null)
            {
                if(Current.Next.Value == insertionPoint)
                {
                    Node node = new Node(value);
                    node.Next = Current.Next;
                    Current.Next = node;
                    return;
                }
                Current = Current.Next;
            }
        }

        /// <summary>
        /// Checks if linked list includes a value
        /// </summary>
        /// <param name="value">value to find</param>
        /// <returns>boolean</returns>
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

        /// <summary>
        /// Displays the values of the linked list
        /// </summary>
        public void Print()
        {
            if(Head != null)
            {
                Current = Head;
                while (Current.Next != null)
                {
                    Console.Write($"{Current.Value} => ");
                    Current = Current.Next;
                }
                Console.Write($"{Current.Value} => Null");
            }
            else
            {
                Console.Write("The linked list is empty");
            }
            
        }

        
    }
}
