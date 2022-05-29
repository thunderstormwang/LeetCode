using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0078Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void SubsetsTest(int[] inputArray, int[][] expectedArray)
        {
            var solution = new Solution0078();
            var actual = solution.Subsets(inputArray);

            var expected = new List<List<int>>();
            foreach (var item in expectedArray)
            {
                expected.Add(new List<int>(item));
            }

            actual.Should().BeEquivalentTo(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int[] { 0 },
                new int[][]
                {
                    new int[] { },
                    new int[] { 0 }
                }
            },
            new object[]
            {
                new int[] { 0, 1 },
                new int[][]
                {
                    new int[] { },
                    new int[] { 0 },
                    new int[] { 1 },
                    new int[] { 0, 1 }
                }
            },
            new object[]
            {
                new int[] { 0, 1, 2 },
                new int[][]
                {
                    new int[] { },
                    new int[] { 0 },
                    new int[] { 1 },
                    new int[] { 2 },
                    new int[] { 0, 1 },
                    new int[] { 0, 2 },
                    new int[] { 1, 2 },
                    new int[] { 0, 1, 2 }
                }
            }
        };
    }
}