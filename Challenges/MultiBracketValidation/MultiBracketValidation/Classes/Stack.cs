using System;
using System.Collections.Generic;
using System.Text;

namespace MultiBracketValidation.Classes
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
        public void Push(char value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// Pop top node from the stack and 
        /// return value to the user
        /// </summary>
        /// <returns>Top Node</returns>
        public Node Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }

        /// <summary>
        /// Peek at the top Node on
        /// the stack
        /// </summary>
        /// <returns>Top Node</returns>
        public Node Peek()
        {
            return Top;
        }
    }
}
