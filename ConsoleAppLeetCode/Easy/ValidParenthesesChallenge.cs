using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLeetCode.Easy
{
    public static class ValidParenthesesChallenge
    {
        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    stack.Push(s[i]);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    var key = stack.Pop();

                    if (s[i] == ')') //ASCII TABLE SEPARATION
                    {
                        if (key != s[i] - 1)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (key != s[i] - 2)
                        {
                            return false;
                        }
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
