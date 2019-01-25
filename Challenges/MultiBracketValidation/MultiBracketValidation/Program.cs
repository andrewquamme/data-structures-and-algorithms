using MultiBracketValidation.Classes;
using System;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            MultiBrackValidation("{}");
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
                    if (!CheckMatchingBrace(stack.Peek().Value, c))
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

        public static bool CheckMatchingBrace(char a, char b)
        {
            return a == '(' && b == ')' || a == '[' && b == ']' || a == '{' && b == '}';
        }
    }
}
