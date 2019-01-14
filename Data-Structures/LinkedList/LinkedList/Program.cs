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
            list.Insert(2);
            list.Print();
            list.Insert(123);
            list.Print();
            Console.ReadLine();
        }
    }
}
