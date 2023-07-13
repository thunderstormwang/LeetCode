using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0234Test
{
    [TestCaseSource(nameof(TestCases))]
    public void IsPalindromeTest(int[] inputArray, bool expected)
    {
        var head = Utility.BuildListNode(inputArray);

        var solution = new Solution0234();
        var actual = solution.IsPalindrome(head);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void IsPalindrome_Ver2Test(int[] inputArray, bool expected)
    {
        var head = Utility.BuildListNode(inputArray);

        var solution = new Solution0234();
        var actual = solution.IsPalindrome_Ver2(head);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[] { 1, 2, 2, 1 },
            true
        },
        new object[]
        {
            new int[] { 1, 2 },
            false
        },
        new object[]
        {
            new int[] { 1 },
            true
        }
    };
}