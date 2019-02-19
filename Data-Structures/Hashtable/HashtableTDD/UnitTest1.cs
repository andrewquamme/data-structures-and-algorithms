using HashTable.Classes;
using System;
using Xunit;

namespace HashtableTDD
{
    public class HashtableTDD
    {
        [Fact]
        public void TestAdd()
        {
            Hashtable testHT = new Hashtable(1024);
            testHT.Add("brainy", "test");
            int index = testHT.Hash("brainy");
            Assert.Equal("test", testHT.HT[index].Value);
        }
    }
}
