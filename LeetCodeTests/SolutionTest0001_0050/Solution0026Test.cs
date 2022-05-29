using System;
using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050
{
    [TestFixture]
    public class Solution0026Test
    {
        [TestCase(new int[] { 1, 1, 2 }, 2, new int[] { 1, 2 })]
        [TestCase(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5, new int[] { 0, 1, 2, 3, 4 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4 }, 5, new int[] { 0, 1, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 2, 2 }, 2, new int[] { 1, 2 })]
        [TestCase(new int[] { 99 }, 1, new int[] { 99 })]
        [TestCase(new int[] { }, 0, new int[] { })]
        public void RemoveDuplicates(int[] nums, int expectedLength, int[] expectedArray)
        {
            var solution = new Solution0026();

            var actualLength = solution.RemoveDuplicates(nums);
            var actualArray = new int [actualLength];
            Array.Copy(nums, actualArray, actualLength);

            actualArray.Should().Equal(expectedArray);
        }
        
        [TestCase(new int[] { 1, 1, 2 }, 2, new int[] { 1, 2 })]
        [TestCase(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5, new int[] { 0, 1, 2, 3, 4 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4 }, 5, new int[] { 0, 1, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 2, 2 }, 2, new int[] { 1, 2 })]
        [TestCase(new int[] { 99 }, 1, new int[] { 99 })]
        [TestCase(new int[] { }, 0, new int[] { })]
        public void RemoveDuplicates_Official(int[] nums, int expectedLength, int[] expectedArray)
        {
            var solution = new Solution0026();

            var actualLength = solution.RemoveDuplicates_Official(nums);
            var actualArray = new int [actualLength];
            Array.Copy(nums, actualArray, actualLength);

            actualArray.Should().Equal(expectedArray);
        }
    }
}