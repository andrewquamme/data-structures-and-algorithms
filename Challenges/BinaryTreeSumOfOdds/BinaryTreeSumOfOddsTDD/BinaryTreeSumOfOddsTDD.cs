using BinaryTreeSumOfOdds.Classes;
using System;
using Xunit;
using BinaryTreeSumOfOdds;

namespace BinaryTreeSumOfOddsTDD
{
    public class BinaryTreeSumOfOddsTDD
    {
        [Fact]
        public void TestEmptyTree()
        {
            Tree tree = new Tree();
            Assert.Equal(0, Program.BinaryTreeSumOfOdds(tree.Root));
        }

        [Fact]
        public void TestTree()
        {
            Tree tree = new Tree();
            tree.Root = (new Node(1));
            tree.Root.Left = (new Node(2));
            tree.Root.Right = (new Node(3));
            tree.Root.Left.Left = (new Node(4));
            tree.Root.Left.Right = (new Node(5));
            tree.Root.Right.Left = (new Node(6));
            tree.Root.Right.Right = (new Node(7));
            Assert.Equal(16, Program.BinaryTreeSumOfOdds(tree.Root));
        }

        [Fact]
        public void TestTreeWithNegatives()
        {
            Tree tree = new Tree();
            tree.Root = (new Node(-1));
            tree.Root.Left = (new Node(-2));
            tree.Root.Right = (new Node(-3));
            tree.Root.Left.Left = (new Node(-4));
            tree.Root.Left.Right = (new Node(-5));
            tree.Root.Right.Left = (new Node(-6));
            tree.Root.Right.Right = (new Node(-7));
            Assert.Equal(-16, Program.BinaryTreeSumOfOdds(tree.Root));
        }
    }
}
