using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLeetCode.Easy
{
    public static class MergeTwoSortedListsChallenge
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode result;
            
            do
            {
                var num = list1.val;
                if(num <= list2.val)
                {
                    
                }
                else
                {
                    list2.next
                }

            }while (list1.next != null);
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
