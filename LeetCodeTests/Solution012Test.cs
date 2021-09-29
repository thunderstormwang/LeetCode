using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution012Test
    {
        [TestCase(3,
            "III")]
        [TestCase(4,
            "IV")]
        [TestCase(9,
            "IX")]
        [TestCase(58,
            "LVIII")]
        [TestCase(1994,
            "MCMXCIV")]
        [TestCase(3999,
            "MMMCMXCIX")]
        [TestCase(2900,
            "MMCM")]
        public void IntToRoman(int num,
            string expected)
        {
            var solution012 = new Solution012();

            var actual = solution012.IntToRoman(num);

            actual.Should().Be(expected);
        }
    }
}