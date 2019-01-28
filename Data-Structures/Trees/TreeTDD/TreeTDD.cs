using System;
using Xunit;
using Trees.Classes;
using System.Collections.Generic;

namespace TreeTDD
{
    public class TreeTDD
    {
        [Fact]
        public void TestPreOrder()
        {
            BinaryTree testTree = new BinaryTree();
            testTree.Root = new Node(1);
            testTree.Root.Left = new Node(2);
            testTree.Root.Right = new Node(3);
            testTree.Root.Left.Left = new Node(4);
            testTree.Root.Left.Right = new Node(5);
            List<int> expected = new List<int> { 1, 2, 4, 5, 3 };
            Assert.Equal(expected, testTree.PreOrder(testTree.Root));
        }

        [Fact]
        public void TestInOrder()
        {
            BinaryTree testTree = new BinaryTree();
            testTree.Root = new Node(1);
            testTree.Root.Left = new Node(2);
            testTree.Root.Right = new Node(3);
            testTree.Root.Left.Left = new Node(4);
            testTree.Root.Left.Right = new Node(5);
            List<int> expected = new List<int> { 4, 2, 5, 1, 3 };
            Assert.Equal(expected, testTree.InOrder(testTree.Root));
        }

        [Fact]
        public void TestPostOrder()
        {
            BinaryTree testTree = new BinaryTree();
            testTree.Root = new Node(1);
            testTree.Root.Left = new Node(2);
            testTree.Root.Right = new Node(3);
            testTree.Root.Left.Left = new Node(4);
            testTree.Root.Left.Right = new Node(5);
            List<int> expected = new List<int> { 4, 5, 2, 3, 1 };
            Assert.Equal(expected, testTree.PostOrder(testTree.Root));
        }
    }
}
