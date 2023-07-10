using FluentAssertions;
using LeetCode.Solution0051_0100;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0051_0100;

[TestFixture]
[Category("SolutionTest0051_0100")]
public class Solution0061Test
{
    [TestCaseSource(nameof(TestCases))]
    public void RotateRight_Ver1Test(int[] input, int n, int[] expected)
    {
        var list = Utility.BuildListNode(input);
        var expectedListNode = Utility.BuildListNode(expected);

        var solution = new Solution0061();
        var actual = solution.RotateRight_Ver1(list, n);

        Utility.CheckLinkedList(actual, expectedListNode).Should().BeTrue();
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void RotateRight_Ver2Test(int[] input, int n, int[] expected)
    {
        var list = Utility.BuildListNode(input);
        var expectedListNode = Utility.BuildListNode(expected);

        var solution = new Solution0061();
        var actual = solution.RotateRight_Ver2(list, n);

        Utility.CheckLinkedList(actual, expectedListNode).Should().BeTrue();
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 0, 1, 2 },
            0,
            new int[] { 0, 1, 2 }
        },
        new object[]
        {
            new int[] { 0, 1, 2 },
            1,
            new int[] { 2, 0, 1 }
        },
        new object[]
        {
            new int[] { 0, 1, 2 },
            2,
            new int[] { 1, 2, 0 }
        },
        new object[]
        {
            new int[] { 0, 1, 2 },
            3,
            new int[] { 0, 1, 2 }
        },
        new object[]
        {
            new int[] { 0, 1, 2 },
            4,
            new int[] { 2, 0, 1 }
        },
        new object[]
        {
            new int[] { 0, 1, 2 },
            5,
            new int[] { 1, 2, 0 }
        },
        new object[]
        {
            new int[] { 0, 1, 2 },
            6,
            new int[] { 0, 1, 2 }
        },
        new object[]
        {
            new int[] { 1, 2, 3, 4, 5 },
            2,
            new int[] { 4, 5, 1, 2, 3 }
        }
    };
}