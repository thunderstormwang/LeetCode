using FluentAssertions;
using LeetCode;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050
{
    [TestFixture]
    [Category("SolutionTest0001_0050")]
    public class Solution0028Test
    {
        [TestCase("hello", "ll", 2)]
        [TestCase("aaaaa", "bba", -1)]
        [TestCase("", "", 0)]
        [TestCase("abc", "", 0)]
        [TestCase("abc", "abcdefghijklkmn", -1)]
        public void StrStr(string haystack, string needle, int expected)
        {
            var solution = new Solution0028();

            var actual = solution.StrStr(haystack, needle);

            actual.Should().Be(expected);
        }
    }
}