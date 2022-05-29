using FluentAssertions;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200
{
    [TestFixture]
    public class Solution0151Test
    {
        [TestCase("the sky is blue", "blue is sky the")]
        [TestCase("  hello world  ", "world hello")]
        [TestCase("a good   example", "example good a")]
        [TestCase("  Bob    Loves  Alice   ", "Alice Loves Bob")]
        [TestCase("Alice does not even like bob", "bob like even not does Alice")]
        [TestCase("Hello", "Hello")]
        [TestCase("a bc", "bc a")]
        public void ReverseWords(string s, string expected)
        {
            var solution = new Solution0151();
            var actual = solution.ReverseWords(s);

            actual.Should().Be(expected);
        }
    }
}