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
            var head = new ListNode(0);
            var start = head;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    start.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    start.next = list2;
                    list2 = list2.next;
                }

                start = start.next;
            }

            if (list1 != null)
            {
                start.next = list1;
            }

            if (list2 != null)
            {
                start.next = list2;
            }

            return head.next;
        }

        public static string PrintNodes(ListNode list)
        {
            StringBuilder sb = new StringBuilder();
            while (list != null)
            {
                sb.Append(list.val).Append(",");
                list = list.next;
            }

            return sb.ToString().TrimEnd(',');
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
