using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLeetCode
{
    internal static class RomanToIntChallenge
    {
        public static int RomanToInt(string s)
        {
            Dictionary<char, int> converter = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10},
                { 'L', 50},
                { 'C', 100},
                { 'D', 500},
                { 'M', 1000}
            };

            int result = 0;
            int previous =0;
            foreach (char c in s)
            {
                int num = converter[c];

                if (num > previous)
                {
                    result += num - 2 * previous;
                }
                else
                {
                    result += num;
                }
                previous = num;
            }

            return result;
        }
    }
}
