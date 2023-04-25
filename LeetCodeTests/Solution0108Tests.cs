using FluentAssertions;
using NUnit.Framework;
using LeetCodeTests;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class Solution0108Tests
    {
        [TestCaseSource(nameof(TestCases))]
        public void SortedArrayToBSTTest(int[] array, int?[] expectedArray)
        {
            var expected = Utility.BuildTree(expectedArray, 0);

            var solution = new Solution0108();
            var actual = solution.SortedArrayToBST(array);

            Utility.CheckBinaryTree(actual, expected).Should().BeTrue();
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int[] { -10, -3, 0, 5, 9 },
                new int?[] { 3, 9, 20, null, null, 15, 7 }
            }
        };
    }
}