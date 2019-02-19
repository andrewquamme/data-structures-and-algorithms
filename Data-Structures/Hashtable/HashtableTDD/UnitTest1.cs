using HashTable.Classes;
using System;
using Xunit;

namespace HashtableTDD
{
    public class HashtableTDD
    {
        [Fact]
        public void TestHash()
        {
            Hashtable testHT = new Hashtable(1024);
            Assert.Equal(377, testHT.Hash("brainy"));
        }

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
