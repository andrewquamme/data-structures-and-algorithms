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
        public void TestPushToStack()
        {
            Stack stack = new Stack();
            stack.Push(5);
            Assert.Equal(5, stack.Top.Value);
        }

        [Fact]
        public void TestPeekAtStack()
        {
            Stack stack = new Stack();
            stack.Push(1);
            Assert.Equal(1, stack.Peek());
        }

        [Fact]
        public void TestPeekAtEmptyStack()
        {
            Stack stack = new Stack();
            Assert.Null(stack.Peek());
        }

        [Fact]
        public void TestPopFromStack()
        {
            Stack stack = new Stack();
            stack.Push(5);
            Assert.Equal(5, stack.Pop());
        }
    }
}
