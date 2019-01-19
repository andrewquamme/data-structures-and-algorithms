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
    }
}
