using System;
using Xunit;
using QueueWithStacks.Classes;

namespace QueueWithStacksTDD
{
    public class QueueWithStacksTDD
    {
        [Fact]
        public void TestForEmptyPseudoQueue()
        {
            PsuedoQueue queue = new PsuedoQueue();
            Assert.Null(queue.stackOne.Top);
        }

        [Fact]
        public void TestEnqueue()
        {
            PsuedoQueue queue = new PsuedoQueue();
            queue.Enqueue(5);
            Assert.Equal(5, queue.stackOne.Top.Value);
        }

        [Fact]
        public void TestMultiEnqueue()
        {
            PsuedoQueue queue = new PsuedoQueue();
            queue.Enqueue(5);
            queue.Enqueue(4);
            Assert.Equal(4, queue.stackOne.Top.Value);
        }

        [Fact]
        public void TestDequeue()
        {
            PsuedoQueue queue = new PsuedoQueue();
            queue.Enqueue(5);
            Assert.Equal(5, queue.Dequeue().Value);
        }

        [Fact]
        public void TestMultiDequeue()
        {
            PsuedoQueue queue = new PsuedoQueue();
            queue.Enqueue(5);
            queue.Enqueue(4);
            queue.Dequeue();
            Assert.Equal(4, queue.Dequeue().Value);
        }

        [Fact]
        public void TestStackTwoAfterDequeue()
        {
            PsuedoQueue queue = new PsuedoQueue();
            queue.Enqueue(5);
            queue.Enqueue(4);
            queue.Dequeue();
            Assert.Equal(4, queue.stackTwo.Top.Value);
        }

        [Fact]
        public void TestStackOneAfterDequeueEnqueue()
        {
            PsuedoQueue queue = new PsuedoQueue();
            queue.Enqueue(5);
            queue.Enqueue(4);
            queue.Dequeue();
            queue.Enqueue(3);
            Assert.Equal(3, queue.stackOne.Top.Value);
        }
    }
}
