﻿using FluentAssertions;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200;

[TestFixture]
public class Solution0131Test
{
    [TestCaseSource(nameof(TestCases))]
    public void Partition(string s, IList<IList<string>> expected)
    {
        var solution = new Solution0131();
        var actual = solution.Partition(s);

        actual.Should().BeEquivalentTo(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void Partition2(string s, IList<IList<string>> expected)
    {
        var solution = new Solution0131();
        var actual = solution.Partition2(s);

        actual.Should().BeEquivalentTo(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "aab",
            new List<IList<string>>
            {
                new List<string>() { "a", "a", "b" },
                new List<string>() { "aa", "b" },
            }
        },
        new object[]
        {
            "a",
            new List<IList<string>>
            {
                new List<string>() { "a" }
            }
        },
        new object[]
        {
            "aabb",
            new List<IList<string>>
            {
                new List<string>() { "a", "a", "b", "b" },
                new List<string>() { "a", "a", "bb" },
                new List<string>() { "aa", "b", "b" },
                new List<string>() { "aa", "bb" }
            }
        },
        new object[]
        {
            "efe",
            new List<IList<string>>
            {
                new List<string>() { "e", "f", "e" },
                new List<string>() { "efe" }
            }
        }
    };
}