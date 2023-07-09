using FluentAssertions;
using LeetCode.Solution0201_0300;
using LeetCode.Solution0701_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0701_9999;

[TestFixture]
[Category("SolutionTest0701_9999")]
public class Solution0876Test
{
    [TestCaseSource(nameof(TestCases))]
    public void MiddleNode_Ver1Test(int[] inputArray, int [] expectedArray)
    {
        var list = Utility.BuildListNode(inputArray);
        var expectedList = Utility.BuildListNode(expectedArray);

        var solution = new Solution0876();
        var actual = solution.MiddleNode_Ver1(list);

        Utility.CheckLinkedList(actual, expectedList).Should().BeTrue();
    }

    [TestCaseSource(nameof(TestCases))]
    public void MiddleNode_Ver2Test(int[] inputArray, int[] expectedArray)
    {
        var list = Utility.BuildListNode(inputArray);
        var expectedList = Utility.BuildListNode(expectedArray);

        var solution = new Solution0876();
        var actual = solution.MiddleNode_Ver2(list);

        Utility.CheckLinkedList(actual, expectedList).Should().BeTrue();
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 2, 3, 4, 5 },
            new int[] { 3, 4, 5 }
        },
        new object[]
        {
            new int[] { 1, 2, 3, 4, 5, 6 },
            new int[] { 4, 5, 6 }
        }
    };
}