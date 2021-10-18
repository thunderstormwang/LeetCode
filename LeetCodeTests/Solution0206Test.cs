using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0206Test
    {
        [TestCase(new int[] { 1, 2, 3, 4, 5 },
            new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 1, 2 },
            new int[] { 2, 1 })]
        [TestCase(new int[] { },
            new int[] { })]
        public void ReverseList_NonRecursive(int[] inputArray,
            int[] expectedArray)
        {
            var solution = new Solution0206();

            var list = Utility.BuildListNode(inputArray);
            var actual = solution.ReverseList_NonRecursive(list);

            var expectedListNode = Utility.BuildListNode(expectedArray);
            Utility.CheckListNode(actual,
                expectedListNode).Should().BeTrue();
        }
        
        [TestCase(new int[] { 1, 2, 3, 4, 5 },
            new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 1, 2 },
            new int[] { 2, 1 })]
        [TestCase(new int[] { },
            new int[] { })]
        public void ReverseList_Recursive(int[] inputArray,
            int[] expectedArray)
        {
            var solution206 = new Solution0206();

            var list = Utility.BuildListNode(inputArray);
            var actual = solution206.ReverseList_Recursive(list);

            var expectedListNode = Utility.BuildListNode(expectedArray);
            Utility.CheckListNode(actual,
                expectedListNode).Should().BeTrue();
        }
    }
}