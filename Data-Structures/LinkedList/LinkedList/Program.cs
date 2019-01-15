using LinkedList.Classes;
using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LList list = new LList();
            list.InsertAfter(2, 5);
            list.Print();
            Console.ReadLine();
        }
    }
}
