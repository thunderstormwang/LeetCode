using FluentAssertions;
using LeetCode.Solution0051_0100;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0051_0100;

[TestFixture]
public class Solution0093Test
{
    [TestCaseSource(nameof(TestCases))]
    public void CombinationSum(string s, List<string> expectedList)
    {
        var solution = new Solution0093();
        var actual = solution.RestoreIpAddresses(s);

        actual.Should().BeEquivalentTo(expectedList);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            "25525511135",
            new List<string>
            {
                "255.255.11.135",
                "255.255.111.35"
            }
        },
        new object[]
        {
            "0000",
            new List<string> { "0.0.0.0" }
        },
        new object[]
        {
            "101023",
            new List<string>
            {
                "1.0.10.23",
                "1.0.102.3",
                "10.1.0.23",
                "10.10.2.3",
                "101.0.2.3"
            }
        }
    };
}