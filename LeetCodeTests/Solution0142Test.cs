﻿using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture]
    public class Solution0142Test
    {
        private ListNode cycleStart;
        
        [SetUp]
        public void SetupBeforeEachTest()
        {
            cycleStart = null;
        }

        [TestCase(new int[] { 3, 2, 0, 4 },
            1)]
        [TestCase(new int[] { 1, 2 },
            0)]
        [TestCase(new int[] { 1 },
            -1)]
        [TestCase(new int[] { },
            -1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 },
            0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 },
            1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 },
            2)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 },
            3)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 },
            4)]
        public void DetectCycleTest(int[] array,
            int pos)
        {
            var list = GetLinkedList(array,
                pos);

            var solution = new Solution0142();
            var actual = solution.DetectCycle(list);

            if (cycleStart == null)
            {
                actual.Should().BeNull();
            }
            else
            {
                actual.Should().Be(cycleStart);
            }
        }

        private ListNode GetLinkedList(int[] input,
            int pos)
        {
            ListNode result = null;
            ListNode tail = null;

            for (var i = input.Length - 1; i >= 0; i--)
            {
                var temp = result;
                result = new ListNode(input[i]);
                result.Next = temp;

                if (tail == null)
                {
                    tail = result;
                }

                if (i == pos)
                {
                    tail.Next = result;
                    cycleStart = result;
                }
            }

            return result;
        }
    }
}