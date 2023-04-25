using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050;

[TestFixture]
[Category("SolutionTest0001_0050")]
public class Solution0049Test
{
    [TestCaseSource(nameof(TestCases))]
    public void GroupAnagrams_Ver1Test(string[] strs, IList<IList<string>> expected)
    {
        var solution = new Solution0049();
        var actual = solution.GroupAnagrams_Ver1(strs);

        actual.Should().BeEquivalentTo(expected);
    }

    [TestCaseSource(nameof(TestCases))]
    public void GroupAnagrams_Ver2Test(string[] strs, IList<IList<string>> expected)
    {
        var solution = new Solution0049();
        var actual = solution.GroupAnagrams_Ver2(strs);

        actual.Should().BeEquivalentTo(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new string[] { "eat", "tea", "tan", "ate", "nat", "bat" },
            new string[][]
            {
                new string[] { "bat" },
                new string[] { "nat", "tan" },
                new string[] { "ate", "eat", "tea" }
            }
        },
        new object[]
        {
            new string[] { "" },
            new string[][]
            {
                new string[] { "" }
            }
        },
        new object[]
        {
            new string[] { "a" },
            new string[][]
            {
                new string[] { "a" }
            }
        }
    };
}