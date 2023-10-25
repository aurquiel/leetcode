using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLeetCode.Easy
{
    public static class LongestCommonPrefixChallenge
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            string prefix = strs[0];
            string newPrefix = string.Empty;

            foreach (string s in strs)
            {
                newPrefix = string.Empty;
                for (int i = 0; i < s.Length; i++)
                {
                    if (i < prefix.Length && s[i] == prefix[i])
                    {
                        newPrefix += s[i];
                    }
                    else
                    {
                        break;
                    }
                }

                prefix = newPrefix;

                if (prefix == string.Empty)
                {
                    break;
                }
            }

            return prefix;
        }
    }
}
