using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLeetCode.Easy
{
    public static class RemoveDuplicatesFromSortedArrayChallenge
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int tmp = nums[0];
            int cnt = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > tmp)
                {
                    tmp = nums[i];
                    nums[cnt] = tmp;
                    cnt++;
                }
            }

            return cnt;
        }
    }
}
