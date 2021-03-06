﻿using NUnit.Framework;
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
    public class Solution111Tests
    {
        [TestCase("3, 9, 20, null, null, 15, 7", 2)]
        public void MinDepthTest(string array, int expected)
        {
            TreeNode root = new TreeNode(0);
            root = Utility.BuildTree(root, Utility.Parse2Array(array), 0);

            Solution111 solution111 = new Solution111();
            int actual = solution111.MinDepth(root);

            actual.Should().Be(expected);
        }
    }
}