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
    public class Solution122Tests
    {
        [TestCase(new int[] { 7, 1, 5, 3, 6, 4 }, 7)]
        [TestCase(new int[] { 1, 2, 3,4, 5 }, 4)]
        [TestCase(new int[] { 7,6,4,3,1 }, 0)]
        public void MaxProfitTest(int[] array, int expected)
        {
            Solution122 solution122 = new Solution122();

            int actual = solution122.MaxProfit(array);

            Assert.AreEqual(actual, expected);
        }
    }
}