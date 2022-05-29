using System;
using System.Text;

namespace LeetCode.Solution0501_9999
{
    public class Solution0707
    {
        public class MyLinkedList_Version1
        {
            private readonly ListNode dummyNode;

            public MyLinkedList_Version1()
            {
                dummyNode = new ListNode(0);
            }

            public int Get(int index)
            {
                var count = 0;
                var node = dummyNode.next;
                while (count < index && node != null)
                {
                    node = node.next;
                    count++;
                }

                return node?.val ?? -1;
            }

            public void AddAtHead(int val)
            {
                var temp = new ListNode(val);
                temp.next = dummyNode.next;
                dummyNode.next = temp;
            }

            public void AddAtTail(int val)
            {
                var node = dummyNode;
                while (node.next != null)
                {
                    node = node.next;
                }

                var temp = new ListNode(val);
                node.next = temp;
            }

            public void AddAtIndex(int index, int val)
            {
                var count = -1;
                var pre = dummyNode;
                while (count < index - 1 && pre.next != null)
                {
                    pre = pre.next;
                    count++;
                }

                if (pre.next == null && count != index - 1)
                {
                    return;
                }

                var temp = new ListNode(val);
                temp.next = pre.next;
                pre.next = temp;
            }

            public void DeleteAtIndex(int index)
            {
                var count = -1;
                var pre = dummyNode;
                while (count < index - 1 && pre.next != null)
                {
                    pre = pre.next;
                    count++;
                }

                if (pre.next == null && count != index - 1)
                {
                    return;
                }

                pre.next = pre.next?.next;
            }

            private void Print()
            {
                var current = dummyNode.next;
                var sb = new StringBuilder();
                var arrow = "->";
                while (current != null)
                {
                    sb.Append(current.val);
                    if (current.next != null)
                    {
                        sb.Append(arrow);
                    }

                    current = current.next;
                }

                Console.WriteLine(sb.ToString());
            }
        }

        public class MyLinkedList_Version2
        {
            private readonly ListNode dummyNode;
            private int size;

            public MyLinkedList_Version2()
            {
                dummyNode = new ListNode(0);
                size = 0;
            }

            public int Get(int index)
            {
                if (size <= index)
                {
                    return -1;
                }

                var count = 0;
                var node = dummyNode.next;
                while (count < index)
                {
                    node = node.next;
                    count++;
                }

                return node.val;
            }

            public void AddAtHead(int val)
            {
                var temp = new ListNode(val);
                temp.next = dummyNode.next;
                dummyNode.next = temp;
                size++;
            }

            public void AddAtTail(int val)
            {
                var node = dummyNode;
                while (node.next != null)
                {
                    node = node.next;
                }

                var temp = new ListNode(val);
                node.next = temp;
                size++;
            }

            public void AddAtIndex(int index, int val)
            {
                if (size < index)
                {
                    return;
                }

                var count = -1;
                var pre = dummyNode;
                while (count < index - 1)
                {
                    pre = pre.next;
                    count++;
                }

                var temp = new ListNode(val);
                temp.next = pre.next;
                pre.next = temp;
                size++;
            }

            public void DeleteAtIndex(int index)
            {
                if (size <= index)
                {
                    return;
                }

                var count = -1;
                var pre = dummyNode;
                while (count < index - 1)
                {
                    pre = pre.next;
                    count++;
                }

                pre.next = pre.next?.next;
                size--;
            }

            private void Print()
            {
                var current = dummyNode.next;
                var sb = new StringBuilder();
                var arrow = "->";
                while (current != null)
                {
                    sb.Append(current.val);
                    if (current.next != null)
                    {
                        sb.Append(arrow);
                    }

                    current = current.next;
                }

                Console.WriteLine(sb.ToString());
            }
        }
    }
}