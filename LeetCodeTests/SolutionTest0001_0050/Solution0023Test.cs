using FluentAssertions;
using LeetCode.Models;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
[Category("SolutionTest0001_0050")]
public class Solution0023Test
{
    [TestCaseSource(nameof(TestCases))]
    public void MergeKLists_Ver1Test(int[][] array, int[] expectedArray)
    {
        var lists = new ListNode[array.Length];
        for (var i = 0; i < array.Length; i++)
        {
            lists[i] = Utility.BuildListNode(array[i]);
        }

        var expectedList = Utility.BuildListNode(expectedArray);

        var solution = new Solution0023();
        var actual = solution.MergeKLists_Ver1(lists);

        Utility.CheckLinkedList(actual, expectedList).Should().BeTrue();
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void MergeKLists_Ver2Test(int[][] array, int[] expectedArray)
    {
        var lists = new ListNode[array.Length];
        for (var i = 0; i < array.Length; i++)
        {
            lists[i] = Utility.BuildListNode(array[i]);
        }

        var expectedList = Utility.BuildListNode(expectedArray);

        var solution = new Solution0023();
        var actual = solution.MergeKLists_Ver2(lists);

        Utility.CheckLinkedList(actual, expectedList).Should().BeTrue();
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[][]
            {
                new int[] { 1, 4, 5 },
                new int[] { 1, 3, 4 },
                new int[] { 2, 6 }
            },
            new int[] { 1, 1, 2, 3, 4, 4, 5, 6 },
        },
        new object[]
        {
            new int[][]
            {
            },
            new int[] { },
        },
        new object[]
        {
            new int[][]
            {
                new int[] { },
            },
            new int[] { },
        },
    };
}