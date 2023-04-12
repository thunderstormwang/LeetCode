using FluentAssertions;
using LeetCode.Solution0501_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999
{
    [TestFixture]
    [Category("SolutionTest0501_9999")]
    public class Solution0515Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void LargestValues(int?[] array, IList<int> expected)
        {
            var root = Utility.BuildTree(array, 0);

            var solution = new Solution0515();
            var actual = solution.LargestValues(root);

            actual.Should().Equal(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 1, 3, 2, 5, 3, null, 9 },
                new int[] { 1, 3, 9 }
            },
            new object[]
            {
                new int?[] { 1, 2, 3 },
                new int[] { 1, 3 }
            },
            new object[]
            {
                new int?[] { 1 },
                new int[] { 1 }
            },
            new object[]
            {
                new int?[] { 1, null, 2 },
                new int[] { 1, 2 }
            },
            new object[]
            {
                new int?[] { },
                new int[] { }
            }
        };
    }
}