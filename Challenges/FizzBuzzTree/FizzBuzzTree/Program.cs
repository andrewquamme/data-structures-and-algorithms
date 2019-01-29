using System;
using FizzBuzzTree.Classes;

namespace FizzBuzzTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Tree testTree = new Tree();
            testTree.Root = new Node(3);
            testTree.Root.Left = new Node(2);
            testTree.Root.Right = new Node(5);
            testTree.Root.Left.Left = new Node(15);
            testTree.Root.Left.Right = new Node(30);

            FizzBuzzTree(testTree);
        }

        public static Tree FizzBuzzTree(Tree tree)
        {
            if (tree.Root == null) return tree;
            FizzBuzzTreeHelper(tree.Root);
            return tree;
        }

        public static void FizzBuzzTreeHelper(Node root)
        {
            if(Convert.ToInt32(root.Value) % 3 == 0 && Convert.ToInt32(root.Value) % 5 == 0)
            {
                root.Value = "FizzBuzz";
            }
            else if (Convert.ToInt32(root.Value) % 3 == 0)
            {
                root.Value = "Fizz";
            }
            else if (Convert.ToInt32(root.Value) % 5 == 0)
            {
                root.Value = "Buzz";
            }

            if (root.Left != null)
            {
                FizzBuzzTreeHelper(root.Left);
            }

            if (root.Right != null)
            {
                FizzBuzzTreeHelper(root.Right);
            }
        }
    }
}
