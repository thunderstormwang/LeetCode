using FluentAssertions;
using LeetCode.Solution0051_0100;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0051_0100;

[TestFixture]
[Category("SolutionTest0051_0100")]
public class Solution0077Test
{
    [TestCaseSource(nameof(TestCases))]
    public void Combine(int n, int k, IList<IList<int>> expected)
    {
        var solution = new Solution0077();
        var actual = solution.Combine(n, k);

        actual.Should().BeEquivalentTo(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            1,
            1,
            new int[][]
            {
                new int[] { 1 }
            }
        },
        new object[]
        {
            4,
            2,
            new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 1, 3 },
                new int[] { 1, 4 },
                new int[] { 2, 3 },
                new int[] { 2, 4 },
                new int[] { 3, 4 }
            }
        }
    };
}