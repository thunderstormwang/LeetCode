﻿using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution066Test
    {
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
        [TestCase(new int[] { 4, 3, 2, 1 }, new int[] { 4, 3, 2, 2 })]
        public void PlusOneTest(int[] array, int[] expected)
        {
            var solution66 = new Solution66();

            var actual = solution66.PlusOne(array);

            actual.Should().Equal(expected);
        }
    }
}