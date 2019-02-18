using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeSumOfOdds.Classes
{
    public class Tree
    {
        public Node Root { get; set; }

        public Tree()
        {
            Root = null;
        }

        /// <summary>
        /// Create a tree with a Node as Root
        /// </summary>
        /// <param name="root">Root Node</param>
        public Tree(Node root)
        {
            Root = root;
        }
    }
}
