using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0232Test
{
    [Test]
    public void MyQueue_01()
    {
        var solution = new Solution0232.MyQueue();

        solution.Push(1);
        solution.Push(2);
        solution.Peek().Should().Be(1);
        solution.Pop().Should().Be(1);
        solution.Empty().Should().BeFalse();
    }
        
    [Test]
    public void MyQueue_02()
    {
        var solution = new Solution0232.MyQueue();

        solution.Push(1);
        solution.Push(2);
        solution.Pop().Should().Be(1);
        solution.Push(3);
        solution.Push(4);
        solution.Pop().Should().Be(2);
        solution.Pop().Should().Be(3);
        solution.Pop().Should().Be(4);
        solution.Empty().Should().BeTrue();
    }
}