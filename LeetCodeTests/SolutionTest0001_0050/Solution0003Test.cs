using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
[Category("SolutionTest0001_0050")]
public class Solution0003Test
{
    [TestCaseSource(nameof(TestCases))]
    public void LengthOfLongestSubstring_SlideWindow_Ver1Test(string s, int expected)
    {
        var solution003 = new Solution0003();
        var actual = solution003.LengthOfLongestSubstring_SlideWindow_Ver1(s);

        actual.Should().Be(expected);
    }
        
    [TestCaseSource(nameof(TestCases))]
    public void LengthOfLongestSubstring_SlideWindow_Ver2Test(string s, int expected)
    {
        var solution003 = new Solution0003();
        var actual = solution003.LengthOfLongestSubstring_SlideWindow_Ver2(s);
        
        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void LengthOfLongestSubstring_SlideWindow_Ver3Test(string s, int expected)
    {
        var solution003 = new Solution0003();
        var actual = solution003.LengthOfLongestSubstring_SlideWindow_Ver3(s);
        
        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "abcabcbb",
            3
        },
        new object[]
        {
            "bbbbb",
            1
        },
        new object[]
        {
            "pwwkew",
            3
        },
        new object[]
        {
            string.Empty,
            0
        },
        new object[]
        {
            "GEEKSFORGEEKS",
            7
        },
        new object[]
        {
            " ",
            1
        },
        new object[]
        {
            "aab",
            2
        },
        new object[]
        {
            "dvdf",
            3
        }
    };
}