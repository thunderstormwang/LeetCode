using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution279Test
    {
        [TestCase(75,
            3)]
        [TestCase(43,
            3)]
        [TestCase(38,
            3)]
        [TestCase(32,
            2)]
        [TestCase(25,
            1)]
        [TestCase(13,
            2)]
        [TestCase(12,
            3)]
        [TestCase(1,
            1)]
        public void NumSquaresTest(int input,
            int expected)
        {
            var solution279 = new Solution279();
            var actual = solution279.NumSquares(input);

            actual.Should().Be(expected);
        }
    }
}