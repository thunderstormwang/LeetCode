using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0287Test
{
    [TestCaseSource(nameof(TestCases))]
    public void FindDuplicate_Ver1Test(int[] nums, int expected)
    {
        var solution = new Solution0287();

        var actual = solution.FindDuplicate_Ver1(nums);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void FindDuplicate_Ver2Test(int[] nums, int expected)
    {
        var solution = new Solution0287();

        var actual = solution.FindDuplicate_Ver2(nums);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void FindDuplicate_Ver3Test(int[] nums, int expected)
    {
        var solution = new Solution0287();

        var actual = solution.FindDuplicate_Ver3(nums);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 3, 4, 2, 2 },
            2
        },
        new object[]
        {
            new int[] { 3, 1, 3, 4, 2 },
            3
        }
    };
}