using System;
using Xunit;
using LinkedList.Classes;

namespace LinkedListTests
{

    public class InstantiationTests
    {
        [Fact]
        public void TestForLList()
        {
            LList list = new LList();
            Type expected = typeof(LList);
            Assert.IsType(expected, list);
        }

        [Fact]
        public void TestForNotNull()
        {
            LList list = new LList();
            Assert.NotNull(list.Head);
        }

        [Fact]
        public void TestWithoutValue()
        {
            LList list = new LList();
            Assert.Equal(0, list.Head.Value);
        }

        [Fact]
        public void TestWithValue()
        {
            LList list = new LList(123);
            Assert.Equal(123, list.Head.Value);
        }
    }

    public class InsertTests
    {
        
    }
}
