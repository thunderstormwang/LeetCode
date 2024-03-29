﻿using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0086Test
    {
        [TestCase(new int[] { 1, 4, 3, 2, 5, 2 }, 3, new int[] { 1, 2, 2, 4, 3, 5 })] 
        [TestCase(new int[] { 2, 1 }, 2, new int[] { 1, 2, })]
        public void PartitionTest(int[] input, int x, int[] expected)
        {
            var solution = new Solution0086();

            var list = Utility.BuildListNode(input);
            var actual = solution.Partition(list, x);

            var expectedListNode = Utility.BuildListNode(expected);
            Utility.CheckLinkedList(actual, expectedListNode).Should().BeTrue();
        }
    }
}