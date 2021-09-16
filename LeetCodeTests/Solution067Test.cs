using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution067Test
    {
        [TestCase("11", "1", "100")]
        [TestCase("1010", "1011", "10101")]
        public void AddBinaryTest(string s1, string s2, string expected)
        {
            var solution67 = new Solution67();

            var actual = solution67.AddBinary(s1, s2);

            actual.Should().Be(expected);
        }
    }
}