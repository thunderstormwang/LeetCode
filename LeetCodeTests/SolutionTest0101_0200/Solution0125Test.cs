using FluentAssertions;
using LeetCode.Solution0101_0200;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0200
{
    [TestFixture]
    [Category("SolutionTest0101_0200")]
    public class Solution0125Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void IsPalindrome_Ver1Test(string s, bool expected)
        {
            var solution = new Solution0125();
            var actual = solution.IsPalindrome_Ver1(s);

            actual.Should().Be(expected);
        }
        
        [TestCaseSource(nameof(TestCases))]
        public void IsPalindrome_Ver2Test(string s, bool expected)
        {
            var solution = new Solution0125();
            var actual = solution.IsPalindrome_Ver2(s);

            actual.Should().Be(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                "A man, a plan, a canal: Panama",
                true
            },
            new object[]
            {
                "race a car",
                false
            },
            new object[]
            {
                " ",
                true
            },
            new object[]
            {
                "0P",
                false
            }
        };

    }
}