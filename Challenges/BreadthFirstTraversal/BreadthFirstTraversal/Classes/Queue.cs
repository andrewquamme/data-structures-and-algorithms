using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirstTraversal.Classes
{
    public class Queue
    {
        public QueueNode Front { get; set; }
        public QueueNode Rear { get; set; }


        public Queue()
        {
            Front = null;
        }

        /// <summary>
        /// Create a new Node and add
        /// to the back of the queue
        /// </summary>
        /// <param name="value">value of new Node</param>
        public void Enqueue(Node node)
        {
            QueueNode temp = new QueueNode(node);
            if (Front == null)
            {
                Front = temp;
                Rear = temp;
            }
            else
            {
                Rear.Next = temp;
                Rear = temp;
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
            QueueNode temp = Front;
            // change our front reference to the next node
            Front = Front.Next;
            // clear our next reference for standalone
            temp.Next = null;

            //return the temp to the user
            return temp.Value;
        }

        /// <summary>
        /// Peek at the front node in the queue
        /// </summary>
        /// <returns>Front Node Value</returns>
        public QueueNode Peek()
        {
            return Front;
        }
    }
}
