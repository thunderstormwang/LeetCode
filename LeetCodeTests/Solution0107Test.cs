using NUnit.Framework;
using System.Collections.Generic;
using FluentAssertions;
using LeetCode;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0107Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void LevelOrderBottomTest(int?[] array,
            IList<IList<int>> expected)
        {
            var root = Utility.BuildTree(array,
                0);

            var solution = new Solution0107();
            var actual = solution.LevelOrderBottom(root);

            actual.Should().BeEquivalentTo(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 3, 9, 20, null, null, 15, 7 },
                new int[][]
                {
                    new int[] { 15, 7 },
                    new int[] { 9, 20 },
                    new int[] { 3 },
                }
            }
        };
    }
}