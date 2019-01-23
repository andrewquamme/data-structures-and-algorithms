using StacksAndQueues.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class PsuedoQueue
    {
        Stack stackOne = new Stack();
        Stack stackTwo = new Stack();

        
        /// <summary>
        /// Adds node into PsuedoQueue
        /// </summary>
        /// <param name="value">value to add to queue</param>
        public void Enqueue(int value)
        {
            if (stackTwo.Peek() != null)
            {
                while (stackTwo.Peek() != null)
                {
                    stackOne.Push(stackTwo.Pop().Value);
                }
            }
            stackOne.Push(value);
        }

        /// <summary>
        /// Removes node from PsuedoQueue
        /// </summary>
        /// <returns>Node from front of queue</returns>
        public Node Dequeue()
        {
            if(stackTwo.Peek() == null)
            {
                while (stackOne.Peek() != null)
                {
                    stackTwo.Push(stackOne.Pop().Value);
                }
            }
            
            return stackTwo.Pop();
        }
    }
}
