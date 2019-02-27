using HashTable.Classes;
using System;

namespace RepeatedWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str = "It was a queer sultry summer the summer they electrocuted the Rosenbergs and I didn’t know what I was doing in New York";
            Console.WriteLine(RepeatedWord(str));
        }

        /// <summary>
        /// Takes a long string and returns the first repeated word
        /// Returns "No repeated words" if none found
        /// </summary>
        /// <param name="book">long string</param>
        /// <returns>first repeated word</returns>
        public static string RepeatedWord(string book)
        {
            if (book == null) return "String is null";

            string[] words = book.Split(' ');
            Hashtable HT = new Hashtable(1024);
            foreach (string word in words)
            {
                if (HT.Contains(word))
                {
                    return word;
                }
                HT.Add(word, word);
            }
            return "No repeated words";
        }
    }
}
