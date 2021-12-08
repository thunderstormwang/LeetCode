using FluentAssertions;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200
{
    [TestFixture]
    public class Solution0116Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void Connect_BFS(int?[] array,
            string expected)
        {
            var root = Utility.BuildTreeV2(array,
                0);

            var solution = new Solution0116();
            var actual = solution.Connect_BFS(root);

            Utility.GetNodeString(actual).Should().Be(expected);
        }
        
        [TestCaseSource(nameof(TestCases))]
        public void Connect_DFS(int?[] array,
            string expected)
        {
            var root = Utility.BuildTreeV2(array,
                0);

            var solution = new Solution0116();
            var actual = solution.Connect_DFS(root);

            Utility.GetNodeString(actual).Should().Be(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 1, 2, 3, 4, 5, 6, 7 },
                "1,#,2,3,#,4,5,6,7,#"
            },
            new object[]
            {
                new int?[] { },
                string.Empty
            }
        };
    }
}