using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
[Category("SolutionTest0001_0050")]
public class Solution0009Test
{
    [TestCaseSource(nameof(TestCases))]
    public void IsPalindrome_Ver1Test(int x, bool expected)
    {
        var solution = new Solution0009();

        var actual = solution.IsPalindrome_Ver1(x);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void IsPalindrome_Ver2Test(int x, bool expected)
    {
        var solution = new Solution0009();

        var actual = solution.IsPalindrome_Ver2(x);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void IsPalindrome_Ver3Test(int x, bool expected)
    {
        var solution = new Solution0009();

        var actual = solution.IsPalindrome_Ver3(x);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            121,
            true
        },
        new object[]
        {
            -121,
            false
        },
        new object[]
        {
            10,
            false
        },
        new object[]
        {
            0,
            true
        },
        new object[]
        {
            1,
            true
        },
        new object[]
        {
            21120,
            false
        }
    };
}