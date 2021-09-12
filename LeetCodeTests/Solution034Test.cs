using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution034Test
    {
        [TestCase(new int[] { 5, 7, 7, 8, 8, 10 },
            8,
            new int[] { 3, 4 })]
        [TestCase(new int[] { 5, 7, 7, 8, 8, 10 },
            6,
            new int[] { -1, -1 })]
        [TestCase(new int[] { 1 },
            1,
            new int[] { 0, 0 })]
        [TestCase(new int[] { },
            0,
            new int[] { -1, -1 })]
        public void SearchRange_RecursiveTest(int[] array,
            int val,
            int[] expected)
        {
            var solution034 = new Solution034();
            var actual = solution034.SearchRange_Recursive(array,
                val);

            actual.Should().BeEquivalentTo(expected);
        }

        [TestCase(new int[] { 5, 7, 7, 8, 8, 10 },
            8,
            new int[] { 3, 4 })]
        [TestCase(new int[] { 5, 7, 7, 8, 8, 10 },
            6,
            new int[] { -1, -1 })]
        [TestCase(new int[] { 1 },
            1,
            new int[] { 0, 0 })]
        [TestCase(new int[] { },
            0,
            new int[] { -1, -1 })]
        public void SearchRange_NonRecursiveTest(int[] array,
            int val,
            int[] expected)
        {
            var solution034 = new Solution034();
            var actual = solution034.SearchRange_NonRecursive(array,
                val);

            actual.Should().BeEquivalentTo(expected);
        }
    }
}