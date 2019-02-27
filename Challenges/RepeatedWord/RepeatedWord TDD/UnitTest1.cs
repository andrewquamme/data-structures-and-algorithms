using System;
using Xunit;
using HashTable.Classes;
using RepeatedWord;

namespace RepeatedWord_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void EmptyString()
        {
            string testString = null;
            Assert.Equal("Not a valid string", Program.RepeatedWord(testString));
        }

        [Fact]
        public void TestExampleOne()
        {
            string testString = "Once upon a time there was a brave princess who";
            Assert.Equal("a", Program.RepeatedWord(testString));
        }

        [Fact]
        public void TestExampleTwo()
        {
            string testString = "It was a queer sultry summer the summer they electrocuted the Rosenbergs and I didn’t know what I was doing in New York";
            Assert.Equal("summer", Program.RepeatedWord(testString));
        }
    }
}
