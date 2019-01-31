using System;
using Xunit;
using FindMaxBinaryTree.Classes;
using FindMaxBinaryTree;

namespace FindMaxBinaryTreeTDD
{
    public class FindMaxBinaryTreeTDD
    {
        [Fact]
        public void TestEmptyTree()
        {
            Tree tree = new Tree();
            Assert.Null(Program.FindMaxValue(tree));
        }

        [Fact]
        public void TestWhiteboardTree()
        {
            Tree tree = new Tree();
            tree.Root = new Node(1);
            tree.Root.Left = new Node(2);
            tree.Root.Left.Left = new Node(3);
            tree.Root.Right = new Node(4);
            tree.Root.Right.Right = new Node(5);
            Assert.Equal(5, Program.FindMaxValue(tree));
        }

        [Fact]
        public void TestSameValueTree()
        {
            Tree tree = new Tree();
            tree.Root = new Node(5);
            tree.Root.Left = new Node(5);
            tree.Root.Left.Left = new Node(5);
            tree.Root.Right = new Node(5);
            tree.Root.Right.Right = new Node(5);
            Assert.Equal(5, Program.FindMaxValue(tree));
        }

        [Fact]
        public void TestNegativeValueTree()
        {
            Tree tree = new Tree();
            tree.Root = new Node(-1);
            tree.Root.Left = new Node(-2);
            tree.Root.Left.Left = new Node(-3);
            tree.Root.Right = new Node(-4);
            tree.Root.Right.Right = new Node(-5);
            Assert.Equal(-1, Program.FindMaxValue(tree));
        }
    }
}
