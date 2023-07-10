using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
[Category("SolutionTest0001_0050")]
public class Solution0019Test
{
    [TestCaseSource(nameof(TestCases))]
    public void RemoveNthFromEnd_Ver1Test(int[] input, int n, int[] expected)
    {
        var list = Utility.BuildListNode(input);
        var expectedListNode = Utility.BuildListNode(expected);

        var solution = new Solution0019();
        var actual = solution.RemoveNthFromEnd_Ver1(list, n);

        Utility.CheckLinkedList(actual, expectedListNode).Should().BeTrue();
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void RemoveNthFromEnd_Ver2Test(int[] input, int n, int[] expected)
    {
        var list = Utility.BuildListNode(input);
        var expectedListNode = Utility.BuildListNode(expected);

        var solution = new Solution0019();
        var actual = solution.RemoveNthFromEnd_Ver2(list, n);

        Utility.CheckLinkedList(actual, expectedListNode).Should().BeTrue();
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 2, 3, 4, 5 },
            1,
            new int[] { 1, 2, 3, 4 }
        },
        new object[]
        {
            new int[] { 1, 2, 3, 4, 5 },
            2,
            new int[] { 1, 2, 3, 5 }
        },
        new object[]
        {
            new int[] { 1, 2, 3, 4, 5 },
            3,
            new int[] { 1, 2, 4, 5 }
        },
        new object[]
        {
            new int[] { 1, 2, 3, 4, 5 },
            4,
            new int[] { 1, 3, 4, 5 }
        },
        new object[]
        {
            new int[] { 1, 2, 3, 4, 5 },
            5,
            new int[] { 2, 3, 4, 5 }
        },
        new object[]
        {
            new int[] { 1 },
            1,
            new int[] { }
        },
        new object[]
        {
            new int[] { 1, 2 },
            1,
            new int[] { 1 }
        },
    };
}