using FluentAssertions;
using LeetCode.Solution0201_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0500;

[TestFixture]
public class Solution0216Test
{
    [TestCaseSource(nameof(TestCases))]
    public void CombinationSum3(int k, int n, IList<IList<int>> expected)
    {
        var solution = new Solution0216();
        var actual = solution.CombinationSum3(k, n);

        actual.Should().BeEquivalentTo(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            3,
            7,
            new int[][]
            {
                new int[] { 1, 2, 4 }
            }
        },
        new object[]
        {
            3,
            9,
            new int[][]
            {
                new int[] { 1, 2, 6 },
                new int[] { 1, 3, 5 },
                new int[] { 2, 3, 4 }
            }
        },
        new object[]
        {
            4,
            1,
            Array.Empty<int[]>()
        }
    };
}