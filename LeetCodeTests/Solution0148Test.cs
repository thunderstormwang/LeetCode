using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0148Test
    {
        [TestCase(new int[] { 4, 2, 1, 3 },
            new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { -1, 5, 3, 4, 0 },
            new int[] { -1, 0, 3, 4, 5 })]
        [TestCase(new int[] { 3, 1, 1, 3 },
            new int[] { 1, 1, 3, 3 })]
        [TestCase(new int[] { 3, 3, 3, 1 },
            new int[] { 1, 3, 3, 3 })]
        [TestCase(new int[] { },
            new int[] { })]
        [TestCase(new int[] { 666 },
            new int[] { 666 })]
        public void SortList(int[] input,
            int[] expected)
        {
            var solution = new Solution148();

            var list = Utility.BuildListNode(input);
            var actual = solution.SortList(list);

            var expectedListNode = Utility.BuildListNode(expected);
            Assert.AreEqual(Utility.CheckLinkedList(actual,
                    expectedListNode),
                true);
        }
    }
}