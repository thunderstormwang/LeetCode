using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution011Test
    {
        [TestCase(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 },
            49)]
        [TestCase(new int[] { 1, 1 },
            1)]
        [TestCase(new int[] { 4, 3, 2, 1, 4 },
            16)]
        [TestCase(new int[] { 1, 2, 1 },
            2)]
        public void MaxAreaTest(int[] input,
            int expected)
        {
            var solution011 = new Solution011();

            var actual = solution011.MaxArea(input);

            actual.Should().Be(expected);
        }
    }
}