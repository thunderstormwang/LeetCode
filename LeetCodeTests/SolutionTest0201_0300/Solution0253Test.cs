using FluentAssertions;
using LeetCode.Solution0201_0300;
using NUnit.Framework;

namespace LeetCodeTests.SolutionTest0201_0300;

[TestFixture]
[Category("SolutionTest0201_0300")]
public class Solution0253Test
{
    [TestCaseSource(nameof(TestCases))]
    public void CanAttendMeetingsTest(int[][] intervals, int expected)
    {
        var solution = new Solution0253();
        var actual = solution.MinMeetingRooms(intervals);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void CanAttendMeetings_PriorityQueueTest(int[][] intervals, int expected)
    {
        var solution = new Solution0253();
        var actual = solution.MinMeetingRooms_PriorityQueue(intervals);

        actual.Should().Be(expected);
    }
    
    [TestCaseSource(nameof(TestCases))]
    public void CanAttendMeetings_SortedListTest(int[][] intervals, int expected)
    {
        var solution = new Solution0253();
        var actual = solution.MinMeetingRooms_SortedList(intervals);

        actual.Should().Be(expected);
    }

    private static readonly object[] TestCases =
    {
        new object[]
        {
            new int[][]
            {
                new int[] { 0, 30 },
                new int[] { 5, 10 },
                new int[] { 15, 20 },
            },
            2
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 7, 10 },
                new int[] { 2, 4 }
            },
            1
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 1, 4 },
                new int[] { 2, 3 },
                new int[] { 3, 4 }
            },
            2
        },
        new object[]
        {
            new int[][]
            {
                new int[] { 1, 4 },
                new int[] { 2, 4 },
                new int[] { 3, 4 }
            },
            3
        }
    };
}