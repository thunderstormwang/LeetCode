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
    [TestFixture]
    public class Solution0110Test
    {
        [TestCase("3, 9, 20, null, null, 15, 7", true)]
        [TestCase("1, 2, 2, 3, 3, null, null, 4, 4", false)]
        public void IsBalancedTest(string array, bool expected)
        {
            var root = new TreeNode(0);
            root = Utility.BuildTree(root, Utility.Parse2Array(array), 0);

            var solution = new Solution0110();
            var actual = solution.IsBalanced(root);

            actual.Should().Be(expected);
        }
    }
}