using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0003Test
    {
        [TestCase("abcabcbb", 3)]
        [TestCase("bbbbb", 1)]
        [TestCase("pwwkew", 3)]
        [TestCase("", 0)]
        [TestCase("GEEKSFORGEEKS", 7)]
        [TestCase(" ", 1)]
        [TestCase("aab", 2)]
        [TestCase("dvdf", 3)]
        public void LengthOfLongestSubstring_Brutal_Test(string input,
            int expected)
        {
            var solution = new Solution0003();

            var actual = solution.LengthOfLongestSubstring_Brutal(input);

            actual.Should().Be(expected);
        }
        
        [TestCase("abcabcbb", 3)]
        [TestCase("bbbbb", 1)]
        [TestCase("pwwkew", 3)]
        [TestCase("", 0)]
        [TestCase("GEEKSFORGEEKS", 7)]
        [TestCase(" ", 1)]
        [TestCase("aab", 2)]
        [TestCase("dvdf", 3)]
        public void LengthOfLongestSubstring_SlideWindow_Test(string input,
            int expected)
        {
            var solution003 = new Solution0003();

            var actual = solution003.LengthOfLongestSubstring_SlideWindow(input);

            actual.Should().Be(expected);
        }
        
        [TestCase("abcabcbb", 3)]
        [TestCase("bbbbb", 1)]
        [TestCase("pwwkew", 3)]
        [TestCase("", 0)]
        [TestCase("GEEKSFORGEEKS", 7)]
        [TestCase(" ", 1)]
        [TestCase("aab", 2)]
        [TestCase("dvdf", 3)]
        public void LengthOfLongestSubstring_Linear_Test(string input,
            int expected)
        {
            var solution003 = new Solution0003();
        
            var actual = solution003.LengthOfLongestSubstring_Linear(input);
        
            actual.Should().Be(expected);
        }
    }
}