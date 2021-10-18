using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0058Test
    {
        [TestCase("Hello World", 5)]
        [TestCase("Hello ", 5)]
        [TestCase("WorldOfWarcraft", 15)]
        public void LengthOfLastWordTest(string s, int expected)
        {
            var solution = new Solution0058();

            var actual = solution.LengthOfLastWord(s);

            actual.Should().Be(expected);
        }
    }
}