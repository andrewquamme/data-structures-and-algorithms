using System;

namespace ArrayShift
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4 };
            ArrayShift(array, 5);
        }

        public static int[] ArrayShift(int[] array, int num)
        {
            int arrayLength = array.Length;
            int arrayMidpoint = arrayLength / 2;

            if (arrayLength % 2 != 0)
            {
                //Add 1 to midpoint if array has an odd number of integers
                arrayMidpoint += 1;
            }
            int[] newArray = new int[ arrayLength + 1 ];

            for(int i = 0; i < arrayMidpoint; i++)
            {
                newArray[i] = array[i];
            }

            newArray[arrayMidpoint] = num;

            for(int i = arrayMidpoint + 1; i < newArray.Length; i++)
            {
                newArray[i] = array[i - 1];
            }

            return newArray;
        }
    }
}
