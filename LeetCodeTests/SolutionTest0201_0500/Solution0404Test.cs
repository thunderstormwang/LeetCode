using FluentAssertions;
using LeetCode.Solution0201_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0500
{
    [TestFixture]
    public class Solution0404Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void SumOfLeftLeaves_RecursiveTest(int?[] array, int expected)
        {
            var root = Utility.BuildTree(array, 0);

            var solution = new Solution0404();
            var actual = solution.SumOfLeftLeaves_Recursive(root);

            actual.Should().Be(expected);
        }
        
        [TestCaseSource(nameof(TestCases))]
        public void SumOfLeftLeaves_IterativeTest(int?[] array, int expected)
        {
            var root = Utility.BuildTree(array, 0);

            var solution = new Solution0404();
            var actual = solution.SumOfLeftLeaves_Iterative(root);

            actual.Should().Be(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 3, 9, 20, null, null, 15, 7 },
                24
            },
            new object[]
            {
                new int?[] { 1 },
                0
            }
        };
    }
}