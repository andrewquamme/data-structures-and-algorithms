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
    }

    public class InsertTests
    {
        [Fact]
        public void TestWithoutValue()
        {
            LList list = new LList();
            Assert.True(list.Includes(0));
        }

        [Fact]
        public void TestWithValue()
        {
            LList list = new LList(123);
            Assert.True(list.Includes(123));
        }
    }
}
