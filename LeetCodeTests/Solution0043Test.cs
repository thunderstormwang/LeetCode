using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0043Test
    {
        [TestCase("0", "456", "0")]
        [TestCase("1", "456", "456")]
        [TestCase("2", "3", "6")]
        [TestCase("10", "10", "100")]
        [TestCase("90", "90", "8100")]
        [TestCase("123", "456", "56088")]
        public void MultiplyTest(string num1, string num2, string expected)
        {
            var solution = new Solution0043();

            var actual = solution.Multiply(num1, num2);

            actual.Should().Be(expected);
        }
    }
}