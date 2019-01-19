using System;
using Xunit;
using StacksAndQueues.Classes;

namespace StacksAndQueuesTDD
{
    public class StackTests
    {
        [Fact]
        public void TestEmptyStackCreation()
        {
            Stack stack = new Stack();
            Assert.Null(stack.Top);
        }

        [Fact]
        public void TestStackCreationWithNode()
        {
            Stack stack = new Stack();
            stack.Push(1);
            Assert.Equal(1, stack.Top.Value);
        }

        [Fact]
        public void TestPushToEmptyStack()
        {
            Stack stack = new Stack();
            stack.Push(5);
            Assert.Equal(5, stack.Top.Value);
        }

        [Fact]
        public void TestPushToStackWithNode()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            int[] expected = { 2, 1 };
            int[] actual = { stack.Top.Value, stack.Top.Next.Value };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPeekAtStack()
        {
            Stack stack = new Stack();
            stack.Push(1);
            Assert.Equal(1, stack.Peek());
        }

        //[Fact]
        //public void TestPeekAtEmptyStack()
        //{
        //    Stack stack = new Stack();
        //    Assert.Null(stack.Peek());
        //}

        //[Fact]
        //public void TestPopFromStack()
        //{
        //    Node node = new Node(5);
        //    Stack stack = new Stack(node);

        //}
    }
}
