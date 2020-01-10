using System;
using System.Collections.Generic;
using System.Text;

namespace SwapNodesInPairs
{
    public class Solution
    {
        public ListNode SwapPairs(ListNode head)
        {
            ListNode beforeFirstNode = null;
            ListNode firstNode = head;

            while (firstNode != null && firstNode.next != null)
            {
                SwapNodes(ref head, beforeFirstNode, firstNode);
                beforeFirstNode = firstNode;
                firstNode = firstNode.next;
            }

            return head;
        }

        private void SwapNodes(ref ListNode head, ListNode beforeFirstNode, ListNode firstNode)
        {
            ListNode secondNode = firstNode.next;

            if (beforeFirstNode != null)
            {
                beforeFirstNode.next = secondNode;
            }
            else
            {
                head = secondNode;
            }

            firstNode.next = secondNode.next;
            secondNode.next = firstNode;
        }
    }
}
