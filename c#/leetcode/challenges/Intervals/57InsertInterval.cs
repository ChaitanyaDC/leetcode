namespace leetcode.challenges.Intervals._57InsertInterval;

using System;
using System.Collections.Generic;

public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        List<int[]> res = new List<int[]>();

        // iterate through the intervals using a for loop
        for (int i = 0; i < intervals.Length; i++)
        {
            int[] interval = intervals[i];

            // if the end of the new interval is less than the start of the current interval,
            // append the new interval and the rest of the intervals to the result
            // this is important
            if (newInterval[1] < interval[0])
            {
                res.Add(newInterval);
                res.AddRange(intervals[i..]);
                return res.ToArray();
            }
            // if the start is greater than the end of the current interval,
            // then append the current interval
            else if (newInterval[0] > interval[1])
            {
                res.Add(interval);
            }
            else
            {
                // keep updating the new interval
                newInterval = new int[]{
                    Math.Min(newInterval[0], interval[0]),
                    Math.Max(newInterval[1], interval[1])
                };
            }
        }

        // eventually add the new interval if it does not overlap with any of the intervals
        res.Add(newInterval);
        return res.ToArray();
    }
}

public static class _57InsertInterval {

    public static void Test() {
        
        Solution solution = new Solution();
        int[][] intervals = new int[][] { new int[] { 1, 3 }, new int[] { 6, 9 } };
        int[] newInterval = new int[] { 2, 5 };

        int[][] result = solution.Insert(intervals, newInterval);

        Console.WriteLine("Merged Intervals:");
        foreach (int[] interval in result)
        {
            Console.WriteLine($"[{interval[0]}, {interval[1]}]");
        }  
    }
}