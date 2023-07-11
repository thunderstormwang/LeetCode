using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
[Category("SolutionTest0001_0050")]
public class Solution0002Test
{
    [TestCaseSource(nameof(TestCases))]
    public void AddTwoNumbers_Ver1Test(int[] array1, int[] array2, int[] expectedArray)
    {
        var list1 = Utility.BuildListNode(array1);
        var list2 = Utility.BuildListNode(array2);
        var expected = Utility.BuildListNode(expectedArray);

        var solution = new Solution0002();
        var actual = solution.AddTwoNumbers_Ver1(list1, list2);

        Utility.CheckLinkedList(actual, expected).Should().BeTrue();
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void AddTwoNumbers_Ver2Test(int[] array1, int[] array2, int[] expectedArray)
    {
        var list1 = Utility.BuildListNode(array1);
        var list2 = Utility.BuildListNode(array2);
        var expected = Utility.BuildListNode(expectedArray);

        var solution = new Solution0002();
        var actual = solution.AddTwoNumbers_Ver2(list1, list2);

        Utility.CheckLinkedList(actual, expected).Should().BeTrue();
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8 }
        },
        new object[]
        {
            new int[] { 0 }, new int[] { 0 }, new int[] { 0 }
        },
        new object[]
        {
            new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9 }, new int[] { 8, 9, 9, 9, 0, 0, 0, 1 }
        }
    };
}