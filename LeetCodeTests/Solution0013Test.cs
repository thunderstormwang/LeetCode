using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0013Test
    {
        [TestCase("III",
            3)]
        [TestCase("IV",
            4)]
        [TestCase("IX",
            9)]
        [TestCase("LVIII",
            58)]
        [TestCase("MCMXCIV",
            1994)]
        [TestCase("MMMCMXCIX",
            3999)]
        [TestCase("MMCM",
            2900)]
        public void RomanToIntTest(string input,
            int expected)
        {
            var solution = new Solution0013();

            var actual = solution.RomanToInt(input);

            actual.Should().Be(expected);
        }
    }
}