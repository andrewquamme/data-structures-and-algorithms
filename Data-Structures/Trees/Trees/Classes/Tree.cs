using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class Tree
    {
        public Node Root { get; set; }

        public Tree()
        {
            Root = null;
        }

        public Tree(Node root)
        {
            Root = root;
        }


    }
}
