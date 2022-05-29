using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0050Test
    {
        [TestCase(2d, 10, 1024d)]
        [TestCase(2.1d, 3, 9.261d)]
        [TestCase(2d, -2, 0.25d)]
        [TestCase(2d, 0, 1d)]
        [TestCase(1d, 2147483647, 1d)]
        public void MyPow(double x, int n, double expected)
        {
            var solution = new Solution0050();
            var actual = solution.MyPow(x, n);

            actual.Should().Be(expected);
        }

    }
}