using LeftJoin.Classes;
using System;
using System.Collections.Generic;

namespace LeftJoin
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hashtable synHT = new Hashtable(1024);
            synHT.Add("fond", "enamored");
            synHT.Add("outfit", "garb");

            Hashtable antHT = new Hashtable(1024);
            antHT.Add("fond", "averse");

            IList<string> results = LeftJoin(synHT, antHT);
        }

        /// <summary>
        /// Performs a LEFT JOIN of a synonym and antonym hashtable
        /// </summary>
        /// <param name="hash1">Synonym hashtable</param>
        /// <param name="hash2">Antonym hashtable</param>
        /// <returns>List of words with their synonyms and antonyms</returns>
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
                    else
                    {
                        values += $", Antonym: NONE";
                    }

                    results.Add(values);
                }
            }

            return results;
        }
    }
}
