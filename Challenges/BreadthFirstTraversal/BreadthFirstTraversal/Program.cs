using BreadthFirstTraversal.Classes;
using System;

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
        }

        public static void BreadthFirst(Node root)
        {

        }
    }
}
