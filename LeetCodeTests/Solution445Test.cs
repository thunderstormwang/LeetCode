using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution445Test
    {
        [TestCase(new int[] { 7, 2, 4, 3 },
            new int[] { 5, 6, 4 },
            new int[] { 7, 8, 0, 7 })]
        [TestCase(new int[] { 0 },
            new int[] { 0 },
            new int[] { 0 })]
        [TestCase(new int[] { 5, 0 },
            new int[] { 6, 0 },
            new int[] { 1, 1, 0 })]
        [TestCase(new int[] { 9, 9, 9 },
            new int[] { 1 },
            new int[] { 1, 0, 0, 0 })]
        public void AddTwoNumbersTest(int[] array1,
            int[] array2,
            int[] expectedArray)
        {
            var solution445 = new Solution445();
            var list1 = Utility.BuildListNode(array1);
            var list2 = Utility.BuildListNode(array2);

            var actual = solution445.AddTwoNumbers(list1,
                list2);
            var expected = Utility.BuildListNode(expectedArray);

            Assert.AreEqual(Utility.CheckListNode(actual,
                    expected),
                true);
        }
    }
}