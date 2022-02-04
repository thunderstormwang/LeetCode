using FluentAssertions;
using LeetCode.Solution0501_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999
{
    [TestFixture]
    public class Solution0617Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void MergeTrees_RecursiveTest(int?[] array1,
            int?[] array2,
            int?[] expectedArray)
        {
            var root1 = Utility.BuildTree(array1,
                0);
            var root2 = Utility.BuildTree(array2,
                0);
            var expected = Utility.BuildTree(expectedArray,
                0);

            var solution = new Solution0617();

            var actual = solution.MergeTrees_Recursive(root1,
                root2);

            Utility.CheckBinaryTree(actual,
                expected).Should().BeTrue();
        }
        
        [TestCaseSource(nameof(TestCases))]
        public void MergeTrees_IterativeTest(int?[] array1,
            int?[] array2,
            int?[] expectedArray)
        {
            var root1 = Utility.BuildTree(array1,
                0);
            var root2 = Utility.BuildTree(array2,
                0);
            var expected = Utility.BuildTree(expectedArray,
                0);

            var solution = new Solution0617();

            var actual = solution.MergeTrees_Iterative(root1,
                root2);

            Utility.CheckBinaryTree(actual,
                expected).Should().BeTrue();
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 1, 3, 2, 5 },
                new int?[] { 2, 1, 3, null, 4, null, 7 },
                new int?[] { 3, 4, 5, 5, 4, null, 7 }
            },
            new object[]
            {
                new int?[] { 1 },
                new int?[] { 1, 2 },
                new int?[] { 2, 2 }
            },
            new object[]
            {
                new int?[] { 1 },
                new int?[] { },
                new int?[] { 1 }
            },
            new object[]
            {
                new int?[] { },
                new int?[] { },
                new int?[] { }
            }
        };
    }
}