using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050
{
    [TestFixture]
    [Category("SolutionTest0001_0050")]
    public class Solution0009Test
    {
        [TestCase(5, true)]
        [TestCase(121, true)]
        [TestCase(123321, true)]
        [TestCase(1001, true)]
        [TestCase(1121, false)]
        [TestCase(10, false)]
        [TestCase(100, false)]
        [TestCase(-101, false)]
        public void IsPalindrome(int input, bool expected)
        {
            var solution = new Solution0009();

            var actual = solution.IsPalindrome(input);

            actual.Should().Be(expected);
        }
    }
}