using FluentAssertions;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200
{
    [TestFixture]
    [Category("SolutionTest0101_0200")]
    public class Solution0117Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void Connect_BFS(int?[] array, string expected)
        {
            var root = Utility.BuildTreeV2(array, 0);

            var solution = new Solution0117();
            var actual = solution.Connect_BFS(root);

            Utility.GetNodeString(actual).Should().Be(expected);
        }

        [TestCaseSource(nameof(TestCases))]
        public void Connect_DFS(int?[] array, string expected)
        {
            var root = Utility.BuildTreeV2(array, 0);

            var solution = new Solution0117();
            var actual = solution.Connect_DFS(root);

            Utility.GetNodeString(actual).Should().Be(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 1, 2, 3, 4, 5, null, 7 },
                "1,#,2,3,#,4,5,7,#"
            },
            new object[]
            {
                new int?[] { },
                string.Empty
            },
            new object[]
            {
                new int?[] { 2, 1, 3, 0, 7, 9, 1, 2, null, 1, 0, null, null, 8, 8, null, null, null, null, 7 },
                "2,#,1,3,#,0,7,9,1,#,2,1,0,8,8,#,7,#"
            }
        };
    }
}