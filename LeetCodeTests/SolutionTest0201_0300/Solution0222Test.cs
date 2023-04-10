using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300
{
    [TestFixture]
    public class Solution0222Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void CountNodes(int? [] array, int expected)
        {
            var root = Utility.BuildTree(array, 0);

            var solution = new Solution0222();
            var actual = solution.CountNodes(root);

            actual.Should().Be(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 1, 2, 3, 4, 5, 6 },
                6
            },
            new object[]
            {
                new int?[] { 1 },
                1
            },
            new object[]
            {
                new int?[] { },
                0
            }
        };
    }
}