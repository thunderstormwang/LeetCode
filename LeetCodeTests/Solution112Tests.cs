using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class Solution112Tests
    {
        [Test()]
        public void HasPathSumTest()
        {
            TreeNode root = new TreeNode(0);
            root = Utility.BuildTree(root, new int?[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1 }, 0);

            Solution112 solution112 = new Solution112();
            bool actual = solution112.HasPathSum(root, 22);

            Assert.AreEqual(true, actual);
        }
    }
}