
using System;
using System.Collections.Generic;
using System.Text;

namespace TreeIntersection.Classes
{
    public class Hashtable
    {
        public HashNode[] HT { get; set; }

        /// <summary>
        /// Creates Hashtable array with n buckets
        /// </summary>
        /// <param name="buckets">Num of buckets in Hashtable</param>
        public Hashtable(int buckets)
        {
            HT = new HashNode[buckets];
        }

        /// <summary>
        /// Hashes a key and returns an integer
        /// </summary>
        /// <param name="key">Key to hash</param>
        /// <returns>Integer</returns>
        public int Hash(int key)
        {
            int index = key;
            //for (int i = 0; i < key.Length; i++)
            //{
            //    index += Convert.ToInt32(key[i]);
            //}
            index = (index * 599) / HT.Length;
            return index;
        }

        /// <summary>
        /// Adds Key/Value to Hash Table
        /// </summary>
        /// <param name="key">Key to add</param>
        /// <param name="value">Value to add</param>
        public void Add(int key, int value)
        {
            if (HT[Hash(key)] != null)
            {
                HashNode tempNode = HT[Hash(key)];
                HT[Hash(key)] = new HashNode(key, value);
                HT[Hash(key)].Next = tempNode;
            }
            else
            {
                HT[Hash(key)] = new HashNode(key, value);
            }
        }

        /// <summary>
        /// Takes a key and return value from Hash Table.
        /// Returns null if not found.
        /// </summary>
        /// <param name="key">Key to find</param>
        /// <returns>Value</returns>
        public int? Get(int key)
        {
            if (Contains(key))
            {
                if (HT[Hash(key)].Key == key) return HT[Hash(key)].Value;
                HashNode tempNode = HT[Hash(key)];
                while (tempNode.Next != null)
                {
                    tempNode = tempNode.Next;
                    if (tempNode.Key == key) return tempNode.Value;
                }
            }
            return null;
        }

        /// <summary>
        /// Checks if key is in Hash Table
        /// </summary>
        /// <param name="key">Key to find</param>
        /// <returns>True/False</returns>
        public bool Contains(int key)
        {
            if (HT[Hash(key)] == null)
            {
                return false;
            }
            else
            {
                if (HT[Hash(key)].Key == key) return true;
                HashNode tempNode = HT[Hash(key)];
                while (tempNode.Next != null)
                {
                    tempNode = tempNode.Next;
                    if (tempNode.Key == key) return true;
                }
            }
            return false;
        }
    }
}