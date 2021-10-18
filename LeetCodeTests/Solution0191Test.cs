using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0191Test
    {
        [TestCase(0U,
            0)]
        [TestCase(11U,
            3)]
        [TestCase(128U,
            1)]
        [TestCase(4294967290U,
            30)]
        [TestCase(4294967293U,
            31)]
        [TestCase(4294967295U,
            32)]
        public void HammingWeight_ShiftTest(uint input,
            int expected)
        {
            var solution = new Solution0191();
            var actual = solution.HammingWeight_Shift(input);

            actual.Should().Be(expected);
        }
        
        [TestCase(0U,
            0)]
        [TestCase(11U,
            3)]
        [TestCase(128U,
            1)]
        [TestCase(4294967290U,
            30)]
        [TestCase(4294967293U,
            31)]
        [TestCase(4294967295U,
            32)]
        public void HammingWeight_DivideTest(uint input,
            int expected)
        {
            var solution191 = new Solution0191();
            var actual = solution191.HammingWeight_Divide(input);

            actual.Should().Be(expected);
        }
    }
}