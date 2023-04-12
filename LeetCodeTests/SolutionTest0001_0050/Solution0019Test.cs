﻿using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050
{
    [TestFixture]
    [Category("SolutionTest0001_0050")]
    public class Solution0019Test
    {
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 1, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 1, 2, 3, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, new int[] { 1, 2, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, new int[] { 1, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5, new int[] { 2, 3, 4, 5 })]
        [TestCase(new int[] { 1 }, 1, new int[] { })]
        [TestCase(new int[] { 1, 2 }, 1, new int[] { 1 })]
        public void RemoveNthFromEndTest(int[] input, int n, int[] expected)
        {
            var solution = new Solution0019();

            var list = Utility.BuildListNode(input);
            var actual = solution.RemoveNthFromEnd(list, n);

            var expectedListNode = Utility.BuildListNode(expected);
            Assert.That(Utility.CheckLinkedList(actual, expectedListNode), Is.EqualTo(true));
        }
    }
}