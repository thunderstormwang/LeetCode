using FluentAssertions;
using LeetCode;
using LeetCode.Models;
using LeetCode.Solution0101_0150;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0150;

[TestFixture]
[Category("SolutionTest0101_0150")]
public class Solution0141Test
{
    [TestCaseSource(nameof(TestCases))]
    public void HasCycle_Ver1Test(int[] array, int pos, bool expected)
    {
        var list = Utility.BuildListNode(array, pos);

        var solution = new Solution0141();
        var actual = solution.HasCycle_Ver1(list);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void HasCycle_Ver2Test(int[] array, int pos, bool expected)
    {
        var list = Utility.BuildListNode(array, pos);

        var solution = new Solution0141();
        var actual = solution.HasCycle_Ver2(list);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void HasCycle_Ver3Test(int[] array, int pos, bool expected)
    {
        var list = Utility.BuildListNode(array, pos);

        var solution = new Solution0141();
        var actual = solution.HasCycle_Ver3(list);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 3, 2, 0, 4 },
            1,
            true
        },
        new object[]
        {
            new int[] { 1, 2 },
            0,
            true
        },
        new object[]
        {
            new int[] { 1 },
            -1,
            false
        },
        new object[]
        {
            new int[] { },
            -1,
            false
        }
    };
}