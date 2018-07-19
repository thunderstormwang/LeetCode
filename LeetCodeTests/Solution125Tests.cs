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
    public class Solution125Tests
    {
        [TestCase("A man, a plan, a canal: Panama", true)]
        [TestCase("race a car", false)]
        public void IsPalindromeTest(string s, bool expected)
        {
            Solution125 solution125 = new Solution125();
            bool actual = solution125.IsPalindrome(s);

            Assert.AreEqual(expected, actual);
        }
    }
}