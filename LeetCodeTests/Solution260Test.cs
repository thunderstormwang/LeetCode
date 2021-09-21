using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution260Test
    {
        [TestCase(new int[] { 1, 2, 1, 3, 2, 5 },
            new int[] { 3, 5 })]
        [TestCase(new int[] { -1, 0 },
            new int[] { -1, 0 })]
        [TestCase(new int[] { 0, 1 },
            new int[] { 1, 0 })]
        public void SingleNumberTest(int[] input,
            int[] expected)
        {
            var solution260 = new Solution260();
            var actual = solution260.SingleNumber(input);

            actual.Should().BeEquivalentTo(expected);
        }
    }
}