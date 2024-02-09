namespace leetcode.challenges.Intervals._920MeetingRooms;

using System;
using System.Collections.Generic;

public class Solution {
    public bool CanAttendMeetings(int[][] intervals)
    {
        // Sort the intervals based on the start time
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        // Start iterating through the array
        for (int i = 1; i < intervals.Length; i++)
        {
            // Get previous and current intervals
            int[] i1 = intervals[i - 1];
            int[] i2 = intervals[i];

            // Check if the start of the next interval is before the end time of the current interval
            if (i2[0] < i1[1])
            {
                return false;
            }
        }
        return true;
    }
}

public static class _920MeetingRooms {

    public static void Test() {
        
        Solution solution = new Solution();
        int[][] intervals = new int[][] { new int[] { 0, 30 }, new int[] { 5, 10 }, new int[] { 15, 20 } };
        Console.WriteLine(solution.CanAttendMeetings(intervals));
    }
}