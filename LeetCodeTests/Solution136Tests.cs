using NUnit.Framework;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    [TestFixture()]
    public class Solution136Tests
    {
        [TestCase(new int[] { 2,2,1}, 1)]
        [TestCase(new int[] { 4,1,2,1,2 }, 4)]
        public void SingleNumberTest(int [] input, int expected)
        {
            Solution136 solution136 = new Solution136();
            int actual = solution136.SingleNumber(input);

            Assert.AreEqual(expected, actual);
        }
    }
}