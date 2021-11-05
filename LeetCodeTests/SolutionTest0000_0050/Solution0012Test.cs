using FluentAssertions;
using LeetCode.Solution0000_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0000_0050
{
    [TestFixture]
    public class Solution0012Test
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
            var solution = new Solution0012();

            var actual = solution.IntToRoman(num);

            actual.Should().Be(expected);
        }
    }
}