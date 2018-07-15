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
    public class Solution38Tests
    {
        [Test()]
        public void CountAndSayTest()
        {
            Solution38 solution38 = new Solution38();
            string result = solution38.CountAndSay(1);

            Assert.AreEqual("1", result);
        }

        [TestCase(1, "1")]
        [TestCase(2, "11")]
        [TestCase(3, "21")]
        [TestCase(4, "1211")]
        [TestCase(5, "111221")]
        public void CountAndSayTest2(int param, string expected)
        {
            Solution38 solution38 = new Solution38();
            string result = solution38.CountAndSay(param);

            Assert.AreEqual(expected, result);
        }
    }
}