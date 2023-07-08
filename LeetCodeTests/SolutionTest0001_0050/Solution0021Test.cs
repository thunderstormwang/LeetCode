using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
[Category("SolutionTest0001_0050")]
public class Solution0021Test
{
    [TestCaseSource(nameof(TestCases))]
    public void IsValidSudoku_Ver1Test(int[] inputArray1, int [] inputArray2, int [] expectedArray)
    {
        var list1 = Utility.BuildListNode(inputArray1);
        var list2 = Utility.BuildListNode(inputArray2);
        var expectedList = Utility.BuildListNode(expectedArray);
        
        var solution = new Solution0021();
        var actual = solution.MergeTwoLists_Ver1(list1, list2);

        Utility.CheckLinkedList(actual, expectedList).Should().BeTrue();
    }

    [TestCaseSource(nameof(TestCases))]
    public void IsValidSudoku_Ver2Test(int[] inputArray1, int [] inputArray2, int [] expectedArray)
    {
        var list1 = Utility.BuildListNode(inputArray1);
        var list2 = Utility.BuildListNode(inputArray2);
        var expectedList = Utility.BuildListNode(expectedArray);
        
        var solution = new Solution0021();
        var actual = solution.MergeTwoLists_Ver2(list1, list2);

        Utility.CheckLinkedList(actual, expectedList).Should().BeTrue();
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 2, 4 },
            new int[] { 1, 3, 4 },
            new int[] { 1, 1, 2, 3, 4, 4 },
        },
        new object[]
        {
            new int[] {  },
            new int[] {  },
            new int[] {  },
        },
        new object[]
        {
            new int[] {  },
            new int[] { 0 },
            new int[] { 0 },
        }
    };
}