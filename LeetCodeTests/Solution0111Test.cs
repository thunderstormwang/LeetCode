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
    [TestFixture]
    public class Solution0111Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void MinDepthTest(int?[] array, int expected)
        {
            var root = Utility.BuildTree(array, 0);

            var solution = new Solution0111();
            var actual = solution.MinDepth(root);

            actual.Should().Be(expected);
        }
        
        private static readonly object[] TestCases =
        {
            new object[]
            {
                new int?[] { 3, 9, 20, null, null, 15, 7 },
                2
            }
        };
    }
}