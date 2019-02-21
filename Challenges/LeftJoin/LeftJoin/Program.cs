using LeftJoin.Classes;
using System;
using System.Collections.Generic;

namespace LeftJoin
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hashtable synHT = new Hashtable(50);
            synHT.Add("fond", "enamored");
            synHT.Add("outfit", "garb");

            Hashtable antHT = new Hashtable(50);
            antHT.Add("fond", "averse");

            IList<string> results = LeftJoin(synHT, antHT);
        }

        public static IList<string> LeftJoin(Hashtable hash1, Hashtable hash2)
        {
            List<string> results = new List<string>();

            foreach(Node node in hash1.HT)
            {
                if (node != null)
                {
                    string values = $"Word: {node.Key}, Synonym: {node.Value}";

                    if (hash2.Contains(node.Key))
                    {
                        values += $", Antonym: {hash2.Get(node.Key)}";
                    }

                    results.Add(values);
                }
            }

            return results;
        }
    }
}
