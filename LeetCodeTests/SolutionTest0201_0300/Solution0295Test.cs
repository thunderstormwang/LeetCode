using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0295Test
{
    [Test]
    public void MedianFinderTest_01()
    {
        var solution = new Solution0295.MedianFinder();
        solution.AddNum(1);
        solution.AddNum(2);
        solution.FindMedian().Should().Be(1.5d);
        solution.AddNum(3);
        solution.FindMedian().Should().Be(2d);
    }
    
    [Test]
    public void MedianFinderTest_02()
    {
        var solution = new Solution0295.MedianFinder();
        solution.AddNum(-1);
        solution.FindMedian().Should().Be(-1d);
        solution.AddNum(-2);
        solution.FindMedian().Should().Be(-1.5d);
        solution.AddNum(-3);
        solution.FindMedian().Should().Be(-2d);
        solution.AddNum(-4);
        solution.FindMedian().Should().Be(-2.5d);
        solution.AddNum(-5);
        solution.FindMedian().Should().Be(-3d);
    }
}