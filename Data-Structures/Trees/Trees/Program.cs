using System;
using Trees.Classes;
using System.Collections.Generic;


namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree testTree = new BinaryTree();
            testTree.Root = new Node(1);
            testTree.Root.Left = new Node(2);
            testTree.Root.Right = new Node(3);
            testTree.Root.Left.Left = new Node(4);
            testTree.Root.Left.Right = new Node(5);

            IList<int> results = testTree.PreOrder(testTree.Root);
            Console.WriteLine(results);
            foreach(int item in results)
            {
                Console.WriteLine(item);
            }
        }
    }
}
