using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture()]
    public class Solution067Tests
    {
        [TestCase("11", "1", "100")]
        [TestCase("1010", "1011", "10101")]
        public void AddBinaryTest(string s1, string s2, string expected)
        {
            Solution67 solution67 = new Solution67();

            string actual = solution67.AddBinary(s1, s2);

            actual.Should().Be(expected);
        }
    }
}