using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
[Category("SolutionTest0001_0050")]
public class Solution0020Test
{
    [TestCase("()", true)]
    [TestCase("()[]{}", true)]
    [TestCase("(]", false)]
    [TestCase("([)]", false)]
    [TestCase("{[]}", true)]
    [TestCase("]", false)]
    public void IsValid(string s, bool expected) 
    {
        var solution = new Solution0020();
        var actual = solution.IsValid(s);

        actual.Should().Be(expected);
    }
}