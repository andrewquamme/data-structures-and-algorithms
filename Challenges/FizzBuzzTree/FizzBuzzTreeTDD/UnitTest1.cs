using System;
using Xunit;
using FizzBuzzTree;
using FizzBuzzTree.Classes;

namespace FizzBuzzTreeTDD
{
    public class FizzBuzzTreeTests
    {
        [Fact]
        public void Test1()
        {
            Tree testTree = new Tree();
            testTree.Root = new Node(3);
            testTree.Root.Left = new Node(2);
            testTree.Root.Right = new Node(5);
            testTree.Root.Left.Left = new Node(15);
            testTree.Root.Left.Right = new Node(30);
            Program.FizzBuzzTree(testTree.Root);

            Object[] expected = {
                "Fizz",
                2,
                "Buzz",
                "FizzBuzz",
                "FizzBuzz" };

            Object[] results = {
                testTree.Root.Value,
                testTree.Root.Left.Value,
                testTree.Root.Right.Value,
                testTree.Root.Left.Left.Value,
                testTree.Root.Left.Right.Value };

            Assert.Equal(expected, results);
        }
    }
}
