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
    }
}
