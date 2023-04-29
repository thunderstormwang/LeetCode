using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
[Category("SolutionTest0001_0050")]
public class Solution0008Test
{
    [TestCase("42", 42)]
    [TestCase("   -42", -42)]
    [TestCase("4193 with words", 4193)]
    [TestCase("words and 987", 0)]
    [TestCase("-91283472332", -2147483648)]
    [TestCase("+-12", 0)]
    [TestCase("2147483646", 2147483646)]
    [TestCase("21474836460", 2147483647)]
    [TestCase("  +  413", 0)]
    [TestCase("", 0)]
    [TestCase("+", 0)]
    public void MyAtoiTest(string s, int expected)
    {
        var solution = new Solution0008();
        var actual = solution.MyAtoi(s);

        actual.Should().Be(expected);
    }
}