using FluentAssertions;
using LeetCode.Solution0201_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0500
{
    [TestFixture]
    public class Solution0242Test
    {
        [TestCase("anagram", "nagaram", true)]
        [TestCase("rat", "car", false)]
        [TestCase("apple", "aaaaa", false)]
        [TestCase("apple", "microsoft", false)]
        public void IsAnagram_Version1(string s, string t, bool expected)
        {
            var solution = new Solution0242();
            var actual = solution.IsAnagram_Version1(s, t);

            actual.Should().Be(expected);
        }
        
        [TestCase("anagram", "nagaram", true)]
        [TestCase("rat", "car", false)]
        [TestCase("apple", "aaaaa", false)]
        [TestCase("apple", "microsoft", false)]
        public void IsAnagram_Version2(string s, string t, bool expected)
        {
            var solution = new Solution0242();
            var actual = solution.IsAnagram_Version2(s, t);

            actual.Should().Be(expected);
        }
    }
}