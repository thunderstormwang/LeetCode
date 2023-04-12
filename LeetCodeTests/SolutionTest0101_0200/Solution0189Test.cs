using FluentAssertions;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200;

[TestFixture]
[Category("SolutionTest0101_0200")]
public class Solution0189Test
{
    [TestCaseSource(nameof(TestCases))]
    public void Rotate_Ver1Test(int[] nums, int k, int[] expected)
    {
        var array = new int [nums.Length];
        Array.Copy(nums, array, nums.Length);
        
        var solution = new Solution0189();
        solution.Rotate_Ver1(array, k);

        array.Should().Equal(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void Rotate_Ver2Test(int[] nums, int k, int[] expected)
    {
        var array = new int [nums.Length];
        Array.Copy(nums, array, nums.Length);
        
        var solution = new Solution0189();
        solution.Rotate_Ver2(array, k);

        array.Should().Equal(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 2, 3, 4, 5, 6, 7 },
            3,
            new int[] { 5, 6, 7, 1, 2, 3, 4 }
        },
        new object[]
        {
            new int[] { 1, 2, 3, 4, 5, 6, 7 },
            10,
            new int[] { 5, 6, 7, 1, 2, 3, 4 }
        },
        new object[]
        {
            new int[] { 1, 2, 3, 4, 5, 6, 7 },
            14,
            new int[] { 1, 2, 3, 4, 5, 6, 7 }
        },
        new object[]
        {
            new int[] { 1, 2, 3, 4, 5, 6 },
            3,
            new int[] { 4, 5, 6, 1, 2, 3 }
        },
        new object[]
        {
            new int[] { 1, 2, 3, 4, 5, 6 },
            9,
            new int[] { 4, 5, 6, 1, 2, 3 }
        },
        new object[]
        {
            new int[] { 1, 2, 3, 4, 5, 6 },
            4,
            new int[] { 3, 4, 5, 6, 1, 2 }
        }
    };
}