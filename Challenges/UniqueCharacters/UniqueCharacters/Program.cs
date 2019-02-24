using HashTable.Classes;
using System;

namespace UniqueCharacters
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UniqueCharacters("BROWN dog"));
        }

        /// <summary>
        /// Checks a string to determine if all characters are unique
        /// </summary>
        /// <param name="str">String Input</param>
        /// <returns>True/False</returns>
        public static bool UniqueCharacters(string str)
        {
            Hashtable HT = new Hashtable(1024);

            for (int i = 0; i < str.Length; i++)
            {
                string character = Convert.ToString(str[i]).ToUpper();

                if (HT.Contains(character)) return false;

                HT.Add(character, character);
            }

            return true;
        }
    }
}
