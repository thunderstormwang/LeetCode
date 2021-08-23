using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution058Tests
    {
        [TestCase("Hello World", 5)]
        [TestCase("Hello ", 5)]
        [TestCase("WorldOfWarcraft", 15)]
        public void LengthOfLastWordTest(string s, int expected)
        {
            Solution58 solution58 = new Solution58();

            int actual = solution58.LengthOfLastWord(s);

            actual.Should().Be(expected);
        }
    }
}