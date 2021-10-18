using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0200Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void NumIslandsTest(char[][] grid,
            int expected)
        {
            var solution = new Solution0200();
            var actual = solution.NumIslands(grid);

            actual.Should().Be(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new char[][]
                {
                    new char[] { '1', '1', '1', '1', '0' }, new char[] { '1', '1', '0', '1', '0' },
                    new char[] { '1', '1', '0', '0', '0' }, new char[] { '0', '0', '0', '0', '0' }
                },
                1
            },
            new object[]
            {
                new char[][]
                {
                    new char[] { '1', '1', '0', '0', '0' }, new char[] { '1', '1', '0', '0', '0' },
                    new char[] { '0', '0', '1', '0', '0' }, new char[] { '0', '0', '0', '1', '1' }
                },
                3
            }
        };
    }
}