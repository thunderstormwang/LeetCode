using System.Collections.Generic;
using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution017Test
    {
        [TestCase("23",
            new string[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" })]
        [TestCase("",
            new string[] { })]
        [TestCase("2",
            new string[] { "a", "b", "c" })]
        public void LetterCombinations_NonRecursiveTest(string input,
            string[] expectedArray)
        {
            var solution017 = new Solution017();
            var expectedList = new List<string>(expectedArray);

            var actual = solution017.LetterCombinations_NonRecursive(input);

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
            var solution017 = new Solution017();
            var expectedList = new List<string>(expectedArray);

            var actual = solution017.LetterCombinations_Recursive(input);

            actual.Should().BeEquivalentTo(expectedList);
        }
    }
}