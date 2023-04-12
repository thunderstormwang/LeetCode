using FluentAssertions;
using LeetCode;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200
{
    [TestFixture]
    [Category("SolutionTest0101_0200")]
    public class Solution0160Test
    {
        [TestCase(new int[] { 4, 1 }, new int[] { 5, 6, 1 }, new int[] { 8, 4, 5 })]
        [TestCase(new int[] { 1, 9, 1 }, new int[] { 3 }, new int[] { 2, 4 })]
        [TestCase(new int[] { 2, 6, 4 }, new int[] { 1, 5 }, new int[] { })]
        [TestCase(new int[] { 2, 4, 6 }, new int[] { 1, 5 }, new int[] { 2, 4, 6 })]
        [TestCase(new int[] { }, new int[] { 1, 5 }, new int[] { })]
        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        public void GetIntersectionNodeTest_Version1(int[] arrayA, int[] arrayB, int[] intersections)
        {
            var intersection = GetLinkedList(intersections, null);
            var listA = GetLinkedList(arrayA, intersection);
            var listB = GetLinkedList(arrayB, intersection);

            var solution = new Solution0160();
            var actual = solution.GetIntersectionNode_Version1(listA, listB);

            actual.Should().Be(intersection);
        }
        
        [TestCase(new int[] { 4, 1 }, new int[] { 5, 6, 1 }, new int[] { 8, 4, 5 })]
        [TestCase(new int[] { 1, 9, 1 }, new int[] { 3 }, new int[] { 2, 4 })]
        [TestCase(new int[] { 2, 6, 4 }, new int[] { 1, 5 }, new int[] { })]
        [TestCase(new int[] { 2, 4, 6 }, new int[] { 1, 5 }, new int[] { 2, 4, 6 })]
        [TestCase(new int[] { }, new int[] { 1, 5 }, new int[] { })]
        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        public void GetIntersectionNodeTest_Version2(int[] arrayA, int[] arrayB, int[] intersections)
        {
            var intersection = GetLinkedList(intersections, null);
            var listA = GetLinkedList(arrayA, intersection);
            var listB = GetLinkedList(arrayB, intersection);

            var solution = new Solution0160();
            var actual = solution.GetIntersectionNode_Version2(listA, listB);

            actual.Should().Be(intersection);
        }

        private ListNode GetLinkedList(int[] input, in ListNode tail)
        {
            var result = tail;

            for (var i = input.Length - 1; i >= 0; i--)
            {
                var temp = result;
                result = new ListNode(input[i]);
                result.next = temp;
            }

            return result;
        }
    }
}