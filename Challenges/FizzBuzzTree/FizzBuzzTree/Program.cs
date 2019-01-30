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

            FizzBuzzTree(testTree.Root);
        }

        public static Node FizzBuzzTree(Node root)
        {
            if (root == null) return root;

            if (Convert.ToInt32(root.Value) % 3 == 0 && Convert.ToInt32(root.Value) % 5 == 0)
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
                FizzBuzzTree(root.Left);
            }

            if (root.Right != null)
            {
                FizzBuzzTree(root.Right);
            }

            return root;
        }

    }
}
