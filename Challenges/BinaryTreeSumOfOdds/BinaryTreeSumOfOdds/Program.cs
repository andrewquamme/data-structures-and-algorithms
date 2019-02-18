using BinaryTreeSumOfOdds.Classes;
using System;
using System.Collections.Generic;

namespace BinaryTreeSumOfOdds
{
    public class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Root = (new Node(1));
            tree.Root.Left = (new Node(2));
            tree.Root.Right = (new Node(3));
            tree.Root.Left.Left = (new Node(4));
            tree.Root.Left.Right = (new Node(5));
            tree.Root.Right.Left = (new Node(6));
            tree.Root.Right.Right = (new Node(7));

            Console.WriteLine(BinaryTreeSumOfOdds(tree.Root)); //16
        }

        /// <summary>
        /// Takes in a tree by its Root node and performs a
        /// breadth-first traversal of the tree, keeping a 
        /// running total of odd nodes and returning the sum
        /// </summary>
        /// <param name="root">Root Node of Tree</param>
        /// <returns>Sum of odd Nodes</returns>
        public static int BinaryTreeSumOfOdds(Node root)
        {
            int total = 0;

            if (root == null)
            {
                Console.WriteLine("Tree is empty");
                return total;
            }

            Queue breadth = new Queue();
            breadth.Enqueue(root);

            while (breadth.Peek() != null)
            {
                Node front = breadth.Dequeue();

                if (front.Value % 2 != 0) total = total + front.Value;

                if (front.Left != null) breadth.Enqueue(front.Left);
                
                if (front.Right != null) breadth.Enqueue(front.Right);
            }

            return total;
        }
    }
}
