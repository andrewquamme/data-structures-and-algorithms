using LeftJoin;
using LeftJoin.Classes;
using System;
using System.Collections.Generic;
using Xunit;

namespace LeftJoinTDD
{
    public class UnitTest1
    {
        [Fact]
        public void TestMatch()
        {
            Hashtable synHT = new Hashtable(1024);
            synHT.Add("fond", "enamored");

            Hashtable antHT = new Hashtable(1024);
            antHT.Add("fond", "averse");

            IList<string> results = Program.LeftJoin(synHT, antHT);

            IList<string> expected = new List<string>();
            expected.Add("Word: fond, Synonym: enamored, Antonym: averse");

            Assert.Equal(expected, results);
        }

        [Fact]
        public void TestNoMatch()
        {
            Hashtable synHT = new Hashtable(1024);
            synHT.Add("outfit", "garb");

            Hashtable antHT = new Hashtable(1024);

            IList<string> results = Program.LeftJoin(synHT, antHT);

            IList<string> expected = new List<string>();
            expected.Add("Word: outfit, Synonym: garb, Antonym: NONE");

            Assert.Equal(expected, results);
        }

        [Fact]
        public void TestMixedMatches()
        {
            Hashtable synHT = new Hashtable(1024);
            synHT.Add("fond", "enamored");
            synHT.Add("outfit", "garb");

            Hashtable antHT = new Hashtable(1024);
            antHT.Add("fond", "averse");

            IList<string> results = Program.LeftJoin(synHT, antHT);

            IList<string> expected = new List<string>();
            expected.Add("Word: fond, Synonym: enamored, Antonym: averse");
            expected.Add("Word: outfit, Synonym: garb, Antonym: NONE");

            Assert.Equal(expected, results);
        }
    }
}
