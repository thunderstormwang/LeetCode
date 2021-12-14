using FluentAssertions;
using LeetCode.Solution0201_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_9999
{
    [TestFixture]
    public class Solution0203Test
    {
        [TestCase(new int[] { 1, 2, 6, 3, 4, 5, 6 },
            6,
            new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { },
            1,
            new int[] { })]
        [TestCase(new int[] { 7, 7, 7, 7 },
            7,
            new int[] { })]
        [TestCase(new int[] { 1, 2, 3 },
            6,
            new int[] { 1, 2, 3 })]
        public void RemoveElements(int[] inputArray,
            int val,
            int[] expectedArray)
        {
            var solution = new Solution0203();

            var list = Utility.BuildListNode(inputArray);
            var actual = solution.RemoveElements(list,
                val);

            var expectedListNode = Utility.BuildListNode(expectedArray);
            Utility.CheckLinkedList(actual,
                expectedListNode).Should().BeTrue();
        }
    }
}