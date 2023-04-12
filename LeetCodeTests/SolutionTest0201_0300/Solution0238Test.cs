using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0238Test
{
    [TestCaseSource(nameof(TestCases))]
    public void ProductExceptSelf_Ver1Test(int[] nums, int[] expected)
    {
        var solution = new Solution0238();
        var actual = solution.ProductExceptSelf_Ver1(nums);

        actual.Should().BeEquivalentTo(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void ProductExceptSelf_Ver2Test(int[] nums, int[] expected)
    {
        var solution = new Solution0238();
        var actual = solution.ProductExceptSelf_Ver2(nums);

        actual.Should().BeEquivalentTo(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 2, 3, 4 },
            new int[] { 24, 12, 8, 6 }
        },
        new object[]
        {
            new int[] { -1, 1, 0, -3, 3 },
            new int[] { 0, 0, 9, 0, 0 },
        }
    };
}