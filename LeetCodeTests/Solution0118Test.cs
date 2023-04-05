using NUnit.Framework;
using System.Collections.Generic;
using LeetCode;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0118Test
    {
        [Test()]
        public void GenerateTest()
        {
            var solution = new Solution0118();
            var actual = solution.Generate(5);

            Assert.That(actual[0], Is.EqualTo(new int[] { 1 }));
            Assert.That(actual[1], Is.EqualTo(new int[] { 1, 1 }));
            Assert.That(actual[2], Is.EqualTo(new int[] { 1, 2, 1 }));
            Assert.That(actual[3], Is.EqualTo(new int[] { 1, 3, 3, 1 }));
            Assert.That(actual[4], Is.EqualTo(new int[] { 1, 4, 6, 4, 1 }));
        }
    }
}