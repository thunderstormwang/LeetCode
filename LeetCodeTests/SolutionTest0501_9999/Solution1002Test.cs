using FluentAssertions;
using LeetCode.Solution0501_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_9999
{
    [TestFixture]
    public class Solution1002Test
    {
        [TestCase(new string[] { "bella", "label", "roller" },
            new string[] { "e", "l", "l" })]
        [TestCase(new string[] { "cool", "lock", "cook" },
            new string[] { "c", "o" })]
        [TestCase(new string[] { "abc", "def", "ghi" },
            new string[] { })]
        public void CommonChars_Version1(string[] words,
            string[] expected)
        {
            var solution = new Solution1002();
            var actual = solution.CommonChars_Version1(words);

            actual.Should().BeEquivalentTo(expected);
        }
        
        [TestCase(new string[] { "bella", "label", "roller" },
            new string[] { "e", "l", "l" })]
        [TestCase(new string[] { "cool", "lock", "cook" },
            new string[] { "c", "o" })]
        [TestCase(new string[] { "abc", "def", "ghi" },
            new string[] { })]
        public void CommonChars_Version2(string[] words,
            string[] expected)
        {
            var solution = new Solution1002();
            var actual = solution.CommonChars_Version2(words);

            actual.Should().BeEquivalentTo(expected);
        }
    }
}