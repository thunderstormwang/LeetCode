using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050
{
    [TestFixture]
    [Category("SolutionTest0001_0050")]
    public class Solution0018Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void FourSumTest(int[] input, int target, int[][] expectedArray)
        {
            var solution = new Solution0018();
            var expectList = new List<List<int>>();
            foreach (var array in expectedArray)
            {
                expectList.Add(new List<int>(array));
            }

            var actual = solution.FourSum(input, target);

            actual.Should().BeEquivalentTo(expectList);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int[] { 1, 0, -1, 0, -2, 2 },
                0,
                new int[][]
                {
                    new int[] { -2, -1, 1, 2 },
                    new int[] { -2, 0, 0, 2 }, 
                    new int[] { -1, 0, 0, 1 }
                }
            },
            new object[]
            {
                new int[] { 2, 2, 2, 2, 2 },
                8,
                new int[][]
                {
                    new int[] { 2, 2, 2, 2 }
                }
            }
        };
    }
}