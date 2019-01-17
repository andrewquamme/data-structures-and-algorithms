using System;
using Xunit;
using LinkedList.Classes;
using LinkedListMerge;

namespace LLMergeTDD
{
    public class TestEqualLengthLists
    {
        [Fact]
        public void Test()
        {
            LList list1 = new LList();
            list1.Append(1);
            list1.Append(3);
            list1.Append(2);

            LList list2 = new LList();
            list2.Append(5);
            list2.Append(9);
            list2.Append(2);

            LList expected = new LList();
            list1.Append(1);
            list1.Append(5);
            list1.Append(3);
            list1.Append(9);
            list1.Append(2);
            list1.Append(2);

            LList result = Program.MergeLists(list1, list2);
            
            Assert.Equal(expected, result);
        }
    }
}
