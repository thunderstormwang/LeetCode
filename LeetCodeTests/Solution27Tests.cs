using NUnit.Framework;
using System.Collections.Generic;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class Solution27Tests
    {
        [TestCase(new int[] { 3, 2, 2, 3 }, 3, new int[] { 2, 2 }, 2)]
        [TestCase(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new int[] { 0, 1, 3, 0, 4 }, 5)]
        [TestCase(new int[] { 4, 4 }, 4, new int[] { }, 0)]
        public void RemoveElementTest(int[] array, int val, int[] expectedArray, int expected)
        {
            Solution27 solution27 = new Solution27();
            int result = solution27.RemoveElement(array, val);
            Assert.AreEqual(expected, result);

            int[] actualArray = new int[result];
            for (int i = 0; i < result; i++)
            {
                actualArray[i] = array[i];
            }
            CollectionAssert.AreEquivalent(expectedArray, actualArray);
        }
    }
}