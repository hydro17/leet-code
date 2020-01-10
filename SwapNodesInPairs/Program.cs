using System;

namespace SwapNodesInPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = ListGenerator(5);

            PrintList(head);

            new Solution().SwapPairs(head);

            PrintList(head);
        }

        private static void PrintList(ListNode node)
        {
            while (node != null)
            {
                Console.WriteLine(node.val);
                node = node.next;
            }
        }

        private static ListNode ListGenerator(int nodeCount)
        {
            ListNode head = null;

            if (nodeCount < 0) throw new ArgumentException("");

            for (int i = nodeCount; i > 0; i--)
            {
                AddNode(ref head, i);
            }

            return head;
        }

        private static void AddNode(ref ListNode head, int i)
        {
            ListNode nextNode = new ListNode(i);
            nextNode.next = head;
            head = nextNode;
        }
    }
}
