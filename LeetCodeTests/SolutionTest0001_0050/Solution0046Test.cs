using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
[Category("SolutionTest0001_0050")]
public class Solution0046Test
{
    [TestCaseSource(nameof(TestCases))]
    public void Permute_Ver1Test(int[] input, int[][] expectedArray)
    {
        var solution046 = new Solution0046();
        var actual = solution046.Permute_Ver1(input);

        actual.Should().BeEquivalentTo(expectedArray);
    }

    [TestCaseSource(nameof(TestCases))]
    public void Permute_Ver2Test(int[] input, int[][] expectedArray)
    {
        var solution046 = new Solution0046();
        var actual = solution046.Permute_Ver2(input);

        actual.Should().BeEquivalentTo(expectedArray);
    }

    [TestCaseSource(nameof(TestCases))]
    public void Permute_Ver3Test(int[] input, int[][] expectedArray)
    {
        var solution = new Solution0046();
        var actual = solution.Permute_Ver3(input);

        actual.Should().BeEquivalentTo(expectedArray);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 2, 3 },
            new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 1, 3, 2 },
                new int[] { 2, 1, 3 },
                new int[] { 2, 3, 1 },
                new int[] { 3, 1, 2 },
                new int[] { 3, 2, 1 }
            }
        },
        new object[]
        {
            new int[] { 0, 1 },
            new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 1, 0 }
            }
        },
        new object[]
        {
            new int[] { 1 },
            new int[][]
            {
                new int[] { 1 }
            }
        }
    };
}