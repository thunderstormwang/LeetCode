﻿using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050
{
    [TestFixture]
    public class Solution0024Test
    {
        [TestCase(new int[] { 1, 2, 3, 4 },
            new int[] { 2, 1, 4, 3 })]
        [TestCase(new int[] { 1, 2, 3 },
            new int[] { 2, 1, 3 })]
        [TestCase(new int[] { 1, 2 },
            new int[] { 2, 1 })]
        [TestCase(new int[] { 1 },
            new int[] { 1 })]
        [TestCase(new int[] { },
            new int[] { })]
        public void SwapPairsTest_Version1(int[] input,
            int[] expected)
        {
            var solution = new Solution0024();

            var list = Utility.BuildListNode(input);
            var actual = solution.SwapPairs_Version1(list);

            var expectedListNode = Utility.BuildListNode(expected);

            Utility.CheckListNode(actual,
                expectedListNode).Should().BeTrue();
        }
        
        [TestCase(new int[] { 1, 2, 3, 4 },
            new int[] { 2, 1, 4, 3 })]
        [TestCase(new int[] { 1, 2, 3 },
            new int[] { 2, 1, 3 })]
        [TestCase(new int[] { 1, 2 },
            new int[] { 2, 1 })]
        [TestCase(new int[] { 1 },
            new int[] { 1 })]
        [TestCase(new int[] { },
            new int[] { })]
        public void SwapPairsTest_Version2(int[] input,
            int[] expected)
        {
            var solution = new Solution0024();

            var list = Utility.BuildListNode(input);
            var actual = solution.SwapPairs_Version2(list);

            var expectedListNode = Utility.BuildListNode(expected);

            Utility.CheckListNode(actual,
                expectedListNode).Should().BeTrue();
        }
    }
}