using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution1356Test
    {
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 0, 1, 2, 4, 8, 3, 5, 6, 7 })]
        [TestCase(new int[] { 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 }, new int[] { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024 })]
        [TestCase(new int[] { 10000, 10000 }, new int[] { 10000, 10000 })]
        [TestCase(new int[] { 2, 3, 5, 7, 11, 13, 17, 19 }, new int[] { 2, 3, 5, 17, 7, 11, 13, 19 })]
        [TestCase(new int[] { 10, 100, 1000, 10000 }, new int[] { 10, 100, 10000, 1000 })]
        public void SortByBitsTest(int[] inputArray, int[] expectedArray)
        {
            var solution = new Solution1356();
            var actual = solution.SortByBits(inputArray);

            actual.Should().BeEquivalentTo(expectedArray);
        }
    }
}