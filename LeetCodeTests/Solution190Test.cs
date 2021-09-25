using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution190Test
    {
        [TestCase(43261596U,
            964176192U)]
        [TestCase(4294967293,
            3221225471)]
        public void ReverseBitsTest(uint input,
            uint expected)
        {
            var solution190 = new Solution190();
            var actual = solution190.ReverseBits(input);

            actual.Should().Be(expected);
        }
    }
}