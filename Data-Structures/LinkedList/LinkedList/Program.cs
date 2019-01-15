using LinkedList.Classes;
using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LList list = new LList();
            list.Append(1);
            list.Append(3);
            list.Append(2);
            list.InsertAfter(2, 5);
            list.Print();
            Console.ReadLine();
        }
    }
}
