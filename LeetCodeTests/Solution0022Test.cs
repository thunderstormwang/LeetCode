using System.Collections.Generic;
using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0022Test
    {
        [TestCase(1,
            new string[] { "()" })]
        [TestCase(2,
            new string[] { "(())" ,"()()"})]
        [TestCase(3,
            new string[] { "((()))", "(()())", "(())()", "()(())", "()()()" })]
        public void ThreeSumClosestTest(int input,
            string[] expected)
        {
            var solution = new Solution0022();

            var actual = solution.GenerateParenthesis(input);

            var expectedList = new List<string>(expected);

            actual.Should().BeEquivalentTo(expectedList);
        }
    }
}