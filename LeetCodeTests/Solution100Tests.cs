using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class Solution100Tests
    {
        [Test()]
        public void IsSymmetricTest_ExpectedTrue()
        {
            TreeNode root1 = new TreeNode(0);
            root1 = Utility.BuildTree(root1, new int?[] { 1, 2, 3 }, 0);

            TreeNode root2 = new TreeNode(0); ;
            root2 = Utility.BuildTree(root2, new int?[] { 1, 2, 3 }, 0);

            Solution100 solution100 = new Solution100();
            bool actual = solution100.IsSameTree(root1, root2);

            Assert.AreEqual(true, actual);
        }

        [Test()]
        public void IsSymmetricTest_ExpectedFalse()
        {
            TreeNode root1 = new TreeNode(0);
            root1 = Utility.BuildTree(root1, new int?[] { 1, 2 }, 0);

            TreeNode root2 = new TreeNode(0); ;
            root2 = Utility.BuildTree(root2, new int?[] { 1, null, 2 }, 0);

            Solution100 solution100 = new Solution100();
            bool actual = solution100.IsSameTree(root1, root2);

            Assert.AreEqual(false, actual);
        }

        [Test()]
        public void IsSymmetricTest_ExpectedFalse2()
        {
            TreeNode root1 = new TreeNode(0);
            root1 = Utility.BuildTree(root1, new int?[] { 1, 2,1 }, 0);

            TreeNode root2 = new TreeNode(0); ;
            root2 = Utility.BuildTree(root2, new int?[] { 1, 1, 2 }, 0);

            Solution100 solution100 = new Solution100();
            bool actual = solution100.IsSameTree(root1, root2);

            Assert.AreEqual(false, actual);
        }
    }
}