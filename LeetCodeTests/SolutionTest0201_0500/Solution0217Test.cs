using FluentAssertions;
using LeetCode.Solution0201_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0500;

[TestFixture]
public class Solution0217Test
{
    [TestCase(new int[] { 1, 2, 3, 1 }, true)]
    [TestCase(new int[] { 1, 2, 3, 4 }, false)]
    [TestCase(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
    [TestCase(new int[] { }, false)]
    [TestCase(new int[] { 999 }, false)]
    public void ContainsDuplicateTest(int[] input, bool expected)
    {
        var solution = new Solution0217();
        var actual = solution.ContainsDuplicate(input);

        actual.Should().Be(expected);
    }
}