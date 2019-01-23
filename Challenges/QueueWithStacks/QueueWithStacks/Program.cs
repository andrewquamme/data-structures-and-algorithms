using QueueWithStacks.Classes;
using System;

namespace QueueWithStacks
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            QueueWithStacks();
        }

        public static void QueueWithStacks()
        {
            PsuedoQueue queue = new PsuedoQueue();
            queue.Enqueue(5);
            queue.Enqueue(4);
            Console.WriteLine(queue.Dequeue().Value);
            Console.WriteLine(queue.Dequeue().Value);

        }
    }
}
