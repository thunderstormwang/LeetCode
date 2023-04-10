using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300
{
    [TestFixture]
    public class Solution0257Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void BinaryTreePaths_Recursive(int?[] array, List<string> expected)
        {
            var root = Utility.BuildTree(array, 0);

            var solution = new Solution0257();
            var actual = solution.BinaryTreePaths_Recursive(root);

            actual.Should().BeEquivalentTo(expected);
        }

        [TestCaseSource(nameof(TestCases))]
        public void BinaryTreePaths_Iterative(int?[] array, List<string> expected)
        {
            var root = Utility.BuildTree(array, 0);

            var solution = new Solution0257();
            var actual = solution.BinaryTreePaths_Iterative(root);

            actual.Should().BeEquivalentTo(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 1, 2, 3, null, 5 },
                new List<string>()
                {
                    "1->2->5",
                    "1->3"
                }
            },
            new object[]
            {
                new int?[] { 1, 2, 3, 5, 4 },
                new List<string>()
                {
                    "1->2->5",
                    "1->2->4",
                    "1->3"
                }
            },
            new object[]
            {
                new int?[] { 1 },
                new List<string>()
                {
                    "1"
                }
            }
        };
    }
}