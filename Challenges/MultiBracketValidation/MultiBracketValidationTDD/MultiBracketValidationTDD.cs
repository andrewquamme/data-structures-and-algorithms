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
    }
}
