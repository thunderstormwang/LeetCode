using FluentAssertions;
using LeetCode.Solution0151_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0151_0200;

[TestFixture]
[Category("SolutionTest0151_0200")]
public class Solution0191Test
{
    [TestCaseSource(nameof(TestCases))]
    public void HammingWeight_Ver1Test(uint input, int expected)
    {
        var solution = new Solution0191();
        
        var actual = solution.HammingWeight_Ver1(input);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void HammingWeight_Ver2Test(uint input, int expected)
    {
        var solution191 = new Solution0191();
        
        var actual = solution191.HammingWeight_Ver2(input);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void HammingWeight_Ver3Test(uint input, int expected)
    {
        var solution191 = new Solution0191();
        
        var actual = solution191.HammingWeight_Ver3(input);

        actual.Should().Be(expected);
    }
    
    private static readonly object[] TestCases =
    {
        new object[]
        {
            0U,
            0
        },
        new object[]
        {
            11U,
            3
        },
        new object[]
        {
            128U,
            1
        },
        new object[]
        {
            4294967290U,
            30
        },
        new object[]
        {
            4294967293U,
            31
        },
        new object[]
        {
            4294967295U,
            32
        }
    };
}