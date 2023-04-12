using FluentAssertions;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200
{
    [TestFixture]
    [Category("SolutionTest0101_0200")]
    public class Solution0110Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void IsBalanced_BottomUpTest(int?[] array, bool expected)
        {
            var root = Utility.BuildTree(array, 0);

            var solution = new Solution0110();
            var actual = solution.IsBalanced_BottomUp(root);

            actual.Should().Be(expected);
        }

        [TestCaseSource(nameof(TestCases))]
        public void IsBalanced_TopDownTest(int?[] array, bool expected)
        {
            var root = Utility.BuildTree(array, 0);

            var solution = new Solution0110();
            var actual = solution.IsBalanced_TopDown(root);

            actual.Should().Be(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 3, 9, 20, null, null, 15, 7 },
                true
            },
            new object[]
            {
                new int?[] { 1, 2, 2, 3, 3, null, null, 4, 4 },
                false
            },
            new object[]
            {
                new int?[] {0 },
                true
            }
        };
    }
}