using System;
using Xunit;
using UniqueCharacters;

namespace UniqueCharactersTDD
{
    public class UnitTest1
    {
        [Fact]
        public void TestTrue()
        {
            Assert.True(Program.UniqueCharacters("brown cat"));
        }

        [Fact]
        public void TestFalse()
        {
            Assert.False(Program.UniqueCharacters("BROWN dog"));
        }

        [Fact]
        public void TestEmpty()
        {
            //If a string is empty, technically its characters are unique
            Assert.True(Program.UniqueCharacters(""));
        }
    }
}
