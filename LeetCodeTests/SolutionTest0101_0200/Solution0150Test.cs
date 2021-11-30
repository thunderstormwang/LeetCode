using FluentAssertions;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200
{
    [TestFixture]
    public class Solution0150Test
    {
        [TestCase(new string[] { "2", "1", "+", "3", "*" },
            9)]
        [TestCase(new string[] { "4", "13", "5", "/", "+" },
            6)]
        [TestCase(new string[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" },
            22)]
        public void EvalRPN(string[] tokens,
            int expected)
        {
            var solution = new Solution0150();
            var actual = solution.EvalRPN(tokens);

            actual.Should().Be(expected);
        }
    }
}