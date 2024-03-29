﻿using FluentAssertions;
using LeetCode.Solution0101_0150;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0150;

[TestFixture]
[Category("SolutionTest0101_0150")]
public class Solution0139Test
{
    [TestCaseSource(nameof(TestCases))]
    public void WordBreak_Ver1Test(string s, IList<string> wordDict, bool expected)
    {
        var solution = new Solution0139();
        var actual = solution.WordBreak_Ver1(s, wordDict);

        actual.Should().Be(expected);
    }

    
    [TestCaseSource(nameof(TestCases))]
    public void WordBreak_Ver2Test(string s, IList<string> wordDict, bool expected)
    {
        var solution = new Solution0139();
        var actual = solution.WordBreak_Ver2(s, wordDict);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "leetcode",
            new List<string>
            {
                "leet", "code"
            },
            true
        },
        new object[]
        {
            "applepenapple",
            new List<string>
            {
                "apple","pen"
            },
            true
        },
        new object[]
        {
            "catsandog",
            new List<string>
            {
                "cats","dog","sand","and","cat"
            },
            false
        }
    };
}