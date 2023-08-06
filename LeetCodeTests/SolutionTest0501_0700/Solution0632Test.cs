using FluentAssertions;
using LeetCode.Solution0501_0700;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_0700;

[TestFixture]
[Category("SolutionTest0501_0700")]
public class Solution0632Test
{
    [TestCaseSource(nameof(TestCases))]
    public void SmallestRange_Ver1Test(IList<IList<int>> nums, int[] expected)
    {
        var solution = new Solution0632();

        var actual = solution.SmallestRange_Ver1(nums);

        actual.Should().BeEquivalentTo(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void SmallestRange_Ver2Test(IList<IList<int>> nums, int[] expected)
    {
        var solution = new Solution0632();

        var actual = solution.SmallestRange_Ver2(nums);

        actual.Should().BeEquivalentTo(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new List<IList<int>>
            {
                new List<int> { 4, 10, 15, 24, 26 },
                new List<int> { 0, 9, 12, 20 },
                new List<int> { 5, 18, 22, 30 }
            },
            new int[] { 20, 24 }
        },
        new object[]
        {
            new List<IList<int>>
            {
                new List<int> { 1, 2, 3 },
                new List<int> { 1, 2, 3 },
                new List<int> { 1, 2, 3 }
            },
            new int[] { 1, 1 }
        },
        new object[]
        {
            new List<IList<int>>
            {
                new List<int> { -14, 16, 67, 68, 69 },
                new List<int> { 24, 86, 88, 94, 96, 96, 97, 98 },
                new List<int> { -37, 9, 29, 35, 37 },
                new List<int> { -61, 0, 8, 39, 66, 69, 76 }
            },
            new int[] { 8, 24 }
        }
    };
}