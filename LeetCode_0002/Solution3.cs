using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_0002
{
    public class Solution3
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return AddTwoListWithCarry(l1, l2, 0);
        }

        private ListNode AddTwoListWithCarry(ListNode l1, ListNode l2, int carry)
        {
            if (l1 == null && l2 == null && carry == 0)
            {
                return null;
            }
            int sum = carry;
            if (l1 != null)
            {
                sum += l1.val;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                sum += l2.val;
                l2 = l2.next;
            }
            ListNode head = new ListNode(sum % 10);
            head.next = AddTwoListWithCarry(l1, l2, sum / 10);
            return head;
        }
    }
}
