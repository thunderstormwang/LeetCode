﻿using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500
{
    [TestFixture]
    [Category("SolutionTest0301_0500")]
    public class Solution0344Test
    {
        [TestCase(new char[] { 'h', 'e', 'l', 'l', 'o' }, new char[] { 'o', 'l', 'l', 'e', 'h' })]
        [TestCase(new char[] { 'H', 'a', 'n', 'n', 'a', 'h' }, new char[] { 'h', 'a', 'n', 'n', 'a', 'H' })]
        public void ReverseString(char[] s, char[] expected)
        {
            var solution = new Solution0344();
            solution.ReverseString(s);

            s.Should().Equal(expected);
        }
    }
}