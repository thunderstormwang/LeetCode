using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution038Tests
    {
        [TestCase(1, "1")]
        [TestCase(2, "11")]
        [TestCase(3, "21")]
        [TestCase(4, "1211")]
        [TestCase(5, "111221")]
        public void CountAndSayTest(int param, string expected)
        {
            Solution38 solution38 = new Solution38();
            string actual = solution38.CountAndSay(param);

            actual.Should().Be(expected);
        }
    }
}