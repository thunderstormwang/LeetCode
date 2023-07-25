using FluentAssertions;
using LeetCode.Solution0701_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0701_9999;

[TestFixture]
[Category("SolutionTest0701_9999")]
public class Solution0735Test
{
    [TestCaseSource(nameof(TestCases))]
    public void AsteroidCollision_Ver1Test(int[] asteroids, int[] expected)
    {
        var solution = new Solution0735();
        var actual = solution.AsteroidCollision_Ver1(asteroids);

        actual.Should().BeEquivalentTo(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void AsteroidCollision_Ver2Test(int[] asteroids, int[] expected)
    {
        var solution = new Solution0735();
        var actual = solution.AsteroidCollision_Ver2(asteroids);

        actual.Should().BeEquivalentTo(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 5, 10, -5 },
            new int[] { 5, 10 }
        },
        new object[]
        {
            new int[] { 8, -8 },
            new int[] { }
        },
        new object[]
        {
            new int[] { 10, 2, -5 },
            new int[] { 10 }
        },
    };
}