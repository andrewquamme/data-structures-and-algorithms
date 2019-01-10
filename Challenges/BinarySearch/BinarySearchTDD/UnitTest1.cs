using System;
using Xunit;
using BinarySearch;

namespace BinarySearchTDD
{
    public class TestFoundInArray
    {

        [Fact]
        public void TestFoundExampleInput()
        {
            int[] array = {4, 8, 15, 16, 23, 42};
            Assert.Equal(2, Program.BinarySearch(array, 15));
        }

        [Fact]
        public void TestNumberFoundAtMid()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Assert.Equal(2, Program.BinarySearch(array, 3));
        }

        [Fact]
        public void TestNumberFoundAtMax()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Assert.Equal(4, Program.BinarySearch(array, 5));
        }

        [Fact]
        public void TestNumberFoundAtMin()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Assert.Equal(0, Program.BinarySearch(array, 1));
        }
    }

    public class TestNotFoundInArray
    {
        [Fact]
        public void TestNumberNotFound()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Assert.Equal(-1, Program.BinarySearch(array, 6));
        }

        [Fact]
        public void TestNotFoundExampleInput()
        {
            int[] array = { 11, 22, 33, 44, 55, 66, 77 };
            Assert.Equal(-1, Program.BinarySearch(array, 90));
        }
    }
}
