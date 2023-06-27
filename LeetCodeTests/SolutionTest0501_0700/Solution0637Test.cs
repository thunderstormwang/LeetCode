using FluentAssertions;
using LeetCode.Solution0501_0700;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_0700
{
    [TestFixture]
    [Category("SolutionTest0501_0700")]
    public class Solution0637Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void AverageOfLevels(int?[] array, IList<double> expected)
        {
            var root = Utility.BuildTree(array, 0);

            var solution = new Solution0637();
            var actual = solution.AverageOfLevels(root);

            actual.Should().Equal(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 3, 9, 20, null, null, 15, 7 },
                new double[] { 3.00000, 14.50000, 11.00000 }
            },
            new object[]
            {
                new int?[] { 3, 9, 20, 15, 7 },
                new double[] { 3.00000, 14.50000, 11.00000 }
            },
            new object[]
            {
                new int?[] { 2147483647, 2147483647, 2147483647 },
                new double[] { 2147483647.00000, 2147483647.00000 }
            }
        };
    }
}