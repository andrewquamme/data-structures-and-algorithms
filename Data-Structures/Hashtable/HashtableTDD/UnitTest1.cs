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

        [Fact]
        public void TestGet()
        {
            Hashtable testHT = new Hashtable(1024);
            testHT.Add("brainy", "test");
            Assert.Equal("test", testHT.Get("brainy"));
        }

        [Fact]
        public void TestContains()
        {
            Hashtable testHT = new Hashtable(1024);
            testHT.Add("brainy", "test");
            Assert.True(testHT.Contains("brainy"));
        }

        [Fact]
        public void TestDoesNotContain()
        {
            Hashtable testHT = new Hashtable(1024);
            testHT.Add("brainy", "test");
            Assert.False(testHT.Contains("ferret"));
        }
    }
}
