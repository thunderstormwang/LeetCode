using NUnit.Framework;
using LeetCode;
using FluentAssertions;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0110Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void IsBalancedTest(int?[] array,
            bool expected)
        {
            var root = Utility.BuildTree(array,
                0);

            var solution = new Solution0110();
            var actual = solution.IsBalanced(root);

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
            }
        };
    }
}