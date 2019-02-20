using System;
using System.Collections.Generic;
using TreeIntersection.Classes;
using Trees.Classes;

namespace TreeIntersection
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree testTree1 = new BinaryTree();
            testTree1.Root = new Node(1);
            testTree1.Root.Left = new Node(2);
            testTree1.Root.Right = new Node(3);
            testTree1.Root.Left.Left = new Node(4);
            testTree1.Root.Left.Right = new Node(5);

            BinaryTree testTree2 = new BinaryTree();
            testTree2.Root = new Node(6);
            testTree2.Root.Left = new Node(6);
            testTree2.Root.Right = new Node(3);
            testTree2.Root.Left.Left = new Node(8);
            testTree2.Root.Left.Right = new Node(9);

            IList<int> results = TreeIntersection(testTree1, testTree2);
        }

        public static IList<int> TreeIntersection(BinaryTree t1, BinaryTree t2)
        {
            var t1Vals = t1.InOrder(t1.Root);
            var t2Vals = t2.InOrder(t2.Root);
            List<int> commonValues = new List<int>();
            Hashtable treeTable = new Hashtable(1024);

            foreach(int val in t1Vals)
            {
                treeTable.Add(val, val);
            }

            foreach(int val in t2Vals)
            {
                if (treeTable.Contains(val))
                {
                    commonValues.Add(val);
                }
            }

            return commonValues;
        }
    }
}
