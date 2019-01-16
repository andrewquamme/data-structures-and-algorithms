using System;
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

        /// <summary>
        /// Finds the k-th from the end value of a linked list
        /// Throws exception if list is null
        /// Throws exception if k is greater than list length
        /// </summary>
        /// <param name="list">linked list</param>
        /// <param name="k">position from end of linked list</param>
        /// <returns>value at k from end</returns>
        public static int KthFromEnd(LList list, int k)
        {
            int counter = 0;
            list.Current = list.Head;
            try
            {
                // Find length of linked list
                while (list.Current != null)
                {
                    counter++;
                    list.Current = list.Current.Next;
                }

                // Return -1 if k is longer than linked list
                if (k >= counter) throw new Exception();

                list.Current = list.Head;
                for (int i = 0; i < counter - k - 1; i++)
                {
                    list.Current = list.Current.Next;
                }
                return list.Current.Value;
            }
            catch (Exception)
            {
                Console.WriteLine("k is out of bounds of the linked list");
                throw;
            }
            

            
        }
    }
}
