using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
[Category("SolutionTest0001_0050")]
public class Solution0025Test
{
    [TestCaseSource(nameof(TestCases))]
    public void IsValidSudoku_Ver2Test(int[] inputArray1, int k, int[] expectedArray)
    {
        var list1 = Utility.BuildListNode(inputArray1);
        var expectedList = Utility.BuildListNode(expectedArray);

        var solution = new Solution0025();
        var actual = solution.ReverseKGroup(list1, k);

        Utility.CheckLinkedList(actual, expectedList).Should().BeTrue();
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 2, 3, 4, 5 },
            2,
            new int[] { 2, 1, 4, 3, 5 }
        },
        new object[]
        {
            new int[] { 1, 2, 3, 4, 5 },
            3,
            new int[] { 3, 2, 1, 4, 5 }
        }
    };
}