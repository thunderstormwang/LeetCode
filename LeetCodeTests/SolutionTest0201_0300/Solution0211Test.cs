using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0211Test
{
    [Test]
    public void WordDictionary_Ver1Test()
    {
        var solution = new Solution0211.WordDictionary_Ver1();
        
        solution.AddWord("bad");
        solution.AddWord("dad");
        solution.AddWord("mad");
        solution.Search("pad").Should().BeFalse();
        solution.Search("bad").Should().BeTrue();
        solution.Search(".ad").Should().BeTrue();
        solution.Search("b..").Should().BeTrue();
    }
    
    [Test]
    public void WordDictionary_Ver2Test()
    {
        var solution = new Solution0211.WordDictionary_Ver1();
        
        solution.AddWord("bad");
        solution.AddWord("dad");
        solution.AddWord("mad");
        solution.Search("pad").Should().BeFalse();
        solution.Search("bad").Should().BeTrue();
        solution.Search(".ad").Should().BeTrue();
        solution.Search("b..").Should().BeTrue();
    }
}