using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class Solution69Tests
    {
        [TestCase(4, 2)]
        [TestCase(8, 2)]
        public void MySqrtTest(int x, int expected)
        {
            Solution69 solution69 = new Solution69();

            int actual = solution69.MySqrt(x);

            actual.Should().Be(expected);
        }
    }
}