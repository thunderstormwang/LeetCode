using LeetCode.Solution0000_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0000_0050
{
    [TestFixture]
    public class Solution0001Test
    {
        [TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 } )]
        [TestCase(new int[] { 3,2, 4 }, 6, new int[] { 1, 2 } )]
        [TestCase(new int[] { 3,3 }, 6, new int[] { 0, 1 } )]
        public void RemoveElementTest(int[] nums, int target, int[] expectedArray)
        {
            var solution = new Solution0001();
            var result = solution.TwoSum(nums, target);

            Assert.AreEqual(expectedArray, result);
        }
    }
}