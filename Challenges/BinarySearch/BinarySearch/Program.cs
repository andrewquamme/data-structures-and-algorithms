using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine(BinarySearch(array, 3));
        }

        public static int BinarySearch(int[] array, int num)
        {
            int min = 0;
            int max = array.Length - 1;

            while(min <= max)
            {
                int mid = (min + max) / 2;
                if(num == array[mid])
                {
                    return mid;
                }
                else if(num < array[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
    }
}
