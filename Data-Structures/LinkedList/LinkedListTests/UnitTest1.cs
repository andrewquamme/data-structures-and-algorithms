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
        public void TestForEmptyList()
        {
            LList list = new LList();
            Assert.Null(list.Head);
        }

        [Fact]
        public void TestForDoesNotInclude()
        {
            LList list = new LList();
            Assert.False(list.Includes(5));
        }
        
    }

    public class InsertTests
    {
        [Fact]
        public void TestInsertionType()
        {
            LList list = new LList();
            list.Insert(2);
            Type expected = typeof(Node);
            Assert.IsType(expected, list.Head);
        }

        [Fact]
        public void TestInsertionValues()
        {
            LList list = new LList();
            list.Insert(2);
            int[] expected = { 2 };
            int[] actual = { list.Head.Value };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultipleInsertionValues()
        {
            LList list = new LList();
            list.Insert(2);
            list.Insert(3);
            int[] expected = { 3, 2 };
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
        public void MultiListDoesInclude()
        {
            LList list = new LList();
            list.Insert(5);
            list.Insert(7);
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

    public class AppendTests
    {
        [Fact]
        public void TestAppend()
        {
            LList list = new LList();
            list.Insert(2);
            list.Insert(3);
            list.Insert(1);
            list.Append(5);
            int[] expected = { 1, 3, 2, 5 };
            int[] actual = { list.Head.Value, list.Head.Next.Value, list.Head.Next.Next.Value, list.Head.Next.Next.Next.Value };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultiAppend()
        {
            LList list = new LList();
            list.Insert(2);
            list.Insert(3);
            list.Append(1);
            list.Append(5);
            int[] expected = { 3, 2, 1, 5 };
            int[] actual = { list.Head.Value, list.Head.Next.Value, list.Head.Next.Next.Value, list.Head.Next.Next.Next.Value };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAppendToNull()
        {
            LList list = new LList();
            list.Append(2);
            int[] expected = { 2 };
            int[] actual = { list.Head.Value };
            Assert.Equal(expected, actual);
        }
    }

    public class InsertBeforeTests
    {
        [Fact]
        public void TestInsertBefore()
        {
            LList list = new LList();
            list.Append(1);
            list.Append(3);
            list.Append(2);
            list.InsertBefore(3, 5);
            int[] expected = { 1, 5, 3, 2 };
            int[] actual = { list.Head.Value, list.Head.Next.Value, list.Head.Next.Next.Value, list.Head.Next.Next.Next.Value };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultiInsertBefore()
        {
            LList list = new LList();
            list.Append(1);
            list.Append(3);
            list.Append(2);
            list.InsertBefore(3, 5);
            list.InsertBefore(2, 6);
            int[] expected = { 1, 5, 3, 6, 2 };
            int[] actual = { list.Head.Value, list.Head.Next.Value, list.Head.Next.Next.Value, list.Head.Next.Next.Next.Value, list.Head.Next.Next.Next.Next.Value };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestValueNotFound()
        {
            LList list = new LList();
            list.Append(1);
            list.Append(3);
            list.Append(2);
            list.InsertBefore(4, 5);
            int[] expected = { 1, 3, 2 };
            int[] actual = { list.Head.Value, list.Head.Next.Value, list.Head.Next.Next.Value };
            Assert.Equal(expected, actual);
        }
    }

    public class InserAfterTests
    {
        [Fact]
        public void TestInsertAfter()
        {
            LList list = new LList();
            list.Append(1);
            list.Append(3);
            list.Append(2);
            list.InsertAfter(3, 5);
            int[] expected = { 1, 3, 5, 2 };
            int[] actual = { list.Head.Value, list.Head.Next.Value, list.Head.Next.Next.Value, list.Head.Next.Next.Next.Value };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestInsertAfterAtEndOfList()
        {
            LList list = new LList();
            list.Append(1);
            list.Append(3);
            list.Append(2);
            list.InsertAfter(2, 5);
            int[] expected = { 1, 3, 2, 5 };
            int[] actual = { list.Head.Value, list.Head.Next.Value, list.Head.Next.Next.Value, list.Head.Next.Next.Next.Value };
            Assert.Equal(expected, actual);
        }
    }
}
