using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinaryTree : Tree
    {
        /// <summary>
        /// Perform PreOrder Binary Tree traversal from Root Node
        /// </summary>
        /// <param name="root">Root Node of Binary Tree</param>
        /// <returns>IList of tree values</returns>
        public IList<int> PreOrder(Node root)
        {
            List<int> results = new List<int>();
            if (root == null) return results;

            results.Add(root.Value);

            if (root.Left != null)
            {
                results.AddRange(PreOrder(root.Left));
            }

            if (root.Right != null)
            {
                results.AddRange(PreOrder(root.Right));
            }

            return results;
        }

        /// <summary>
        /// Perform InOrder Binary Tree traversal from Root Node
        /// </summary>
        /// <param name="root">Root Node of Binary Tree</param>
        /// <returns>IList of tree values</returns>
        public IList<int> InOrder(Node root)
        {
            List<int> results = new List<int>();
            if (root == null) return results;

            if (root.Left != null)
            {
                results.AddRange(InOrder(root.Left));
            }

            results.Add(root.Value);

            if (root.Right != null)
            {
                results.AddRange(InOrder(root.Right));
            }

            return results;
        }

        /// <summary>
        /// Perform PostOrder Binary Tree traversal from Root Node
        /// </summary>
        /// <param name="root">Rood Node of Binary Tree</param>
        /// <returns>IList of tree values</returns>
        public IList<int> PostOrder(Node root)
        {
            List<int> results = new List<int>();
            if (root == null) return results;
            if (root.Left != null)
            {
                results.AddRange(PostOrder(root.Left));
            }

            if (root.Right != null)
            {
                results.AddRange(PostOrder(root.Right));
            }

            results.Add(root.Value);

            return results;
        }
    }
}
