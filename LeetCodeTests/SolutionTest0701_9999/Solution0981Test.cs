using FluentAssertions;
using LeetCode.Solution0701_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0701_9999;

[TestFixture]
[Category("SolutionTest0701_9999")]
public class Solution0981Test
{
    [Test]
    public void TimeMap_Ver1_01()
    {
        var solution = new Solution0981.TimeMap_Ver1();

        solution.Set("foo", "bar", 1);
        solution.Get("foo", 1).Should().Be("bar");
        solution.Get("foo", 3).Should().Be("bar");
        solution.Set("foo", "bar2", 4);
        solution.Get("foo", 4).Should().Be("bar2");
        solution.Get("foo", 5).Should().Be("bar2");
    }
    
    [Test]
    public void TimeMap_Ver1_02()
    {
        var solution = new Solution0981.TimeMap_Ver1();

        solution.Set("love", "high", 10);
        solution.Set("love", "low", 20);
        solution.Get("love", 5).Should().Be("");
        solution.Get("love", 10).Should().Be("high");
        solution.Get("love", 15).Should().Be("high");
        solution.Get("love", 20).Should().Be("low");
        solution.Get("love", 25).Should().Be("low");
    }
}