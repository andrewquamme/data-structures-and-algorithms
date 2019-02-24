using System;
using Xunit;
using TreeIntersection;
using System.Collections.Generic;
using Trees.Classes;

namespace TreeIntersectionTDD
{
    public class UnitTest1
    {
        [Fact]
        public void TestWithMatches()
        {
            BinaryTree testTree1 = new BinaryTree();
            testTree1.Root = new Node(1);
            testTree1.Root.Left = new Node(2);
            testTree1.Root.Right = new Node(3);
            testTree1.Root.Left.Left = new Node(4);
            testTree1.Root.Left.Right = new Node(6);

            BinaryTree testTree2 = new BinaryTree();
            testTree2.Root = new Node(2);
            testTree2.Root.Left = new Node(3);
            testTree2.Root.Right = new Node(8);
            testTree2.Root.Left.Left = new Node(6);
            testTree2.Root.Left.Right = new Node(9);

            IList<int> expected = new List<int> { 6, 3, 2 };
            IList<int> results = Program.TreeIntersection(testTree1, testTree2);

            Assert.Equal(expected, results);
        }

        [Fact]
        public void TestWithoutMatches()
        {
            BinaryTree testTree1 = new BinaryTree();
            testTree1.Root = new Node(1);
            testTree1.Root.Left = new Node(2);
            testTree1.Root.Right = new Node(3);
            testTree1.Root.Left.Left = new Node(4);
            testTree1.Root.Left.Right = new Node(5);

            BinaryTree testTree2 = new BinaryTree();
            testTree2.Root = new Node(6);
            testTree2.Root.Left = new Node(7);
            testTree2.Root.Right = new Node(8);
            testTree2.Root.Left.Left = new Node(9);
            testTree2.Root.Left.Right = new Node(10);

            IList<int> expected = new List<int> { };
            IList<int> results = Program.TreeIntersection(testTree1, testTree2);

            Assert.Equal(expected, results);
        }

        [Fact]
        public void TestEmptyTrees()
        {
            BinaryTree testTree1 = new BinaryTree();
            BinaryTree testTree2 = new BinaryTree();

            IList<int> expected = new List<int> { };
            IList<int> results = Program.TreeIntersection(testTree1, testTree2);

            Assert.Equal(expected, results);
        }
    }
}
