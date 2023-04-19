using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300
{
    [TestFixture]
    [Category("SolutionTest0201_0300")]
    public class Solution0239Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void MaxSlidingWindow_Ver1Test(int[] nums, int k, int[] expected)
        {
            var solution = new Solution0239();
            var actual = solution.MaxSlidingWindow_Ver1(nums, k);

            actual.Should().Equal(expected);
        }

        [TestCaseSource(nameof(TestCases))]
        public void MaxSlidingWindow_Ver2Test(int[] nums, int k, int[] expected)
        {
            var solution = new Solution0239();
            var actual = solution.MaxSlidingWindow_Ve2(nums, k);

            actual.Should().Equal(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int[] { 1, 3, -1, -3, 5, 3, 6, 7 },
                3,
                new int[] { 3, 3, 5, 5, 6, 7 }
            },
            new object[]
            {
                new int[] { 1 },
                1,
                new int[] { 1 }
            },
            new object[]
            {
                new int[] { 1, -1 },
                1,
                new int[] { 1, -1 }
            },
            new object[]
            {
                new int[] { 9, 11 },
                2,
                new int[] { 11 }
            },
            new object[]
            {
                new int[] { 4, -2 },
                2,
                new int[] { 4 }
            },
            new object[]
            {
                new int[] { 1, 3, 1, 2, 0, 5 },
                3,
                new int[] { 3, 3, 2, 5 }
            },

            new object[]
            {
                new int[] { -7, -8, 7, 5, 7, 1, 6, 0 },
                4,
                new int[] { 7, 7, 7, 7, 7 }
            }
        };
    }
}