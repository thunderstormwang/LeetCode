using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution027Tests
    {
        [TestCase(new int[] { 3, 2, 2, 3 }, 3, new int[] { 2, 2 }, 2)]
        [TestCase(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new int[] { 0, 1, 3, 0, 4 }, 5)]
        [TestCase(new int[] { 4, 4 }, 4, new int[] { }, 0)]
        public void RemoveElementTest(int[] array, int val, int[] expectedArray, int expected)
        {
            Solution027 solution027 = new Solution027();
            int result = solution027.RemoveElement(array, val);

            Assert.AreEqual(expected, result);

            // 陣列內的順序不重要, 只要內容, 數量一致就可
            int[] actualArray = new int[result];
            for (int i = 0; i < result; i++)
            {
                actualArray[i] = array[i];
            }
            CollectionAssert.AreEquivalent(expectedArray, actualArray);
        }
    }
}