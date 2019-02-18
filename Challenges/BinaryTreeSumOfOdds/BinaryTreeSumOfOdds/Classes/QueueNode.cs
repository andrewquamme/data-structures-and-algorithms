using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeSumOfOdds.Classes
{
    public class QueueNode
    {
        public Node Value { get; set; }
        public QueueNode Next { get; set; }

        public QueueNode(Node root)
        {
            Value = root;
        }
    }
}
