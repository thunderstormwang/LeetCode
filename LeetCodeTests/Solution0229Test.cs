using System.Collections.Generic;
using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0229Test
    {
        [TestCase(new int[] { 1 },
            new int[] { 1 })]
        [TestCase(new int[] { 1, 2 },
            new int[] { 1, 2 })]
        [TestCase(new int[] { 3, 2, 3 },
            new int[] { 3 })]
        [TestCase(new int[] { 0, 0, 0 },
            new int[] { 0 })]
        public void MajorityElementTest(int[] inputArray,
            int[] expectedArray)
        {
            var solution = new Solution0229();

            var actual = solution.MajorityElement(inputArray);

            actual.Should().BeEquivalentTo(new List<int>(expectedArray));
        }
    }
}