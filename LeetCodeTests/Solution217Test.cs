using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution217Test
    {
        [TestCase(new int[] { 1, 2, 3, 1 },
            true)]
        [TestCase(new int[] { 1, 2, 3, 4 },
            false)]
        [TestCase(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 },
            true)]
        [TestCase(new int[] { },
            false)]
        [TestCase(new int[] { 999 },
            false)]
        public void ContainsDuplicateTest(int[] input,
            bool expected)
        {
            var solution217 = new Solution217();
            var actual = solution217.ContainsDuplicate(input);

            actual.Should().Be(expected);
        }
    }
}