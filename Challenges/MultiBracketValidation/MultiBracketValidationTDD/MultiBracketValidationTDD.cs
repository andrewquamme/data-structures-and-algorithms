using System;
using Xunit;
using MultiBracketValidation;

namespace MultiBracketValidationTDD
{
    public class MultiBracketValidationTDD
    {
        [Fact]
        public void ExampleInputOne()
        {
            string test = "{}";
            Assert.True(Program.MultiBrackValidation(test));
        }

        [Fact]
        public void ExampleInputFive()
        {
            string test = "{}{Code}[Fellows](())";
            Assert.True(Program.MultiBrackValidation(test));
        }

        [Fact]
        public void ExampleInputSix()
        {
            string test = "[({}]";
            Assert.False(Program.MultiBrackValidation(test));
        }

        [Fact]
        public void ExampleInput()
        {
            string test = "({}[]";
            Assert.False(Program.MultiBrackValidation(test));
        }
    }
}
