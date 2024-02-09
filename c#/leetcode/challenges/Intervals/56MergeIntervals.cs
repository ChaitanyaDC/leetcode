namespace leetcode.challenges.Intervals._56MergeIntervals;

using System;
using System.Collections.Generic;

public class Solution {
    public int[][] Merge(int[][] intervals) {
        // sort according to the first number
        Array.Sort(intervals, (a, b) => a[0] - b[0]);
        // add first to the res
        List<int[]> output = new List<int[]>() { intervals[0] };

        for (int i = 1; i < intervals.Length; i++)
        {
            int start = intervals[i][0];
            int end = intervals[i][1];
            // get the last element of the output second digit
            int lastEnd = output[output.Count - 1][1];
            // if current start is less than or equal to the last end
            if (start <= lastEnd)
            {
                // merge
                output[output.Count - 1][1] = Math.Max(lastEnd, end);
            }
            else
            {
                // append to the result
                output.Add(new int[] { start, end });
            }
        }
        // return output
        return output.ToArray();
    }
}

public static class _56MergeIntervals {

    public static void Test() {
        
        Solution solution = new Solution();
        int[][] intervals = new int[][] { new int[] { 1, 3 }, new int[] { 2, 6 }, new int[] { 8, 10 }, new int[] { 15, 18 } };

        int[][] result = solution.Merge(intervals);

        Console.WriteLine("Merged Intervals:");
        foreach (int[] interval in result)
        {
            Console.WriteLine($"[{interval[0]}, {interval[1]}]");
        }
    }
}