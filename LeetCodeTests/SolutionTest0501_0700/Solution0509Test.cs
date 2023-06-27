using FluentAssertions;
using LeetCode.Solution0501_0700;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0501_0700
{
    [TestFixture]
    [Category("SolutionTest0501_0700")]
    public class Solution0509Test
    {
        [TestCaseSource(nameof(TestCases))]
        public void Fib_Iterative_Ver1(int n, int expected)
        {
            var solution = new Solution0509();
            var actual = solution.Fib_Iterative_Ver1(n);

            actual.Should().Be(expected);
        }

        
        [TestCaseSource(nameof(TestCases))]
        public void Fib_Iterative_Ver2(int n, int expected)
        {
            var solution = new Solution0509();
            var actual = solution.Fib_Iterative_Ver2(n);

            actual.Should().Be(expected);
        }
        
        [TestCaseSource(nameof(TestCases))]
        public void Fib_Recursive_Ver1(int n, int expected)
        {
            var solution = new Solution0509();
            var actual = solution.Fib_Recursive_Ver1(n);

            actual.Should().Be(expected);
        }

        [TestCaseSource(nameof(TestCases))]
        public void Fib_Recursive_Ver2(int n, int expected)
        {
            var solution = new Solution0509();
            var actual = solution.Fib_Recursive_Ver2(n);

            actual.Should().Be(expected);
        }

        private static readonly object[] TestCases =
        {
            new object[]
            {
                0, 0
            },
            new object[]
            {
                1, 1
            },
            new object[]
            {
                2, 1
            },
            new object[]
            {
                3, 2
            },
            new object[]
            {
                4, 3
            },
            new object[]
            {
                5, 5
            }
        };
    }
}