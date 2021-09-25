using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution179Test
    {
        [TestCase(new int[] { 10, 2 },
            "210")]
        [TestCase(new int[] { 3, 30, 34, 5, 9 },
            "9534330")]
        [TestCase(new int[] { 1 },
            "1")]
        [TestCase(new int[] { 10 },
            "10")]
        [TestCase(new int[] { 0 },
            "0")]
        [TestCase(new int[] { 0, 0 },
            "0")]
        public void LargestNumberTest(int[] input,
            string expected)
        {
            var solution179 = new Solution179();
            var actual = solution179.LargestNumber(input);

            actual.Should().Be(expected);
        }
    }
}