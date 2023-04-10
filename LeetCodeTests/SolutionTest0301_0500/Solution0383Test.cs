using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500
{
    [TestFixture]
    public class Solution0383Test
    {
        [TestCase("a", "b", false)]
        [TestCase("aa", "ab", false)]
        [TestCase("aa", "aab", true)]
        public void CanConstruct(string ransomNote, string magazine, bool expected)
        {
            var solution = new Solution0383();
            var actual = solution.CanConstruct(ransomNote, magazine);

            actual.Should().Be(expected);
        }
    }
}