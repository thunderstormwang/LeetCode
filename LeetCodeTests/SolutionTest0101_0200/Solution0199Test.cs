using FluentAssertions;
using LeetCode;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200
{
    [TestFixture]
    public class Solution0199Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void RightSideView(int?[] array,
            int[] expected)
        {
            var root = Utility.BuildTreeV2(array,
                0);

            var solution = new Solution0199();
            var actual = solution.RightSideView(root);

            actual.Should().Equal(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 1, 2, 3, null, 5, null, 4 },
                new int[] { 1, 3, 4 }
            },
            new object[]
            {
                new int?[] { 1, null, 3 },
                new int[] { 1, 3 }
            },
            new object[]
            {
                new int?[] { 1, 3, null },
                new int[] { 1, 3 }
            },

            new object[]
            {
                new int?[] { },
                new int[] { }
            },
        };
    }
}