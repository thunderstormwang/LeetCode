using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution069Test
    {
        [TestCase(4, 2)]
        [TestCase(8, 2)]
        public void MySqrtTest(int x, int expected)
        {
            var solution69 = new Solution69();

            var actual = solution69.MySqrt(x);

            actual.Should().Be(expected);
        }
    }
}