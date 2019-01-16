using System;
using Xunit;
using LinkedListKthFromEnd;
using LinkedList.Classes;

namespace LinkedListKthFromEndTDD
{
    public class TestValidInputs
    {
        [Fact]
        public void TestWhiteboardSolution()
        {
            LList list = new LList();
            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            Assert.Equal(1 , Program.KthFromEnd(list, 3));
        }

        [Fact]
        public void TestChallengeExample()
        {
            LList list = new LList();
            list.Append(1);
            list.Append(3);
            list.Append(8);
            list.Append(2);
            Assert.Equal(2, Program.KthFromEnd(list, 0));
        }
    }

    public class TestExceptions
    {
        [Fact]
        public void TestNullException()
        {
            LList list = new LList();
            Assert.Equal(-1, Program.KthFromEnd(list, 3));
        }

        [Fact]
        public void TestKTooLargeException()
        {
            LList list = new LList();
            list.Append(1);
            list.Append(3);
            list.Append(8);
            list.Append(2);
            Assert.Equal(-1, Program.KthFromEnd(list, 6));
        }
    }
}
