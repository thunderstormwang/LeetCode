using NUnit.Framework;
using LeetCode;
using FluentAssertions;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0104Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void MaxDepthTest(int?[] array,
            int expected)
        {
            var root = Utility.BuildTree(array,
                0);

            var solution = new Solution0104();
            var actual = solution.MaxDepth(root);

            actual.Should().Be(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 3, 9, 20, null, null, 15, 7 },
                3
            }
        };
    }
}