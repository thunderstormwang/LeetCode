using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050
{
    [TestFixture]
    [Category("SolutionTest0001_0050")]
    public class Solution0036Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void IsValidSudoku(char[][] board, bool expected)
        {
            var solution = new Solution0036();

            var actual = solution.IsValidSudoku(board);

            actual.Should().Be(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new char[][]
                {
                    new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
                    new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                    new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                    new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                    new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                    new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                    new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                    new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                    new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' },
                },
                true
            },
            new object[]
            {
                new char[][]
                {
                    new char[] { '8', '3', '.', '.', '7', '.', '.', '.', '.' },
                    new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                    new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                    new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                    new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                    new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                    new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                    new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                    new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' },
                },
                false
            },
            new object[]
            {
                new char[][]
                {
                    new char[] { '.', '.', '4', '.', '.', '.', '6', '3', '.' },
                    new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                    new char[] { '5', '.', '.', '.', '.', '.', '.', '9', '.' },
                    new char[] { '.', '.', '.', '5', '6', '.', '.', '.', '.' },
                    new char[] { '4', '.', '3', '.', '.', '.', '.', '.', '1' },
                    new char[] { '.', '.', '.', '7', '.', '.', '.', '.', '.' },
                    new char[] { '.', '.', '.', '5', '.', '.', '.', '.', '.' },
                    new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                    new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                },
                false
            }
        };
    }
}