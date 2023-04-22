using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0242Test
{
    [TestCaseSource(nameof(TestCases))]
    public void IsAnagramTest(string s, string t, bool expected)
    {
        var solution = new Solution0242();
        var actual = solution.IsAnagram(s, t);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "anagram",
            "nagaram",
            true
        },
        new object[]
        {
            "rat",
            "car",
            false
        },
        new object[]
        {
            "apple",
            "aaaaa",
            false
        },
        new object[]
        {
            "apple",
            "microsoft",
            false
        }
    };
}