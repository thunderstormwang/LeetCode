using System;
using FluentAssertions;
using LeetCode.Solution0000_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0000_0050
{
    [TestFixture]
    public class Solution0027Test
    {
        [TestCase(new int[] { 3, 2, 2, 3 },
            3,
            2,
            new int[] { 2, 2 })]
        [TestCase(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 },
            2,
            5,
            new int[] { 0, 1, 3, 0, 4 })]
        [TestCase(new int[] { 4, 4 },
            4,
            0,
            new int[] { })]
        public void RemoveElementTest(int[] array,
            int val,
            int expectedLength,
            int[] expectedArray)
        {
            var solution = new Solution0027();
            var result = solution.RemoveElement(array,
                val);

            Assert.AreEqual(expectedLength,
                result);

            // 陣列內的順序不重要, 只要內容, 數量一致就可
            var actualArray = new int[result];
            Array.Copy(array,
                actualArray,
                result);
            result.Should().Be(expectedLength);
            actualArray.Should().BeEquivalentTo(expectedArray);
        }
    }
}