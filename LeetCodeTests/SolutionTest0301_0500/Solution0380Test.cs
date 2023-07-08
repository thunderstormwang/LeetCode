using FluentAssertions;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500;

[TestFixture]
[Category("SolutionTest0301_0500")]
public class Solution0380Test
{
    [Test]
    public void RandomizedSet_01Test()
    {
        var solution = new Solution0380.RandomizedSet();

        solution.Insert(1).Should().BeTrue();
        solution.Remove(2).Should().BeFalse();
        solution.Insert(2).Should().BeTrue();
        new List<int>() { 1, 2 }.Should().Contain(solution.GetRandom());
        solution.Remove(1).Should().BeTrue();
        solution.Insert(2).Should().BeFalse();
        new List<int>() { 2 }.Should().Contain(solution.GetRandom());
    }

    [Test]
    public void RandomizedSet_02Test()
    {
        var solution = new Solution0380.RandomizedSet();

        solution.Remove(0).Should().BeFalse();
        solution.Remove(0).Should().BeFalse();
        solution.Insert(0).Should().BeTrue();
        new List<int>() { 0 }.Should().Contain(solution.GetRandom());
        solution.Remove(0).Should().BeTrue();
        solution.Insert(0).Should().BeTrue();
    }

    [Test]
    public void RandomizedSet_03Test()
    {
        var solution = new Solution0380.RandomizedSet();

        solution.Insert(1).Should().BeTrue();
        solution.Remove(2).Should().BeFalse();
        solution.Insert(2).Should().BeTrue();
        new List<int>() { 1, 2 }.Should().Contain(solution.GetRandom());
        solution.Remove(1).Should().BeTrue();
        solution.Insert(2).Should().BeFalse();
        new List<int>() { 2 }.Should().Contain(solution.GetRandom());
    }
}