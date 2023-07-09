using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0206Test
{
    [TestCaseSource(nameof(TestCases))]
    public void ReverseList_Ver1Test(int[] inputArray, int[] expectedArray)
    {
        var list = Utility.BuildListNode(inputArray);
        var expectedListNode = Utility.BuildListNode(expectedArray);
        
        var solution = new Solution0206();
        var actual = solution.ReverseList_Ver1(list);

        Utility.CheckLinkedList(actual, expectedListNode).Should().BeTrue();
    }

    [TestCaseSource(nameof(TestCases))]
    public void ReverseList_Ver2Test(int[] inputArray, int[] expectedArray)
    {
        var list = Utility.BuildListNode(inputArray);
        var expectedListNode = Utility.BuildListNode(expectedArray);
        
        var solution206 = new Solution0206();
        var actual = solution206.ReverseList_Ver2(list);

        Utility.CheckLinkedList(actual, expectedListNode).Should().BeTrue();
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void ReverseList_Ver3(int[] inputArray, int[] expectedArray)
    {
        var list = Utility.BuildListNode(inputArray);
        var expectedListNode = Utility.BuildListNode(expectedArray);
        
        var solution206 = new Solution0206();
        var actual = solution206.ReverseList_Ver3(list);

        Utility.CheckLinkedList(actual, expectedListNode).Should().BeTrue();
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 2, 3, 4, 5 },
            new int[] { 5, 4, 3, 2, 1 },
        },
        new object[]
        {
            new int[] { 1, 2 },
            new int[] { 2, 1 },
        },
        new object[]
        {
            new int[] { },
            new int[] { },
        }
    };
}