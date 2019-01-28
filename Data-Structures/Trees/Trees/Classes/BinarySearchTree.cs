using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinarySearchTree : BinaryTree
    {

        public void Add(int value)
        {
            Node newNode = new Node(value);
            Node current = Root;
            Node parent = null;
            while (current != null)
            {
                if (value == current.Value)
                {

                    return;
                }
                else if (value < current.Value)
                {
                    parent = current;
                    current = current.Left;
                }
                else
                {
                    parent = current;
                    current = current.Right;
                }
            }

            if (value < parent.Value)
            {
                parent.Left = newNode;
            }
            else
            {
                parent.Right = newNode;
            }
        }

        /// <summary>
        /// Determines if a Binary Tree contains a value
        /// </summary>
        /// <param name="value">Value to find</param>
        /// <returns>True/False if found</returns>
        public bool Contains(int value)
         {
            Node current = Root;
            while (current != null)
            {
                if (current.Value == value)
                {
                    return true;
                }
                else if (value < current.Value)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }
            return false;
         }
        
    }
}
