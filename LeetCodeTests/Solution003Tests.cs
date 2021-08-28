﻿using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution003Tests
    {
        [TestCase("abcabcbb", 3)]
        [TestCase("bbbbb", 1)]
        [TestCase("pwwkew", 3)]
        [TestCase("", 0)]
        [TestCase("GEEKSFORGEEKS", 7)]
        public void LengthOfLongestSubstring_Brutal_Test(string input,
            int expected)
        {
            var solution003 = new Solution003();

            var actual = solution003.LengthOfLongestSubstring_Brutal(input);

            actual.Should().Be(expected);
        }
        
        [TestCase("abcabcbb", 3)]
        [TestCase("bbbbb", 1)]
        [TestCase("pwwkew", 3)]
        [TestCase("", 0)]
        [TestCase("GEEKSFORGEEKS", 7)]
        public void LengthOfLongestSubstring_SlideWindow_Test(string input,
            int expected)
        {
            var solution003 = new Solution003();

            var actual = solution003.LengthOfLongestSubstring_SlideWindow(input);

            actual.Should().Be(expected);
        }
        
        [TestCase("abcabcbb", 3)]
        [TestCase("bbbbb", 1)]
        [TestCase("pwwkew", 3)]
        [TestCase("", 0)]
        [TestCase("GEEKSFORGEEKS", 7)]
        public void LengthOfLongestSubstring_Linear_Test(string input,
            int expected)
        {
            var solution003 = new Solution003();
        
            var actual = solution003.LengthOfLongestSubstring_Linear(input);
        
            actual.Should().Be(expected);
        }
    }
}