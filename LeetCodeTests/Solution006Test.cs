using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution006Test
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
            var solution006 = new Solution006();

            var actual = solution006.Convert(input,
                numRows);

            actual.Should().Be(expected);
        }
    }
}