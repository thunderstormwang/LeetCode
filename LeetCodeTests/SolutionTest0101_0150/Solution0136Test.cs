using FluentAssertions;
using LeetCode.Solution0101_0150;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0150;

[TestFixture]
[Category("SolutionTest0101_0150")]
public class Solution0136Tests
{
    [TestCase(new int[] { 2, 2, 1 }, 1)]
    [TestCase(new int[] { 4, 1, 2, 1, 2 }, 4)]
    public void SingleNumberTest(int[] nums, int expected)
    {
        var solution = new Solution0136();
        
        var actual = solution.SingleNumber(nums);

        actual.Should().Be(expected);
    }
}