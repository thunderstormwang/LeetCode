using FluentAssertions;
using LeetCode;
using LeetCode.Solution0151_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0151_0200;

[TestFixture]
[Category("SolutionTest0151_0200")]
public class Solution0190Test
{
    [TestCaseSource(nameof(TestCases))]
    public void ReverseBits_Ver1Test(uint input, uint expected)
    {
        var solution = new Solution0190();
        
        var actual = solution.ReverseBits_Ver1(input);

        actual.Should().Be(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void ReverseBitsTest(uint input, uint expected)
    {
        var solution = new Solution0190();
        
        var actual = solution.ReverseBits_Ver2(input);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            43261596U,
            964176192U
        },
        new object[]
        {
            4294967293U,
            3221225471U
        }
    };
}