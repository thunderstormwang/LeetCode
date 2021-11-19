using System.Collections.Generic;
using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050
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

            var actual = solution.GenerateParenthesis_Approach1(input);

            var expectedList = new List<string>(expected);

            actual.Should().BeEquivalentTo(expectedList);
        }
        
        [TestCase(1,
            new string[] { "()" })]
        [TestCase(2,
            new string[] { "(())" ,"()()"})]
        [TestCase(3,
            new string[] { "((()))", "(()())", "(())()", "()(())", "()()()" })]
        public void ThreeSumClosestTest_Approach2(int input,
            string[] expected)
        {
            var solution = new Solution0022();

            var actual = solution.GenerateParenthesis_Approach2(input);

            var expectedList = new List<string>(expected);

            actual.Should().BeEquivalentTo(expectedList);
        }
    }
}