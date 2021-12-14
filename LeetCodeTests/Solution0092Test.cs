using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0092Test
    {
        [TestCase(new int[] { 1, 2, 3, 4, 5 },
            2,
            4,
            new int[] { 1, 4, 3, 2, 5 })]
        [TestCase(new int[] { 1, 2 },
            1,
            2,
            new int[]
            {
                2, 1
            })]
        [TestCase(new int[] { 5 },
            1,
            1,
            new int[]
            {
                5
            })]
        public void ReverseBetween(int[] inputArray,
            int left,
            int right,
            int[] expectedArray)
        {
            var solution = new Solution0092();

            var list = Utility.BuildListNode(inputArray);
            var actual = solution.ReverseBetween(list,
                left,
                right);

            var expectedListNode = Utility.BuildListNode(expectedArray);
            Utility.CheckLinkedList(actual,
                expectedListNode).Should().BeTrue();
        }
    }
}