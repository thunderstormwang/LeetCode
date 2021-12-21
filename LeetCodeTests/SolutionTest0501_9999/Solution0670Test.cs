using FluentAssertions;
using LeetCode.Solution0501_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999
{
    [TestFixture]
    public class Solution0670Test
    {
        [TestCase(2736,
            7236)]
        [TestCase(9973,
            9973)]
        [TestCase(1993,
            9913)]
        [TestCase(9678,
            9876)]
        [TestCase(333,
            333)]
        [TestCase(323,
            332)]
        public void MaximumSwap_Version1(int num,
            int expected)
        {
            var solution = new Solution0670();
            var actual = solution.MaximumSwap_Version1(num);

            actual.Should().Be(expected);
        }
        
        [TestCase(2736,
            7236)]
        [TestCase(9973,
            9973)]
        [TestCase(1993,
            9913)]
        [TestCase(9678,
            9876)]
        [TestCase(333,
            333)]
        [TestCase(323,
            332)]
        public void MaximumSwap_Version2(int num,
            int expected)
        {
            var solution = new Solution0670();
            var actual = solution.MaximumSwap_Version2(num);

            actual.Should().Be(expected);
        }
    }
}