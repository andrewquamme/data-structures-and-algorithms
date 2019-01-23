using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        /// <summary>
        /// Set top to null if no value is passed
        /// upon instantiation
        /// </summary>
        public Stack()
        {
            Top = null;
        }

        /// <summary>
        /// Create a new Node and push to 
        /// top of the stack
        /// </summary>
        /// <param name="value">value of new Node</param>
        public void Push(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// Pop top node from the stack and 
        /// return value to the user
        /// </summary>
        /// <returns>Top Node Value</returns>
        public Node Pop()
        {
            // create a temp
            Node temp = Top;
            //set top to the next node in the stack
            Top = Top.Next;
            // clear the reference of next on the temp
            temp.Next = null;
            // return the node
            return temp;
        }

        /// <summary>
        /// Peek at the top Node on
        /// the stack
        /// </summary>
        /// <returns>Top Node Value</returns>
        public int? Peek()
        {
            return Top.Value;
        }
    }
}