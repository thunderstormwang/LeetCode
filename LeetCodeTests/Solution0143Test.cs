using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0143Test
    {
        [TestCase(new int[] { 1 },
            new int[] { 1 })]
        [TestCase(new int[] { 1, 2 },
            new int[] { 1, 2 })]
        [TestCase(new int[] { 1, 2, 3 },
            new int[] { 1, 3, 2 })]
        [TestCase(new int[] { 1, 2, 3, 4 },
            new int[] { 1, 4, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 },
            new int[] { 1, 5, 2, 4, 3 })]
        public void ReorderListTest(int[] inputArray,
            int[] expectedArray)
        {
            var solution = new Solution0143();
            var list = Utility.BuildListNode(inputArray);

            solution.ReorderList(list);
            var expected = Utility.BuildListNode(expectedArray);

            Utility.CheckListNode(list,
                expected).Should().BeTrue();
        }
    }
}