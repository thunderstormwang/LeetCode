using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0006Test
    {
        [TestCase("PAYPALISHIRING",
            3,
            "PAHNAPLSIIGYIR")]
        [TestCase("PAYPALISHIRING",
            4,
            "PINALSIGYAHRPI")]
        [TestCase("A",
            1,
            "A")]
        [TestCase("ABC",
            2,
            "ACB")]
        public void Convert_Test(string input,
            int numRows,
            string expected)
        {
            var solution = new Solution0006();

            var actual = solution.Convert(input,
                numRows);

            actual.Should().Be(expected);
        }
    }
}