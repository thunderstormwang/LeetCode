using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution058Test
    {
        [TestCase("Hello World", 5)]
        [TestCase("Hello ", 5)]
        [TestCase("WorldOfWarcraft", 15)]
        public void LengthOfLastWordTest(string s, int expected)
        {
            var solution58 = new Solution58();

            var actual = solution58.LengthOfLastWord(s);

            actual.Should().Be(expected);
        }
    }
}