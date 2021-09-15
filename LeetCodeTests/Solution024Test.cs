using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution024Test
    {
        [TestCase(new int[] { 1, 2, 3, 4 },
            new int[] { 2, 1, 4, 3 })]
        [TestCase(new int[] { 1, 2, 3 },
            new int[] { 2, 1, 3 })]
        [TestCase(new int[] { 1, 2 },
            new int[] { 2, 1 })]
        [TestCase(new int[] { 1 },
            new int[] { 1 })]
        [TestCase(new int[] { },
            new int[] { })]
        public void SwapPairsTest(int[] input,
            int[] expected)
        {
            var solution024 = new Solution024();

            var list = Utility.BuildListNode(input);
            var actual = solution024.SwapPairs(list);

            var expectedListNode = Utility.BuildListNode(expected);
            Assert.AreEqual(Utility.CheckListNode(actual,
                    expectedListNode),
                true);
        }
    }
}