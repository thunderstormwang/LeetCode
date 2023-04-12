using FluentAssertions;
using LeetCode.Solution0501_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999
{
    [TestFixture]
    [Category("SolutionTest0501_9999")]
    public class Solution1047Test
    {
        [TestCase("abbaca", "ca")]
        [TestCase("azxxzy", "ay")]
        [TestCase("aababaab", "ba")]
        [TestCase("abbbaca", "abaca")]
        [TestCase("aaaaaaaaa", "a")]
        public void RemoveDuplicates_Version1(string s, string expected)
        {
            var solution = new Solution1047();
            var actual = solution.RemoveDuplicates_Version1(s);

            actual.Should().Be(expected);
        }
        
        [TestCase("abbaca", "ca")]
        [TestCase("azxxzy", "ay")]
        [TestCase("aababaab", "ba")]
        [TestCase("abbbaca", "abaca")]
        [TestCase("aaaaaaaaa", "a")]
        public void RemoveDuplicates_Version2(string s, string expected)
        {
            var solution = new Solution1047();
            var actual = solution.RemoveDuplicates_Version2(s);

            actual.Should().Be(expected);
        }
    }
}