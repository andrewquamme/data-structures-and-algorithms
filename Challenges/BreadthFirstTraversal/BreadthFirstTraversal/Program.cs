using BreadthFirstTraversal.Classes;
using System;
using System.Collections.Generic;

namespace BreadthFirstTraversal
{
    class Program
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

            BreadthFirst(tree.Root);
        }

        public static List<int> BreadthFirst(Node root)
        {
            List<int> values = new List<int>();
            if(root == null)
            {
                Console.WriteLine("Tree is empty");
                return values;
            }
            Queue breadth = new Queue();
            breadth.Enqueue(root);

            while (breadth.Peek() != null)
            {
                Node front = breadth.Dequeue();
                values.Add(front.Value);
                Console.WriteLine(front.Value);

                if (front.Left != null)
                {
                    breadth.Enqueue(front.Left);
                }

                if (front.Right != null)
                {
                    breadth.Enqueue(front.Right);
                }
            }
            return values;
        }
    }
}
