using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLeetCode.Medium
{
    public static class StringToIntegerMyAtoiChallenge
    {
        public static int MyAtoi(string s)
        {
            int i = 0;
            bool isNegative = false;

            while (i < s.Length && s[i] == ' ')
            {
                i++;
            }

            if (i < s.Length && s[i] == '-')
            {
                isNegative = true;
                i++;
            }
            else if (i < s.Length && s[i] == '+')
            {
                i++;
            }

            int result = 0;
            while(i < s.Length)
            {
                if (s[i] >= 48 && s[i] <= 57)
                {
                    try
                    {
                        result = checked(result + (s[i] - 48));
                        if (i + 1 < s.Length && (s[i + 1] >= 48 && s[i + 1] <= 57)) 
                        {
                            result = checked(result * 10);
                        }
                        
                    }
                    catch(OverflowException)
                    { 
                        if(isNegative)
                        {
                            result = Int32.MinValue; 
                            break; 
                        }
                        
                        result = Int32.MaxValue; 
                        break;

                    }
                    
                }   
                else
                {
                    break;
                }
                i++;
            }

            return isNegative ? result*-1: result;
        }
    }
}
