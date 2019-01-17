using System;
using Xunit;
using LinkedList.Classes;
using LinkedListMerge;

namespace LLMergeTDD
{
    public class TestEqualLengthLists
    {
        [Fact]
        public void TestChallengeExample()
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
            expected.Append(1);
            expected.Append(5);
            expected.Append(3);
            expected.Append(9);
            expected.Append(2);
            expected.Append(2);

            LList result = Program.MergeLists(list1, list2);
            
            Assert.Equal(expected.Print(), result.Print());
        }
    }

    public class TestUnequalEqualLengthLists
    {
        [Fact]
        public void TestOneLongerThanTwo()
        {
            LList list1 = new LList();
            list1.Append(1);
            list1.Append(3);
            list1.Append(2);

            LList list2 = new LList();
            list2.Append(5);
            list2.Append(9);

            LList expected = new LList();
            expected.Append(1);
            expected.Append(5);
            expected.Append(3);
            expected.Append(9);
            expected.Append(2);

            LList result = Program.MergeLists(list1, list2);

            Assert.Equal(expected.Print(), result.Print());
        }

        [Fact]
        public void TestTwoLongerThanOne()
        {
            LList list1 = new LList();
            list1.Append(1);
            list1.Append(3);

            LList list2 = new LList();
            list2.Append(5);
            list2.Append(9);
            list2.Append(4);

            LList expected = new LList();
            expected.Append(1);
            expected.Append(5);
            expected.Append(3);
            expected.Append(9);
            expected.Append(4);

            LList result = Program.MergeLists(list1, list2);

            Assert.Equal(expected.Print(), result.Print());
        }
    }
}
