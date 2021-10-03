﻿using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution031Test
    {
        [TestCase(new int[] { 1, 2, 3 },
            new int[] { 1, 3, 2 })]
        [TestCase(new int[] { 1, 3, 2 },
            new int[] { 2, 1, 3 })]
        [TestCase(new int[] { 2, 1, 3 },
            new int[] { 2, 3, 1 })]
        [TestCase(new int[] { 2, 3, 1 },
            new int[] { 3, 1, 2 })]
        [TestCase(new int[] { 3, 1, 2 },
            new int[] { 3, 2, 1 })]
        [TestCase(new int[] { 3, 2, 1 },
            new int[] { 1, 2, 3 })]
        public void NextPermutationTest(int[] nums,
            int[] expected)
        {
            var solution031 = new Solution031();
            solution031.NextPermutation(nums);

            nums.Should().Equal(expected);
        }
    }
}