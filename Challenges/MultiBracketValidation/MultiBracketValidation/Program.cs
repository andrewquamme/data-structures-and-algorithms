using Multi_Bracket_Validation.Classes;
using System;

namespace Multi_Bracket_Validation
{
    public class Program
    {
        static void Main(string[] args)
        {
            MultiBracketValidation("{}");
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
