using LinkedList.Classes;
using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LList list = new LList();
            list.Print();
            Console.WriteLine();

            list.Insert(2);
            list.Print();
            Console.WriteLine();

            list.Insert(14);
            list.Insert(123);
            list.Print();
            Console.WriteLine();

            list.InsertBefore(25, 14);
            list.Print();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
