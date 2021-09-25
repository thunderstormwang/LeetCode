using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution200Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void NumIslandsTest(char[][] grid,
            int expected)
        {
            var solution200 = new Solution200();
            var actual = solution200.NumIslands(grid);

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