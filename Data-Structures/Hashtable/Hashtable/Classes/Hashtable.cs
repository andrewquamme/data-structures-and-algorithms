
using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable.Classes
{
    public class Hashtable
    {
        public static Node[] HT { get; set; }

        public Hashtable(int buckets)
        {
            HT = new Node[buckets];
        }

        public static int Hash(string key)
        {
            int index = 0;

            for (int i = 0; i<key.Length; i++)
            {
                index += Convert.ToInt32(key[i]);
            }

            index = (index * 599) / HT.Length;
            return index;
        }

        public void Add()
        {

        }

        public void Get()
        {

        }

        public void Contains()
        {

        }
    }
}
