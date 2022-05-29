using FluentAssertions;
using LeetCode.Solution0201_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0500
{
    [TestFixture]
    public class Solution0279Test
    {
        [TestCase(75, 3)]
        [TestCase(43, 3)]
        [TestCase(38, 3)]
        [TestCase(32, 2)]
        [TestCase(25, 1)]
        [TestCase(13, 2)]
        [TestCase(12, 3)]
        [TestCase(1, 1)]
        public void NumSquaresTest(int input, int expected)
        {
            var solution = new Solution0279();
            var actual = solution.NumSquares(input);

            actual.Should().Be(expected);
        }
    }
}