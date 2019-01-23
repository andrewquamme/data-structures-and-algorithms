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
            Assert.Null(stack.Top.Value);
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
            Assert.Equal(5, stack.Pop().Value);
        }
    }

    public class QueueTests
    {
        [Fact]
        public void TestEmptyQueueCreation()
        {
            Queue queue = new Queue();
            Assert.Null(queue.Front.Value);
        }

        [Fact]
        public void TestEnqueueInEmptyQueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(5);
            Assert.Equal(5, queue.Front.Value);
        }

        [Fact]
        public void TestEnqueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(5);
            queue.Enqueue(4);
            Assert.Equal(4, queue.Rear.Value);
        }

        [Fact]
        public void TestPeek()
        {
            Queue queue = new Queue();
            queue.Enqueue(5);
            Assert.Equal(5, queue.Peek());
        }

        [Fact]
        public void TestPeekAtNull()
        {
            Queue queue = new Queue();
            Assert.Null(queue.Peek());
        }

        [Fact]
        public void TestDequeue()
        {
            Queue queue = new Queue();
            queue.Enqueue(5);
            queue.Enqueue(4);
            Assert.Equal(5, queue.Dequeue().Value);
        }
    }
}
