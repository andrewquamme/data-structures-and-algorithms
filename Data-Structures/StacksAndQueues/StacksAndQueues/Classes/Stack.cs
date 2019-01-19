using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack
    {
        // Top Reference so we know where the top is
        public Node Top { get; set; }


        public Stack()
        {
            Top = null;
        }


        public Stack(Node node)
        {
            Top = node;
        }


        public void Push(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }


        public Node Pop()
        {
            // create a temp
            Node temp = Top;
            //set top to the next node in the stack
            Top = Top.Next;
            // clear the reference of next on the temp
            temp.Next = null;
            // return the node
            return temp;
        }


        public Node Peek()
        {
            // Show us the top node of a stack
            return Top;
        }
    }
}