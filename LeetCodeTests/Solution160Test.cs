using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture()]
    public class Solution160Test
    {
        [TestCase(new int[] {4, 1}, new int[] {5, 6, 1}, new int[] {8, 4, 5})]
        [TestCase(new int[] {1, 9, 1}, new int[] {3}, new int[] {2, 4})]
        [TestCase(new int[] {2, 6, 4}, new int[] {1, 5}, new int[] { })]
        public void GetIntersectionNodeTest(int[] arrayA, int[] arrayB, int[] intersections)
        {
            var intersection = GetLinkedList(intersections, null);
            var listA = GetLinkedList(arrayA, intersection);
            var listB = GetLinkedList(arrayB, intersection);

            var solution160 = new Solution160();
            var actual = solution160.GetIntersectionNode(listA, listB);

            actual.Should().Be(intersection);
        }

        private ListNode GetLinkedList(int[] input, in ListNode tail)
        {
            ListNode result = tail;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                var temp = result;
                result = new ListNode(input[i]);
                result.next = temp;
            }

            return result;
        }
    }
}