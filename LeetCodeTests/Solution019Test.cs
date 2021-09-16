﻿using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution019Test
    {
        [TestCase(new int[] { 1, 2, 3, 4, 5 },
            1,
            new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 },
            2,
            new int[] { 1, 2, 3, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 },
            3,
            new int[] { 1, 2, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 },
            4,
            new int[] { 1, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 },
            5,
            new int[] { 2, 3, 4, 5 })]
        [TestCase(new int[] { 1 },
            1,
            new int[] { })]
        [TestCase(new int[] { 1, 2 },
            1,
            new int[] { 1 })]
        public void RemoveNthFromEndTest(int[] input,
            int n,
            int[] expected)
        {
            var solution019 = new Solution019();

            var list = Utility.BuildListNode(input);
            var actual = solution019.RemoveNthFromEnd(list,
                n);

            var expectedListNode = Utility.BuildListNode(expected);
            Assert.AreEqual(Utility.CheckListNode(actual,
                    expectedListNode),
                true);
        }
    }
}