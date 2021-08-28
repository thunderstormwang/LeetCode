using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution005Test
    {
        [TestCase("babad", "bab")]
        [TestCase("cbbd", "bb")]
        [TestCase("a", "a")]
        [TestCase("ac", "a")]
        [TestCase("aaaa", "aaaa")]
        public void LengthOfLongestSubstring_Brutal_Test(string input,
            string expected)
        {
            var solution005 = new Solution005();

            var actual = solution005.LongestPalindrome(input);

            actual.Should().Be(expected);
        }
    }
}