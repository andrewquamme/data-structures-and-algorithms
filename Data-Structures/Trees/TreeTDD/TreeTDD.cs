using System;
using Xunit;
using Trees.Classes;
using System.Collections.Generic;

namespace TreeTDD
{
    public class BinaryTreeTraversalTests
    {
        public class PreOrderTraversalTests
        {
            [Fact]
            public void TestPreOrderTrue()
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
            public void TestPreOrderNull()
            {
                BinaryTree testTree = new BinaryTree();
                List<int> expected = new List<int> { };
                Assert.Equal(expected, testTree.PreOrder(testTree.Root));
            }

            [Fact]
            public void TestPreOrderFalse()
            {
                BinaryTree testTree = new BinaryTree();
                testTree.Root = new Node(1);
                testTree.Root.Left = new Node(2);
                testTree.Root.Right = new Node(3);
                testTree.Root.Left.Left = new Node(4);
                testTree.Root.Left.Right = new Node(5);
                List<int> notExpected = new List<int> { 1, 2, 3, 4, 5 };
                Assert.NotEqual(notExpected, testTree.PreOrder(testTree.Root));
            }

        }
       
        public class InOrderTraversalTests
        {
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
            public void TestInOrderNull()
            {
                BinaryTree testTree = new BinaryTree();
                List<int> expected = new List<int> { };
                Assert.Equal(expected, testTree.InOrder(testTree.Root));
            }

            [Fact]
            public void TestInOrderFalse()
            {
                BinaryTree testTree = new BinaryTree();
                testTree.Root = new Node(1);
                testTree.Root.Left = new Node(2);
                testTree.Root.Right = new Node(3);
                testTree.Root.Left.Left = new Node(4);
                testTree.Root.Left.Right = new Node(5);
                List<int> notExpected = new List<int> { 1, 2, 3, 4, 5 };
                Assert.NotEqual(notExpected, testTree.InOrder(testTree.Root));
            }
        }
        
        public class PostOrderTraversalTests
        {
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

            [Fact]
            public void TestPostOrderNull()
            {
                BinaryTree testTree = new BinaryTree();
                List<int> expected = new List<int> { };
                Assert.Equal(expected, testTree.PostOrder(testTree.Root));
            }

            [Fact]
            public void TestPostOrderFalse()
            {
                BinaryTree testTree = new BinaryTree();
                testTree.Root = new Node(1);
                testTree.Root.Left = new Node(2);
                testTree.Root.Right = new Node(3);
                testTree.Root.Left.Left = new Node(4);
                testTree.Root.Left.Right = new Node(5);
                List<int> notExpected = new List<int> { 1, 2, 3, 4, 5 };
                Assert.NotEqual(notExpected, testTree.PostOrder(testTree.Root));
            }
        }
       
    }

    public class BinarySearchTreeTests
    {
        public class AddMethodTests
        {
            [Fact]
            public void TestAdd()
            {
                BinarySearchTree testTree = new BinarySearchTree();
                testTree.Add(100);
                Assert.Equal(100, testTree.Root.Value);
            }

            [Fact]
            public void TestAddOrder()
            {
                BinarySearchTree testTree = new BinarySearchTree();
                testTree.Root = new Node(5);
                testTree.Add(1);
                Assert.Equal(1, testTree.Root.Left.Value);

            }

            [Fact]
            public void TestMultiAddOrder()
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
                List<int> expected = new List<int> { 100, 50, 25, 75, 60, 90, 200, 150, 300, 342 };
                IList<int> results = testTree.PreOrder(testTree.Root);
                Assert.Equal(expected, results);
            }
        }
        
        public class ContainsMethodTests
        {
            [Fact]
            public void TestTrue()
            {
                BinarySearchTree testTree = new BinarySearchTree();
                testTree.Add(100);
                testTree.Add(50);
                testTree.Add(200);
                testTree.Add(25);
                testTree.Add(75);
                testTree.Add(150);
                Assert.True(testTree.Contains(25));
            }

            [Fact]
            public void TestFalse()
            {
                BinarySearchTree testTree = new BinarySearchTree();
                testTree.Add(100);
                testTree.Add(50);
                testTree.Add(200);
                testTree.Add(25);
                testTree.Add(75);
                testTree.Add(150);
                Assert.False(testTree.Contains(400));
            }

            [Fact]
            public void TestEmptyTree()
            {
                BinarySearchTree testTree = new BinarySearchTree();
                Assert.False(testTree.Contains(5));
            }
        }

    }
}
