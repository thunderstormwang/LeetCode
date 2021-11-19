using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050
{
    [TestFixture]
    public class Solution0007Test
    {
        [TestCase(123,
            321)]
        [TestCase(-123,
            -321)]
        [TestCase(120,
            21)]
        [TestCase(0,
            0)]
        [TestCase(1534236469,
            0)]
        [TestCase(-2147483648,
            0)]
        public void ReverseTest(int input,
            int expected)
        {
            var solution = new Solution0007();

            var actual = solution.Reverse(input);

            actual.Should().Be(expected);
        }
    }
}