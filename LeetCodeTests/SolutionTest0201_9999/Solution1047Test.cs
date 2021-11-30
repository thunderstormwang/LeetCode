using FluentAssertions;
using LeetCode.Solution0201_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_9999
{
    [TestFixture]
    public class Solution1047Test
    {
        [TestCase("abbaca",
            "ca")]
        [TestCase("azxxzy",
            "ay")]
        [TestCase("aababaab",
            "ba")]
        [TestCase("abbbaca",
            "abaca")]
        [TestCase("aaaaaaaaa",
            "a")]
        public void RemoveDuplicates(string s,
            string expected)
        {
            var solution = new Solution1047();
            var actual = solution.RemoveDuplicates(s);

            actual.Should().Be(expected);
        }
    }
}