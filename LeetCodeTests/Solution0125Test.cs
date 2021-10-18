using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0125Test
    {
        [TestCase("A man, a plan, a canal: Panama", true)]
        [TestCase("race a car", false)]
        public void IsPalindromeTest(string s, bool expected)
        {
            var solution = new Solution0125();
            var actual = solution.IsPalindrome(s);

            actual.Should().Be(expected);
        }
    }
}