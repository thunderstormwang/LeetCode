﻿using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution148Test
    {
        [TestCase(new int[] { 4, 2, 1, 3 },
            new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { -1, 5, 3, 4, 0 },
            new int[] { -1, 0, 3, 4, 5 })]
        [TestCase(new int[] { 3, 1, 1, 3 },
            new int[] { 1, 1, 3, 3 })]
        [TestCase(new int[] { 3, 3, 3, 1 },
            new int[] { 1, 3, 3, 3 })]
        public void InsertionSortList(int[] input,
            int[] expected)
        {
            var solution148 = new Solution148();

            var list = Utility.BuildListNode(input);
            var actual = solution148.SortList(list);

            var expectedListNode = Utility.BuildListNode(expected);
            Assert.AreEqual(Utility.CheckListNode(actual,
                    expectedListNode),
                true);
        }
    }
}