using FluentAssertions;
using LeetCode.Solution0101_0150;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0150;

[TestFixture]
[Category("SolutionTest0101_0150")]
public class Solution0143Test
{
    [TestCase(new int[] { 1 }, new int[] { 1 })]
    [TestCase(new int[] { 1, 2 }, new int[] { 1, 2 })]
    [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 3, 2 })]
    [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 4, 2, 3 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 5, 2, 4, 3 })]
    public void ReorderListTest(int[] inputArray, int[] expectedArray)
    {
        var list = Utility.BuildListNode(inputArray);
        var expected = Utility.BuildListNode(expectedArray);

        var solution = new Solution0143();
        solution.ReorderList(list);

        Utility.CheckLinkedList(list, expected).Should().BeTrue();
    }
}