using System;
using System.Collections.Generic;
using System.Text;

namespace TreeIntersection.Classes
{
    public class HashNode
    {
        public int Key { get; set; }
        public int Value { get; set; }
        public HashNode Next { get; set; }

        /// <summary>
        /// Creates a Node with Key and Value
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="value">Value</param>
        public HashNode(int key, int value)
        {
            Key = key;
            Value = value;
        }
    }
}