using MultiBracketValidation.Classes;
using System;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MultiBrackValidation("{}"));
        }

        /// <summary>
        /// Takes a string as input and verifies that any brackets
        /// in the string are balanced
        /// </summary>
        /// <param name="input">string containing brackets</param>
        /// <returns>true/false</returns>
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
                    if (!CheckMatchingBrackets(stack.Peek().Value, c))
                    {
                        return false;
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
            }
            if (stack.Peek() != null) return false;

            return true;
        }

        /// <summary>
        /// Takes in an open and close bracket and checks if
        /// they are a "match" 
        /// </summary>
        /// <param name="a">open bracket</param>
        /// <param name="b">close bracket</param>
        /// <returns></returns>
        public static bool CheckMatchingBrackets(char a, char b)
        {
            return a == '(' && b == ')' || a == '[' && b == ']' || a == '{' && b == '}';
        }
    }
}
