using System;
using Xunit;
using StacksAndQueues.Classes;

namespace StacksAndQueuesTDD
{
    public class StackTests
    {
        [Fact]
        public void TestForEmptyStack()
        {
            Stack stack = new Stack();
            Assert.Null(stack.Top);
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
            Node node = new Node(1);
            Stack stack = new Stack(node);
            stack.Push(2);
            int[] expected = { 2, 1 };
            int[] actual = { stack.Top.Value, stack.Top.Next.Value };
            Assert.Equal(expected, actual);
        }
    }
}
