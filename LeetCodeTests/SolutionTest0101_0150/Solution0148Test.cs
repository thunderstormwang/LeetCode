using FluentAssertions;
using LeetCode.Solution0101_0150;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0150;

[TestFixture]
[Category("SolutionTest0101_0150")]
public class Solution0148Test
{
    [TestCaseSource(nameof(TestCases))]
    public void SortList_Ver1Test(int[] input, int[] expected)
    {
        var list = Utility.BuildListNode(input);
        var expectedListNode = Utility.BuildListNode(expected);

        var solution = new Solution148();
        var actual = solution.SortList_Ver1(list);

        Utility.CheckLinkedList(actual, expectedListNode).Should().BeTrue();
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void SortList_Ver2Test(int[] input, int[] expected)
    {
        var list = Utility.BuildListNode(input);
        var expectedListNode = Utility.BuildListNode(expected);

        var solution = new Solution148();
        var actual = solution.SortList_Ver2(list);

        Utility.CheckLinkedList(actual, expectedListNode).Should().BeTrue();
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 4, 2, 1, 3 },
            new int[] { 1, 2, 3, 4 }
        },
        new object[]
        {
            new int[] { -1, 5, 3, 4, 0 },
            new int[] { -1, 0, 3, 4, 5 }
        },
        new object[]
        {
            new int[] { 3, 1, 1, 3 },
            new int[] { 1, 1, 3, 3 }
        },
        new object[]
        {
            new int[] { 3, 3, 3, 1 },
            new int[] { 1, 3, 3, 3 }
        },
        new object[]
        {
            new int[] { },
            new int[] { }
        },
        new object[]
        {
            new int[] { 1 },
            new int[] { 1 }
        }
    };
}