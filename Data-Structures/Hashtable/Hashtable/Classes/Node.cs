﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable.Classes
{
    public class Node
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public Node Next { get; set; }

        /// <summary>
        /// Creates a Node with Key and Value
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="value">Value</param>
        public Node(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
