using System.Collections.Generic;
using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution022Test
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
            var solution022 = new Solution022();

            var actual = solution022.GenerateParenthesis(input);

            var expectedList = new List<string>(expected);

            actual.Should().BeEquivalentTo(expectedList);
        }
    }
}