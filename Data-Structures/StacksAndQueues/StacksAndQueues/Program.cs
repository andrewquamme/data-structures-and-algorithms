using System;
using StacksAndQueues.Classes;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Console.WriteLine(stack.Top.Value);
        }
    }
}
