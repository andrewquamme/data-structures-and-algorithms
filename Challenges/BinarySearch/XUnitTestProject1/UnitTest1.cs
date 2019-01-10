using System;
using Xunit;
using BinarySearch;

namespace XUnitTestProject1
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
        public void TestNumberFound()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Assert.Equal(4, Program.BinarySearch(array, 5));
        }
    }
}
