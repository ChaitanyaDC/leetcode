namespace leetcode.challenges.Intervals._435NonOverlappingIntervals;

using System;
using System.Collections.Generic;

public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        // Sort the intervals
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        int res = 0;
        int prevEnd = intervals[0][1];

        // Remaining list of intervals
        for (int i = 1; i < intervals.Length; i++)
        {
            int start = intervals[i][0];
            int end = intervals[i][1];

            // They are not overlapping
            if (start >= prevEnd)
            {
                // Update the last end to the current end
                prevEnd = end;
            }
            else
            {
                // Remove one interval, the one with the longest end time is removed
                res++;
                // Keep the last end short to avoid overlapping
                prevEnd = Math.Min(end, prevEnd);
            }
        }
        return res;
    }
}

public static class _435NonOverlappingIntervals {

    public static void Test() {
        
        int[][] intervals = new int[][] { new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 3, 4 }, new int[] { 1, 3 } };
        Solution sol = new Solution();
        int result = sol.EraseOverlapIntervals(intervals);
        Console.WriteLine(result);
    }
}