using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_0002
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(-1);
            ListNode tail = dummy;
            int carry = 0;
            while (l1 != null || l2 != null)
            {
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
                tail.next = new ListNode(sum % 10);
                tail = tail.next;
                carry = sum / 10;
            }
            if (carry == 1)
            {
                tail.next = new ListNode(1);
            }
            return dummy.next;
        }
    }
}
