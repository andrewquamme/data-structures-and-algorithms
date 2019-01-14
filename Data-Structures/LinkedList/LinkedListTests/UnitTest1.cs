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
        [Fact]
        public void TestInsertion()
        {
            LList list = new LList();
            list.Insert(2);
            int[] expected = { 2, 0 };
            int[] actual = { list.Head.Value, list.Head.Next.Value };
            Assert.Equal(expected, actual);
        }
    }

    public class IncludesTests
    {
        [Fact]
        public void ListDoesInclude()
        {
            LList list = new LList();
            list.Insert(5);
            Assert.True(list.Includes(5));
        }

        [Fact]
        public void ListDoesNotIncludes()
        {
            LList list = new LList();
            list.Insert(5);
            Assert.False(list.Includes(2));
        }
    }
}
