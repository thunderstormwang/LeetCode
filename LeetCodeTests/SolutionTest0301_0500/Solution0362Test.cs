using FluentAssertions;
using LeetCode.Solution0301_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500;

[TestFixture]
[Category("SolutionTest0301_0500")]
public class Solution0362Test
{
    [Test]
    public void HitCounter_Ver1Test()
    {
        var solution = new Solution0362.HitCounter_Ver1();

        solution.Hit(1);
        solution.Hit(2);
        solution.Hit(3);
        solution.GetHits(4).Should().Be(3);
        solution.Hit(300);
        solution.GetHits(300).Should().Be(4);
        solution.GetHits(301).Should().Be(3);
    }
    
    [Test]
    public void HitCounter_Ver2Test()
    {
        var solution = new Solution0362.HitCounter_Ver2();

        solution.Hit(1);
        solution.Hit(2);
        solution.Hit(3);
        solution.GetHits(4).Should().Be(3);
        solution.Hit(300);
        solution.GetHits(300).Should().Be(4);
        solution.GetHits(301).Should().Be(3);
    }
}