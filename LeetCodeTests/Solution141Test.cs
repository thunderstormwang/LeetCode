using FluentAssertions;
using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    [TestFixture()]
    public class Solution141Test
    {
        [TestCase(new int[] {3, 2, 0, 4}, 1, true)]
        [TestCase(new int[] {1, 2}, 0, true)]
        [TestCase(new int[] {1}, -1, false)]
        public void HasCycleTest(int[] array, int pos, bool expected)
        {
            var list = GetLinkedList(array, pos);
            
            var solution141 = new Solution141();
            var actual = solution141.HasCycle(list);
            
            actual.Should().Be(expected);
        }
        
        private ListNode GetLinkedList(int[] input, int pos)
        {
            ListNode result = null;
            ListNode tail = null;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                var temp = result;
                result = new ListNode(input[i]);
                result.next = temp;
                
                if (tail == null)
                {
                    tail = result;
                }

                if (i == pos)
                {
                    tail.next = result;
                }
            }

            return result;
        }
    }
}