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

        public static string RepeatedWord(string book)
        {
            string[] words = book.Split(' ');
            for (int i = 0; i < words.Length - 1; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i] == words[j]) return words[i];
                }
            }
            return "No repeated words";
        }
    }
}
