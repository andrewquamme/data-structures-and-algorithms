using System;

namespace Sorts
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] testArr = { 4, 3, 1, 8, 5, 7, 2 };
            InsertionSort(testArr);
        }

        /// <summary>
        /// Performs Insertion Sort on an array of integers
        /// </summary>
        /// <param name="arr">Array of int to be sorted</param>
        public static void InsertionSort(int[] arr)
        {
            for(int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int temp = arr[i];

                while (j >= 0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = temp;
            }
        }
    }
}
