using FluentAssertions;
using LeetCode.Solution0501_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999;

[TestFixture]
public class Solution0560Test
{
    [TestCaseSource(nameof(TestCases))]
    public void SubarraySum_Brutal_Ver1Test(int[] nums, int k, int expected)
    {
        var solution = new Solution0560();
        var actual = solution.SubarraySum_Brutal_Ver1(nums, k);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void SubarraySum_Brutal_Ver2Test(int[] nums, int k, int expected)
    {
        var solution = new Solution0560();
        var actual = solution.SubarraySum_Brutal_Ver2(nums, k);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void SubarraySum_DictionaryTest(int[] nums, int k, int expected)
    {
        var solution = new Solution0560();
        var actual = solution.SubarraySum_Dictionary(nums, k);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 1, 1 },
            2,
            2
        },
        new object[]
        {
            new int[] { 1, 2, 3 },
            3,
            2
        }
    };
}