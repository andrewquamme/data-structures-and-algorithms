using System;

namespace ArrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static int[] ArrayShift(int[] array, int num)
        {
            int arrayLength = array.Length;
            int arrayMidpoint = arrayLength / 2;
            int[] newArray = { arrayLength + 1 };

            for(int i = 0; i < arrayMidpoint; i++)
            {
                newArray[i] = array[i];
            }

            newArray[arrayMidpoint] = num;

            for(int i = arrayMidpoint + 1; i < arrayLength; i++)
            {
                newArray[i] = array[i - 1];
            }

            return newArray;
        }
    }
}
