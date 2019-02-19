using HashTable.Classes;
using System;
using Xunit;

namespace HashtableTDD
{
    public class HashtableTDD
    {
        public class HashTests
        {
            [Fact]
            public void TestHash()
            {
                Hashtable testHT = new Hashtable(1024);
                Assert.Equal(377, testHT.Hash("brainy"));
            }
        }

        public class AddTests
        {
            [Fact]
            public void TestAdd()
            {
                Hashtable testHT = new Hashtable(1024);
                testHT.Add("brainy", "test");
                int index = testHT.Hash("brainy");
                Assert.Equal("test", testHT.HT[index].Value);
            }

            [Fact]
            public void TestAddCollision()
            {
                Hashtable testHT = new Hashtable(1024);
                testHT.Add("brainy", "test1");
                testHT.Add("binary", "test2");
                int index = testHT.Hash("brainy");
                Assert.Equal("test2", testHT.HT[index].Value);
            }

            [Fact]
            public void TestAddMultiCollisions()
            {
                Hashtable testHT = new Hashtable(1024);
                testHT.Add("brainy", "test1");
                testHT.Add("binary", "test2");
                testHT.Add("nibray", "test3");
                int index = testHT.Hash("brainy");
                Assert.Equal("test1", testHT.HT[index].Next.Next.Value);
            }
        }
        
        public class GetTests
        {
            [Fact]
            public void TestGet()
            {
                Hashtable testHT = new Hashtable(1024);
                testHT.Add("brainy", "test");
                Assert.Equal("test", testHT.Get("brainy"));
            }
        }
        
        public class ContainsTests
        {
            [Fact]
            public void TestContains()
            {
                Hashtable testHT = new Hashtable(1024);
                testHT.Add("brainy", "test");
                Assert.True(testHT.Contains("brainy"));
            }

            [Fact]
            public void TestContainsWithCollision()
            {
                Hashtable testHT = new Hashtable(1024);
                testHT.Add("brainy", "test1");
                testHT.Add("binary", "test2");
                Assert.True(testHT.Contains("brainy"));
            }

            [Fact]
            public void TestContainsWithMultiCollision()
            {
                Hashtable testHT = new Hashtable(1024);
                testHT.Add("brainy", "test1");
                testHT.Add("binary", "test2");
                testHT.Add("nibray", "test3");
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
}
