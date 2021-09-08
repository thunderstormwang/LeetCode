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
            Assert.AreEqual(CheckListNode(actual,
                    expectedListNode),
                true);
        }

        private bool CheckListNode(ListNode list1,
            ListNode list2)
        {
            while (list1 != null || list2 != null)
            {
                var x = list1 != null ? list1.val : -99;
                var y = list2 != null ? list2.val : -99;

                if (x != y)
                {
                    return false;
                }

                list1 = list1 != null ? list1.next : list1;
                list2 = list2 != null ? list2.next : list2;
            }

            return true;
        }
    }
}