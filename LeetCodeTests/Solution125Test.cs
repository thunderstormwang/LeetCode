using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution125Test
    {
        [TestCase("A man, a plan, a canal: Panama", true)]
        [TestCase("race a car", false)]
        public void IsPalindromeTest(string s, bool expected)
        {
            var solution125 = new Solution125();
            var actual = solution125.IsPalindrome(s);

            actual.Should().Be(expected);
        }
    }
}