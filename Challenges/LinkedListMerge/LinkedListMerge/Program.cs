using System;

using LinkedList.Classes;

namespace LinkedListMerge
{
    public class Program
    {
        static void Main(string[] args)
        {
            LList list1 = new LList();
            list1.Append(1);
            list1.Append(3);
            list1.Append(2);
            list1.Print();
            Console.WriteLine();

            LList list2 = new LList();
            list2.Append(5);
            list2.Append(9);
            list2.Append(2);
            list2.Print();
            Console.WriteLine();

            LList mergedList = MergeLists(list1, list2);
            mergedList.Print();
            Console.WriteLine();
        }

        /// <summary>
        /// Take two linked lists as input and returns a
        /// merged linked list
        /// </summary>
        /// <param name="list1">Linked List 1</param>
        /// <param name="list2">Linked List 2</param>
        /// <returns>Merged List</returns>
        public static LList MergeLists(LList list1, LList list2)
        {
            list1.Current = list1.Head;
            list2.Current = list2.Head;

            while (list1.Current != null)
            {
                Node tempNode = list1.Current.Next;
                list1.Current.Next = list2.Current;
                list2.Current = tempNode;
                list1.Current = list1.Current.Next;
            }
            return list1;
        }
    }
}
