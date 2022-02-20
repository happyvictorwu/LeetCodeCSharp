using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_0002
{
    public class Solution2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(-1);
            ListNode tail = dummy;
            int carry = 0;
            while (l1 != null && l2 != null)
            {
                int sum = carry;
                sum += l1.val;
                sum += l2.val;
                tail.next = new ListNode(sum % 10);
                tail = tail.next;
                carry = sum / 10;
                l1 = l1.next;
                l2 = l2.next;
            }
            while (l1 != null)
            {
                int sum = carry;
                sum += l1.val;
                tail.next = new ListNode(sum % 10);
                tail = tail.next;
                carry = sum / 10;
                l1 = l1.next;
            }
            while (l2 != null)
            {
                int sum = carry;
                sum += l2.val;
                tail.next = new ListNode(sum % 10);
                tail = tail.next;
                carry = sum / 10;
                l2 = l2.next;
            }
            if (carry == 1)
            {
                tail.next = new ListNode(carry);
            }
            return dummy.next;
        }
    }
}
