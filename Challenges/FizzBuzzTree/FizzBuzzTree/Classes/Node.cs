using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree.Classes
{
    public class Node
    {
        public Object Value { get; set; }
        public Node Right { get; set; }
        public Node Left { get; set; }

        /// <summary>
        /// Set value of Node and Left/Right to null
        /// </summary>
        /// <param name="value">Value of Node</param>
        public Node(Object value)
        {
            Value = value;
            Left = Right = null;
        }
    }
}
