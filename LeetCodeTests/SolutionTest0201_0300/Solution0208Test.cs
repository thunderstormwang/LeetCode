using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0208Test
{
    [Test]
    public void TrieTest()
    {
        var trie = new Solution0208.Trie();
        trie.Insert("apple");
        trie.Search("apple").Should().BeTrue();
        trie.Search("app").Should().BeFalse();
        trie.StartsWith("app").Should().BeTrue();
        trie.Insert("app");
        trie.Search("app").Should().BeTrue();
    }
}