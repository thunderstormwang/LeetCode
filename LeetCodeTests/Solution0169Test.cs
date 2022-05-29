using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0169Test
    {
        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] { 3, 2, 3 }, 3)]
        [TestCase(new int[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
        public void MajorityElementTest(int[] inputArray, int expected)
        {
            var solution = new Solution0169();
            var actual = solution.MajorityElement(inputArray);

            actual.Should().Be(expected);
        }
    }
}