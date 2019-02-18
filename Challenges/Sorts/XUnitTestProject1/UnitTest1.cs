using System;
using Xunit;
using Sorts;

namespace SortsTDD
{
    public class InsertionSortTests
    {
        [Fact]
        public void TestValidSort()
        {
            int[] testArr = { 4, 3, 1, 8, 5, 7, 2 };
            int[] expected = { 1, 2, 3, 4, 5, 7, 8 };
            Program.InsertionSort(testArr);
            Assert.Equal(expected, testArr);
        }

        [Fact]
        public void TestSortedArray()
        {
            int[] testArr = { 1, 2, 3, 4, 5, 6, 7, 9 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 9 };
            Program.InsertionSort(testArr);
            Assert.Equal(expected, testArr);
        }

        [Fact]
        public void TestBackwardsSortedArray()
        {
            int[] testArr = { 9, 7, 6, 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 9 };
            Program.InsertionSort(testArr);
            Assert.Equal(expected, testArr);
        }

        [Fact]
        public void TestEmptyArray()
        {
            int[] testArr = { };
            int[] expected = { };
            Program.InsertionSort(testArr);
            Assert.Equal(expected, testArr);
        }

        [Fact]
        public void TestOneElementArray()
        {
            int[] testArr = { 1 };
            int[] expected = { 1 };
            Program.InsertionSort(testArr);
            Assert.Equal(expected, testArr);
        }
    }
}
