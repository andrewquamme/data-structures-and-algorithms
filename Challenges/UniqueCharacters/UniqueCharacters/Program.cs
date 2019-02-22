using HashTable.Classes;
using System;

namespace UniqueCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UniqueCharacters("brown dog"));
        }

        public static bool UniqueCharacters(string str)
        {
            Hashtable HT = new Hashtable(1024);
            for (int i = 0; i < str.Length; i++)
            {
                string character = Convert.ToString(str[i]);

                if (HT.Contains(character)) return false;

                HT.Add(character, character);
            }

            return true;
        }
    }
}
