﻿using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;
using LeetCode;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0119Test
    {
        [TestCase(0, new int[] { 1 })]
        [TestCase(1, new int[] { 1, 1 })]
        [TestCase(2, new int[] { 1, 2, 1 })]
        [TestCase(3, new int[] { 1, 3, 3, 1 })]
        [TestCase(4, new int[] { 1, 4, 6, 4, 1 })]
        public void GetRowTest(int rowIndex, int[] expected)
        {
            var solution = new Solution0119();
            var actual = solution.GetRow(rowIndex);

            actual.Should().Equal(expected);
        }
    }
}