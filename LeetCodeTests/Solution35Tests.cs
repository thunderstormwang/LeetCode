using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class Solution35Tests
    {
        [TestCase(new int[] { 1, 3, 5, 6 }, 5, 2)]
        [TestCase(new int[] { 1, 3, 5, 6 }, 2, 1)]
        [TestCase(new int[] { 1, 3, 5, 6 }, 7, 4)]
        [TestCase(new int[] { 1, 3, 5, 6 }, 0, 0)]
        public void SearchInsertTest(int[] array, int val, int expected)
        {
            Solution35 solution35 = new Solution35();

            int actual = solution35.SearchInsert(array, val);

            Assert.AreEqual(expected, actual);
        }
    }
}