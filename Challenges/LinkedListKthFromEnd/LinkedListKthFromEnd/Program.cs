﻿using System;
using LinkedList.Classes;

namespace LinkedListKthFromEnd
{
    public class Program
    {
        static void Main(string[] args)
        {
            LList list = new LList();
            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            list.Print();
            Console.WriteLine();

            Console.WriteLine(KthFromEnd(list, 3));
            Console.WriteLine(KthFromEnd(list, 0));
            Console.WriteLine(KthFromEnd(list, 4));
        }

        public static int KthFromEnd(LList list, int k)
        {
            int counter = 0;
            list.Current = list.Head;

            // Return -1 if linked list is empty
            if (list.Current == null) return -1;

            // Find length of linked list
            while(list.Current != null)
            {
                counter++;
                list.Current = list.Current.Next;
            }

            // Return -1 if k is longer than linked list
            if (k >= counter) return -1;

            list.Current = list.Head;
            for (int i = 0; i < counter - k - 1; i++)
            {
                list.Current = list.Current.Next;
            }
            return list.Current.Value;
        }
    }
}
