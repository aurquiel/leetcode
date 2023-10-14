using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLeetCode
{
    public static class PalindromeNumberChallenge
    {
        public static bool IsPalindrome(int x)
        {
            int reverted = 0, save = x;
            while (save > 0)
            {
                reverted = reverted * 10 + save % 10;
                save = save / 10;
            }

            return reverted == x;
        }
    }
}
