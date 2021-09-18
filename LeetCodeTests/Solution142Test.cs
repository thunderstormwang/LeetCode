using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution142Test
    {
        private ListNode cycleStart;

        [TestCase(new int[] { 3, 2, 0, 4 },
            1)]
        [TestCase(new int[] { 1, 2 },
            0)]
        [TestCase(new int[] { 1 },
            -1)]
        [TestCase(new int[] { },
            -1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 },
            0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 },
            1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 },
            2)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 },
            3)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 },
            4)]
        public void DetectCycleTest(int[] array,
            int pos)
        {
            var list = GetLinkedList(array,
                pos);

            var solution142 = new Solution142();
            var actual = solution142.DetectCycle(list);

            if (actual == null)
            {
                Assert.IsTrue(actual == cycleStart);
            }
            else
            {
                actual.Should().Be(cycleStart);
            }
        }

        private ListNode GetLinkedList(int[] input,
            int pos)
        {
            ListNode result = null;
            ListNode tail = null;

            for (var i = input.Length - 1; i >= 0; i--)
            {
                var temp = result;
                result = new ListNode(input[i]);
                result.next = temp;

                if (tail == null)
                {
                    tail = result;
                }

                if (i == pos)
                {
                    tail.next = result;
                    cycleStart = result;
                }
            }

            return result;
        }
    }
}