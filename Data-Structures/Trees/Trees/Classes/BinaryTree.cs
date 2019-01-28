using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinaryTree : Tree
    {
        public IList<int> PreOrder(Node root)
        {
            List<int> results = new List<int>();
            if (root == null) return results;
            if (root.Left != null)
            {
                results.AddRange(PreOrder(root.Left));
            }

            results.Add(root.Value);

            if (root.Right != null)
            {
                results.AddRange(PreOrder(root.Right));
            }

            return results;
        }

        public IList<int> InOrder(Node root)
        {
            List<int> results = new List<int>();
            if (root == null) return results;

            results.Add(root.Value);

            if (root.Left != null)
            {
                results.AddRange(InOrder(root.Left));
            }

            if (root.Right != null)
            {
                results.AddRange(InOrder(root.Right));
            }

            return results;
        }

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
