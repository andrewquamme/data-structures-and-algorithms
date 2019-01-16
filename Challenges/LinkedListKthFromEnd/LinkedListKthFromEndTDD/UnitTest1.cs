using System;
using Xunit;
using LinkedListKthFromEnd;
using LinkedList.Classes;

namespace LinkedListKthFromEndTDD
{
    public class TestsWhiteboardSolution
    {
        [Fact]
        public void Test1()
        {
            LList list = new LList();
            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            Assert.Equal(1 , Program.KthFromEnd(list, 3));
        }
    }
}
