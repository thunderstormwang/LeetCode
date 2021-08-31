using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution019Test
    {
        [TestCase(new int[] { 1, 2, 3, 4, 5 },
            2,
            new int[] { 1, 2, 3, 5 })]
        [TestCase(new int[] { 1 },
            1,
            new int[] {})]
        [TestCase(new int[] { 1, 2 },
            1,
            new int[] {1})]
        public void ThreeSumClosestTest(int[] input,
            int n,
            int[] expected)
        {
            var solution019 = new Solution019();

            var list = Utility.BuildListNode(input);
            var actual = solution019.RemoveNthFromEnd(list,
                n);

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