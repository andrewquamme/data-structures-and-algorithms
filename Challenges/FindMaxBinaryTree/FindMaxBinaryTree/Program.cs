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
            tree.Root.Right = new Node(3);
        }


        public static int FindMaxValue(Tree tree)
        {
            int max = 0;
            if (tree.Root == null) return max;
            max = InOrder(tree.Root, max);
            return max;
        }

        public static int InOrder(Node root, int max)
        {
            if (root.Left != null) InOrder(root.Left, max);
            if (root.Value > max) max = root.Value;
            if (root.Right != null) InOrder(root.Right, max);
            return max;
        }

    }
}
