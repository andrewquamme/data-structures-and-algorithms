using MultiBracketValidation.Classes;
using System;

namespace MultiBracketValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool MultiBrackValidation(string input)
        {
            Stack stack = new Stack();

            foreach (char c in input)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }

                if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Peek().Value != c)
                    {
                        return false;
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
            }
            return true;
        }
    }
}
