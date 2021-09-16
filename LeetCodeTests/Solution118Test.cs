﻿using NUnit.Framework;
using System.Collections.Generic;
using LeetCode;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution118Test
    {
        [Test()]
        public void GenerateTest()
        {
            var solution118 = new Solution118();
            var actual = solution118.Generate(5);

            Assert.AreEqual(new int[] { 1 }, actual[0]);
            Assert.AreEqual(new int[] { 1, 1 }, actual[1]);
            Assert.AreEqual(new int[] { 1, 2, 1 }, actual[2]);
            Assert.AreEqual(new int[] { 1, 3, 3, 1 }, actual[3]);
            Assert.AreEqual(new int[] { 1, 4, 6, 4, 1 }, actual[4]);
        }
    }
}