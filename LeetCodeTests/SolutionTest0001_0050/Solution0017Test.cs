using System.Collections.Generic;
using FluentAssertions;
using LeetCode.Solution0001_0050;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0001_0050
{
    [TestFixture]
    public class Solution0017Test
    {
        [TestCase("23",
            new string[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" })]
        [TestCase("",
            new string[] { })]
        [TestCase("2",
            new string[] { "a", "b", "c" })]
        public void LetterCombinations_IterativeTest(string input,
            string[] expectedArray)
        {
            var solution = new Solution0017();
            var expectedList = new List<string>(expectedArray);

            var actual = solution.LetterCombinations_Iterative(input);

            actual.Should().BeEquivalentTo(expectedList);
        }

        [TestCase("23",
            new string[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" })]
        [TestCase("",
            new string[] { })]
        [TestCase("2",
            new string[] { "a", "b", "c" })]
        public void LetterCombinations_RecursiveTest(string input,
            string[] expectedArray)
        {
            var solution017 = new Solution0017();
            var expectedList = new List<string>(expectedArray);

            var actual = solution017.LetterCombinations_Recursive(input);

            actual.Should().BeEquivalentTo(expectedList);
        }
    }
}