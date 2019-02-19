
using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable.Classes
{
    public class Hashtable
    {
        public Node[] HT { get; set; }

        public Hashtable(int buckets)
        {
            HT = new Node[buckets];
        }

        public int Hash(string key)
        {
            int index = 0;
            for (int i = 0; i<key.Length; i++)
            {
                index += Convert.ToInt32(key[i]);
            }
            index = (index * 599) / HT.Length;
            return index;
        }

        /// <summary>
        /// Adds Key/Value to Hash Table
        /// </summary>
        /// <param name="key">Key to add</param>
        /// <param name="value">Value to add</param>
        public void Add(string key, string value)
        {
            if (Contains(key))
            {
                HT[Hash(key)].Next = new Node(key, value);
            }
            else
            {
                HT[Hash(key)] = new Node(key, value);
            }
        }

        /// <summary>
        /// Takes a key and return value from Hash Table.
        /// Returns null if not found.
        /// </summary>
        /// <param name="key">Key to find</param>
        /// <returns>Value</returns>
        public string Get(string key)
        {
            if(Contains(key)) return HT[Hash(key)].Value;
            return null;
        }

        /// <summary>
        /// Checks if key is in Hash Table
        /// </summary>
        /// <param name="key">Key to find</param>
        /// <returns>True/False</returns>
        public bool Contains(string key)
        {
            if (HT[Hash(key)] != null) return true;
            return false;
        }
    }
}
