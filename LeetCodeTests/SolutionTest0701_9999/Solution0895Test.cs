using FluentAssertions;
using LeetCode.Solution0701_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0701_9999;

[TestFixture]
[Category("SolutionTest0701_9999")]
public class Solution0895Test
{
    [Test]
    public void FreqStackTest()
    {
        var solution = new Solution0895.FreqStack();

        solution.Push(5);
        solution.Push(7);
        solution.Push(5);
        solution.Push(7);
        solution.Push(4);
        solution.Push(5);
        solution.Pop().Should().Be(5);
        solution.Pop().Should().Be(7);
        solution.Pop().Should().Be(5);
        solution.Pop().Should().Be(4);
    }
}