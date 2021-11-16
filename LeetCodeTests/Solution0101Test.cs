using NUnit.Framework;
using LeetCode;
using FluentAssertions;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0101Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void IsSymmetricTest(int? [] array, bool expected)
        {
            var root = Utility.BuildTree(array, 0);

            var solution = new Solution0101();
            var actual = solution.IsSymmetric(root);

            actual.Should().Be(expected);
        }
        
        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 1, 2, 2, 3, 4, 4, 3 },
                true
            },
            new object[]
            {
                new int?[] { 1, 2, 2, null, 3, null, 3 },
                false
            }
        };
    }
}