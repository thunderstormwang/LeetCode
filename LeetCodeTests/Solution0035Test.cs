using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0035Test
    {
        [TestCase(new int[] { 1, 3, 5, 6 }, 5, 2)]
        [TestCase(new int[] { 1, 3, 5, 6 }, 2, 1)]
        [TestCase(new int[] { 1, 3, 5, 6 }, 7, 4)]
        [TestCase(new int[] { 1, 3, 5, 6 }, 0, 0)]
        public void SearchInsertTest(int[] array, int val, int expected)
        {
            var solution = new Solution0035();

            var actual = solution.SearchInsert(array, val);

            actual.Should().Be(expected);
        }
    }
}