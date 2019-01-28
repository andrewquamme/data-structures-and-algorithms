using System;
using Trees.Classes;
using System.Collections.Generic;


namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree testTree = new BinarySearchTree();
            testTree.Add(100);
            testTree.Add(50);
            testTree.Add(200);
            testTree.Add(25);
            testTree.Add(75);
            testTree.Add(150);
            testTree.Add(300);
            testTree.Add(60);
            testTree.Add(90);
            testTree.Add(342);
            Console.WriteLine(testTree.Contains(90));
            Console.WriteLine(testTree.Contains(1));
            IList<int> results = testTree.PreOrder(testTree.Root);
            foreach(int item in results)
            {
                Console.WriteLine(item);
            }
        }
    }
}
