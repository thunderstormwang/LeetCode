using FluentAssertions;
using LeetCode.Solution0201_9999;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_9999
{
    [TestFixture]
    public class Solution0707Test
    {
        [Test]
        public void MyLinkedList_Version1_01()
        {
            var solution = new Solution0707.MyLinkedList_Version1();

            solution.AddAtHead(1);
            solution.AddAtTail(3);
            solution.AddAtIndex(1,
                2);
            solution.Get(1).Should().Be(2);
            solution.DeleteAtIndex(1);
            solution.Get(1).Should().Be(3);
        }
        
        [Test]
        public void MyLinkedList_Version1_02()
        {
            var solution = new Solution0707.MyLinkedList_Version1();

            solution.AddAtHead(7);
            solution.AddAtHead(2);
            solution.AddAtHead(1);
            solution.AddAtIndex(3,0);
            solution.DeleteAtIndex(2);
            solution.AddAtHead(6);
            solution.AddAtTail(4);
            solution.Get(4).Should().Be(4);
            solution.AddAtHead(4);
            solution.AddAtIndex(5,0);
            solution.AddAtHead(6);
            solution.Get(6).Should().Be(0);
            solution.Get(0).Should().Be(6);
        }

        [Test]
        public void MyLinkedList_Version2_01()
        {
            var solution = new Solution0707.MyLinkedList_Version2();

            solution.AddAtHead(1);
            solution.AddAtTail(3);
            solution.AddAtIndex(1,
                2);
            solution.Get(1).Should().Be(2);
            solution.DeleteAtIndex(1);
            solution.Get(1).Should().Be(3);
        }
        
        [Test]
        public void MyLinkedList_Version2_02()
        {
            var solution = new Solution0707.MyLinkedList_Version2();

            solution.AddAtHead(7);
            solution.AddAtHead(2);
            solution.AddAtHead(1);
            solution.AddAtIndex(3,0);
            solution.DeleteAtIndex(2);
            solution.AddAtHead(6);
            solution.AddAtTail(4);
            solution.Get(4).Should().Be(4);
            solution.AddAtHead(4);
            solution.AddAtIndex(5,0);
            solution.AddAtHead(6);
            solution.Get(6).Should().Be(0);
            solution.Get(0).Should().Be(6);
        }
    }
}