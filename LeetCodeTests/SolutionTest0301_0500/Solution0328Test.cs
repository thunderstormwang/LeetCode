using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500;

[TestFixture]
[Category("SolutionTest0301_0500")]
public class Solution0328Test
{
    [TestCaseSource(nameof(TestCases))]
    public void CombinationSum4_Ver3Test(int[] array, int[] expectedArray)
    {
        var list = Utility.BuildListNode(array);
        var expectedList = Utility.BuildListNode(expectedArray);

        var solution = new Solution0328();
        var actual = solution.OddEvenList(list);

        Utility.CheckLinkedList(actual, expectedList).Should().BeTrue();
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 2, 3, 4, 5 },
            new int[] { 1, 3, 5, 2, 4 }
        },
        new object[]
        {
            new int[] { 2, 1, 3, 5, 6, 4, 7 },
            new int[] { 2, 3, 6, 7, 1, 5, 4 }
        },
        new object[]
        {
            new int[] { 1 },
            new int[] { 1 }
        },
        new object[]
        {
            new int[] { 1, 2 },
            new int[] { 1, 2 }
        }
    };
}