
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

        public void Add(string key, string value)
        {
            HT[Hash(key)] = new Node(key, value);
        }

        public string Get(string key)
        {
            return HT[Hash(key)].Value;
        }

        public void Contains()
        {

        }
    }
}
