using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0061Test
    {
        [TestCase(new int[] { 0, 1, 2 },
            0,
            new int[] { 0, 1, 2 })]
        [TestCase(new int[] { 0, 1, 2 },
            1,
            new int[] { 2, 0, 1 })]
        [TestCase(new int[] { 0, 1, 2 },
            2,
            new int[] { 1, 2, 0 })]
        [TestCase(new int[] { 0, 1, 2 },
            3,
            new int[] { 0, 1, 2 })]
        [TestCase(new int[] { 0, 1, 2 },
            4,
            new int[] { 2, 0, 1 })]
        [TestCase(new int[] { 0, 1, 2 },
            5,
            new int[] { 1, 2, 0 })]
        [TestCase(new int[] { 0, 1, 2 },
            6,
            new int[] { 0, 1, 2 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 },
            2,
            new int[] { 4, 5, 1, 2, 3 })]
        public void RotateRightTest(int[] input,
            int n,
            int[] expected)
        {
            var solution = new Solution0061();

            var list = Utility.BuildListNode(input);
            var actual = solution.RotateRight(list,
                n);

            var expectedListNode = Utility.BuildListNode(expected);
            Assert.AreEqual(Utility.CheckListNode(actual,
                    expectedListNode),
                true);
        }
    }
}