using FluentAssertions;
using LeetCode.Solution0101_0150;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0150;

[TestFixture]
[Category("SolutionTest0101_0150")]
public class Solution0146Test
{
    [Test]
    public void LRUCacheTest_Version1_01()
    {
        var solution = new Solution0146.LRUCache_Version1(2);

        solution.Put(1, 1);
        solution.Put(2, 2);
        solution.Get(1).Should().Be(1);
        solution.Put(3, 3);
        solution.Get(2).Should().Be(-1);
        solution.Put(4, 4);
        solution.Get(1).Should().Be(-1);
        solution.Get(3).Should().Be(3);
        solution.Get(4).Should().Be(4);
    }

    [Test]
    public void LRUCacheTest_Version1_02()
    {
        var solution = new Solution0146.LRUCache_Version1(2);

        solution.Put(2, 1);
        solution.Put(2, 2);
        solution.Get(2).Should().Be(2);
        solution.Put(1, 1);
        solution.Put(4, 1);
        solution.Get(2).Should().Be(-1);
    }

    [Test]
    public void LRUCacheTest_Version1_03()
    {
        var solution = new Solution0146.LRUCache_Version1(2);

        solution.Put(2, 1);
        solution.Put(1, 1);
        solution.Put(2, 3);
        solution.Put(4, 1);
        solution.Get(1).Should().Be(-1);
        solution.Get(2).Should().Be(3);
    }

    [Test]
    public void LRUCacheTest_Version2_01()
    {
        var solution = new Solution0146.LRUCache_Version2(2);

        solution.Put(1, 1);
        solution.Put(2, 2);
        solution.Get(1).Should().Be(1);
        solution.Put(3, 3);
        solution.Get(2).Should().Be(-1);
        solution.Put(4, 4);
        solution.Get(1).Should().Be(-1);
        solution.Get(3).Should().Be(3);
        solution.Get(4).Should().Be(4);
    }

    [Test]
    public void LRUCacheTest_Version2_02()
    {
        var solution = new Solution0146.LRUCache_Version2(2);

        solution.Put(2, 1);
        solution.Put(2, 2);
        solution.Get(2).Should().Be(2);
        solution.Put(1, 1);
        solution.Put(4, 1);
        solution.Get(2).Should().Be(-1);
    }
    
    [Test]
    public void LRUCacheTest_Version2_03()
    {
        var solution = new Solution0146.LRUCache_Version2(2);

        solution.Put(2, 1);
        solution.Put(1, 1);
        solution.Put(2, 3);
        solution.Put(4, 1);
        solution.Get(1).Should().Be(-1);
        solution.Get(2).Should().Be(3);
    }
}