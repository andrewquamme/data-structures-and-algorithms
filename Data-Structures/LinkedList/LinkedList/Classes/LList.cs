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

        /// <summary>
        /// Append Node at end of linked list
        /// </summary>
        /// <param name="value">value of new Node</param>
        public void Append(int value)
        {
            Current = Head;
            
            if (Current != null)
            {
                while (Current.Next != null)
                {
                    Current = Current.Next;
                }
                Node node = new Node(value);
                Current.Next = node;
            }
            else
            {
                Insert(value);
            }
            
        }

        /// <summary>
        /// Insert new Node before value
        /// </summary>
        /// <param name="value">value to insert before</param>
        /// <param name="newValue">new Node value</param>
        public void InsertBefore(int value, int newValue)
        {
            Current = Head;

            //If value is head, insert new value
            if(Current.Value == value)
            {
                Insert(newValue);
                return;
            }

            while (Current.Next != null)
            {
                if(Current.Next.Value == value)
                {
                    Node node = new Node(newValue);
                    node.Next = Current.Next;
                    Current.Next = node;
                    return;
                }
                Current = Current.Next;
            }
            Console.WriteLine($"Node {value} not in list");
        }

        public void InsertAfter(int value, int newValue)
        {

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
                Console.Write("Head => ");
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
