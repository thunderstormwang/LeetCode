﻿using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution053Test
    {
        [TestCase(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
        public void MaxSubArrayTest(int[] array, int expected)
        {
            var solution53 = new Solution53();

            var actual = solution53.MaxSubArray(array);

            actual.Should().Be(expected);
        }
    }
}