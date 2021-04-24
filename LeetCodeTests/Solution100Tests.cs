using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using LeetCode;

namespace LeetCodeTests
{
    [TestFixture()]
    public class Solution100Tests
    {
        [TestCase( "1, 2, 3", "1, 2, 3", true)]
        [TestCase("1, 2", "1, null ,2", false)]
        [TestCase("1, 2, 1", "1, 1 ,2", false)]
        public void IsSymmetricTest(string array1, string array2, bool expected)
        {
            TreeNode root1 = new TreeNode(0);
            root1 = Utility.BuildTree(root1, Utility.Parse2Array(array1), 0);

            TreeNode root2 = new TreeNode(0);
            root2 = Utility.BuildTree(root2, Utility.Parse2Array(array2), 0);

            Solution100 solution100 = new Solution100();
            bool actual = solution100.IsSameTree(root1, root2);

            actual.Should().Be(expected);
        }
    }
}