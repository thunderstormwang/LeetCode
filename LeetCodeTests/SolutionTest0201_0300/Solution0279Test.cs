using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0301_0500
{
    [TestFixture]
    [Category("SolutionTest0301_0500")]
    public class Solution0279Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void NumSquares_Ver1Test(int input, int expected)
        {
            var solution = new Solution0279();
            var actual = solution.NumSquares_Ver1(input);

            actual.Should().Be(expected);
        }

        [TestCaseSource(nameof(TestCases))]
        public void NumSquares_Ver2Test(int input, int expected)
        {
            var solution = new Solution0279();
            var actual = solution.NumSquares_Ver2(input);

            actual.Should().Be(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                75,
                3
            },
            new object[]
            {
                43,
                3
            },
            new object[]
            {
                38,
                3
            },
            new object[]
            {
                32,
                2
            },
            new object[]
            {
                25,
                1
            },
            new object[]
            {
                13,
                2
            },
            new object[]
            {
                12,
                3
            },
            new object[]
            {
                1,
                1
            }
        };
    }
}