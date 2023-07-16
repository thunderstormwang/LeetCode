using FluentAssertions;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0151_0200;

[TestFixture]
[Category("SolutionTest0151_0200")]
public class Solution0155Test
{
    [Test]
    public void MinStack_01()
    {
        var solution = new Solution0155.MinStack();

        solution.Push(-2);
        solution.Push(0);
        solution.Push(-3);
        solution.GetMin().Should().Be(-3);
        solution.Pop();
        solution.Top().Should().Be(0);
        solution.GetMin().Should().Be(-2);
    }
    
    [Test]
    public void MinStack_02()
    {
        var solution = new Solution0155.MinStack();

        solution.Push(0);
        solution.Push(1);
        solution.Push(0);
        solution.GetMin().Should().Be(0);
        solution.Pop();
        solution.GetMin().Should().Be(0);
    }
}