using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLeetCode.Medium
{
    public static class RevserseIntegerChallenge
    {
        public static int Reverse(int x)
        {
            bool isNegative = x < 0;

            if (isNegative)
            {
                x *= -1;
            }

            Stack<int> stack = new Stack<int>();

            while (x > 0)
            {
                stack.Push(x % 10);
                x = x / 10;
            }

            int result = 0;
            for (int i = 0, j = stack.Count; i < j; i++)
            {
                try
                {
                    result = checked(result + (stack.Pop() * (int)Math.Pow(10, i)));
                }
                catch (OverflowException)
                {
                    return 0;
                }

            }

            return isNegative ? result * -1 : result;
        }
    }
}
