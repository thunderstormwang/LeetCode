using NUnit.Framework;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace LeetCodeTests
{
    [TestFixture()]
    public class Solution104Tests
    {
        [TestCase("3, 9, 20, null, null, 15, 7", 3)]
        public void MaxDepthTest(string array, int expected)
        {
            TreeNode root = new TreeNode(0);
            root = Utility.BuildTree(root, Utility.Parse2Array(array), 0);

            Solution104 solution104 = new Solution104();
            int actual = solution104.MaxDepth(root);

            actual.Should().Be(expected);
        }
    }
}