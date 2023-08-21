using FluentAssertions;
using LeetCode.Models;
using LeetCode.Solution0101_0150;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0101_0150;

[TestFixture]
[Category("SolutionTest0101_0150")]
public class Solution0142Test
{
    [TestCase(new int[] { 3, 2, 0, 4 }, 1)]
    [TestCase(new int[] { 1, 2 }, 0)]
    [TestCase(new int[] { 1 }, -1)]
    [TestCase(new int[] { }, -1)]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0)]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 1)]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2)]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3)]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4)]
    public void DetectCycleTest(int[] array, int pos)
    {
        var list = Utility.BuildListNode(array, pos);
        var cycleStart = GetNode(list, pos);
        
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

    private ListNode? GetNode(ListNode head, int pos)
    {
        var i = 0;
        
        while (head != null)
        {
            if (i == pos)
            {
                return head;
            }
            
            head = head.next;
            i++;
        }

        return head;
    }
}