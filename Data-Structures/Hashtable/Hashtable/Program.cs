using System;
using HashTable.Classes;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable testHT = new Hashtable(1024);
            Console.WriteLine(Hashtable.Hash("ferret"));
        }
    }
}
