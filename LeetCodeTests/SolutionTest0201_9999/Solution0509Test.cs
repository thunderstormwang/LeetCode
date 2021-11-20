using FluentAssertions;
using LeetCode.Solution0201_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_9999
{
    [TestFixture]
    public class Solution0509Test
    {
        [TestCase(0,
            0)]
        [TestCase(1,
            1)]
        [TestCase(2,
            1)]
        [TestCase(3,
            2)]
        [TestCase(4,
            3)]
        [TestCase(5,
            5)]
        public void Fib_NonRecursive(int n,
            int expected)
        {
            var solution = new Solution0509();
            var actual = solution.Fib_NonRecursive(n);

            actual.Should().Be(expected);
        }
        
        [TestCase(0,
            0)]
        [TestCase(1,
            1)]
        [TestCase(2,
            1)]
        [TestCase(3,
            2)]
        [TestCase(4,
            3)]
        [TestCase(5,
            5)]
        public void Fib_Recursive(int n,
            int expected)
        {
            var solution = new Solution0509();
            var actual = solution.Fib_Recursive(n);

            actual.Should().Be(expected);
        }
    }
}