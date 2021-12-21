using FluentAssertions;
using LeetCode.Solution0201_0500;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0500
{
    [TestFixture]
    public class Solution0225Test
    {
        [Test]
        public void MyStack_Version1_01()
        {
            var solution = new Solution0225.MyStack_Version1();

            solution.Push(1);
            solution.Push(2);
            solution.Top().Should().Be(2);
            solution.Pop().Should().Be(2);
            solution.Empty().Should().BeFalse();
        }
        
        [Test]
        public void MyStack_Version1_02()
        {
            var solution = new Solution0225.MyStack_Version1();

            solution.Push(1);
            solution.Push(2);
            solution.Pop().Should().Be(2);
            solution.Top().Should().Be(1);
        }
        
        [Test]
        public void MyStack_Version1_03()
        {
            var solution = new Solution0225.MyStack_Version1();

            solution.Push(1);
            solution.Pop().Should().Be(1);
            solution.Empty().Should().BeTrue();
        }
        
        [Test]
        public void MyStack_Version2_01()
        {
            var solution = new Solution0225.MyStack_Version2();

            solution.Push(1);
            solution.Push(2);
            solution.Top().Should().Be(2);
            solution.Pop().Should().Be(2);
            solution.Empty().Should().BeFalse();
        }
        
        [Test]
        public void MyStack_Version2_02()
        {
            var solution = new Solution0225.MyStack_Version2();

            solution.Push(1);
            solution.Push(2);
            solution.Pop().Should().Be(2);
            solution.Top().Should().Be(1);
        }
        
        [Test]
        public void MyStack_Version3_03()
        {
            var solution = new Solution0225.MyStack_Version2();

            solution.Push(1);
            solution.Pop().Should().Be(1);
            solution.Empty().Should().BeTrue();
        }
    }
}