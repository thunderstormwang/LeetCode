﻿using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0055Test
    {
        [TestCase(new int[] { 2, 3, 1, 1, 4 },
            true)]
        [TestCase(new int[] { 3, 2, 1, 0, 4 },
            false)]
        [TestCase(new int[] { 0, 0, 4 },
            false)]
        public void CanJump(int[] nums,
            bool expected)
        {
            var solution = new Solution0055();
            var actual = solution.CanJump(nums);

            actual.Should().Be(expected);
        }
    }
}