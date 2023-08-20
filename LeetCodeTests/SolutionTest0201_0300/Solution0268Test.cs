using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0268Test
{
    [TestCaseSource(nameof(TestCases))]
    public void MissingNumber_Ver1Test(int[] nums, int expected)
    {
        var solution = new Solution0268();
        
        var actual = solution.MissingNumber_Ver1(nums);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void MissingNumber_Ver2Test(int[] nums, int expected)
    {
        var solution = new Solution0268();
        
        var actual = solution.MissingNumber_Ver2(nums);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 0 },
            1
        },
        new object[]
        {
            new int[] { 0, 1 },
            2
        },
        new object[]
        {
            new int[] { 1, 2 },
            0
        },
        new object[]
        {
            new int[] { 0, 2 },
            1
        },
        new object[]
        {
            new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 },
            8
        }
    };
}