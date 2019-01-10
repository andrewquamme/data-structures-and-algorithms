using System;
using Xunit;
using BinarySearch;

namespace BinarySearchTDD
{
    public class BinarySearchTest
    {
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

        [Fact]
        public void TestNumberNotFound()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Assert.Equal(-1, Program.BinarySearch(array, 6));
        }
    }
}
