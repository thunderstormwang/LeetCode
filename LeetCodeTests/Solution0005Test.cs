using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0005Test
    {
        [TestCase("babad", "bab")]
        [TestCase("cbbd", "bb")]
        [TestCase("a", "a")]
        [TestCase("ac", "a")]
        [TestCase("aaaa", "aaaa")]
        [TestCase("caba", "aba")]
        [TestCase("aaaaa", "aaaaa")]
        public void LengthOfLongestSubstring_Brutal_Test(string input,
            string expected)
        {
            var solution = new Solution0005();

            var actual = solution.LongestPalindrome(input);

            actual.Should().Be(expected);
        }
    }
}