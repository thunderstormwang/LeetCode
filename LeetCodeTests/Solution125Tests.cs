using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class Solution125Tests
    {
        [TestCase("A man, a plan, a canal: Panama", true)]
        [TestCase("race a car", false)]
        public void IsPalindromeTest(string s, bool expected)
        {
            Solution125 solution125 = new Solution125();
            bool actual = solution125.IsPalindrome(s);

            actual.Should().Be(expected);
        }
    }
}