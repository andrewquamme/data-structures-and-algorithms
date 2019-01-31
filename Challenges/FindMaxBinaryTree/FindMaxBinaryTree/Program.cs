using FindMaxBinaryTree.Classes;
using System;

namespace FindMaxBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Left.Left = new Node(3);
            tree.Root.Right = new Node(4);
            tree.Root.Right.Right = new Node(5);
            Console.WriteLine(FindMaxValue(tree));
        }

        /// <summary>
        /// Takes in a binary tree and traverses in-order
        /// to find max value in the tree. Returns null if
        /// tree is empty
        /// </summary>
        /// <param name="tree">Binary Tree</param>
        /// <returns>Max Value</returns>
        public static int? FindMaxValue(Tree tree)
        {
            int max = 0;
            if (tree.Root == null) return null;
            max = InOrder(tree.Root, max);
            return max;
        }

        /// <summary>
        /// Perform in-order traversal of a tree from root,
        /// compare value at Node to current max
        /// </summary>
        /// <param name="root">Root Node</param>
        /// <param name="max">Current Max in tree</param>
        /// <returns></returns>
        public static int InOrder(Node root, int max)
        {
            if (root.Left != null) max = InOrder(root.Left, max);
            if (root.Value > max) max = root.Value;
            if (root.Right != null) max = InOrder(root.Right, max);
            return max;
        }

    }
}
