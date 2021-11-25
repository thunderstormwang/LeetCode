﻿using FluentAssertions;
using LeetCode.Solution0201_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_9999
{
    [TestFixture]
    public class Solution0541Test
    {
        [TestCase("abcdefg",
            2,
            "bacdfeg")]
        [TestCase("abcd",
            2,
            "bacd")]
        [TestCase("abcd",
            1,
            "abcd")]
        [TestCase("abcd",
            6,
            "dcba")]
        public void ReverseStr(string s,
            int k,
            string expected)
        {
            var solution = new Solution0541();
            var actual = solution.ReverseStr(s,
                k);

            actual.Should().Be(expected);
        }
    }
}