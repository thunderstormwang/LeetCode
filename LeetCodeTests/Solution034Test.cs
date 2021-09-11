using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution034Test
    {
        [TestCase(new int[] {5,7,7,8,8,10 }, 8, new int[] { 3,4 })]
        [TestCase(new int[] {5,7,7,8,8,10 }, 6, new int[] { -1,-1 })]
        [TestCase(new int[] { }, 0, new int[] { -1,-1 })]
        public void SearchRangeTest(int[] array, int val, int[] expected)
        {
            var solution034 = new Solution034();
            var actual = solution034.SearchRange(array, val);

            actual.Should().BeEquivalentTo(expected);
        }
    }
}