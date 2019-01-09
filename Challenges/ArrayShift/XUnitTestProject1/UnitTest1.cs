using System;
using Xunit;
using ArrayShift;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] array = { 1, 2, 3, 4 };
            int[] returnArray = { 1, 2, 5, 3, 4 };
            Assert.Equal(returnArray, Program.ArrayShift(array, 5));
        }

        [Fact]
        public void Test2()
        {
            int[] array = { 2,4,6,8 };
            int[] returnArray = {2,4,5,6,8 };
            Assert.Equal(returnArray, Program.ArrayShift(array, 5));
        }

        [Fact]
        public void Test3()
        {
            int[] array = { 4, 8, 15, 23, 42 };
            int[] returnArray = { 4, 8, 15, 16, 23, 42 };
            Assert.Equal(returnArray, Program.ArrayShift(array, 16));
        }
    }
}
