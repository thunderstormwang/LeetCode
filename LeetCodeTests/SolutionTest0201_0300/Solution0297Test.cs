using FluentAssertions;
using LeetCode.Models;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0297Test
{
    [TestCaseSource(nameof(TestCases))]
    public void InorderSuccessor_Ver2Test(int?[] inputArray, int?[] expectedArray)
    {
        var root = Utility.BuildTree(inputArray, 0);
        var expected = Utility.BuildTree(expectedArray, 0);

        var solution = new Solution0297();
        var actual = solution.Deserialize(solution.Serialize(root));

        Utility.CheckBinaryTree(actual, expected).Should().BeTrue();
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int?[] { 1, 2, 3, null, null, 4, 5 },
            new int?[] { 1, 2, 3, null, null, 4, 5 }
        },
        new object[]
        {
            new int?[] { },
            new int?[] { }
        },
        new object[]
        {
            new int?[] { 3, 2, 4, 3 },
            new int?[] { 3, 2, 4, 3 }
        }
    };
}