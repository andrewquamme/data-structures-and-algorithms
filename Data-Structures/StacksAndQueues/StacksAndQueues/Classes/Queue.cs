using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }


        public Queue()
        {
            Front = null;
        }

        /// <summary>
        /// Create a new Node and add
        /// to the back of the queue
        /// </summary>
        /// <param name="value">value of new Node</param>
        public void Enqueue(int value)
        {
            Node node = new Node(value);
            
            if (Front == null)
            {
                Front = node;
                Rear = node;
            }
            else
            {
                Rear.Next = node;
                Rear = node;
            }
        }

        /// <summary>
        /// Dequeue front node and return
        /// value to the user
        /// </summary>
        /// <returns>Front Node Value</returns>
        public Node Dequeue()
        {
            // create a temp to keep track of the original front
            Node temp = Front;
            // change our front reference to the next node
            Front = Front.Next;
            // clear our next reference for standalone
            temp.Next = null;

            //return the temp to the user
            return temp;
        }

        /// <summary>
        /// Peek at the front node in the queue
        /// </summary>
        /// <returns>Front Node Value</returns>
        public Node Peek()
        {
            return Front;
        }
    }
}