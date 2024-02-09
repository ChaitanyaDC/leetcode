namespace leetcode.challenges.Intervals._919MeetingRoomsII;

using System;
using System.Collections.Generic;

public class Solution {
    public int MinMeetingRooms(int[][] intervals)
    {
        List<(int time, int count)> time = new List<(int, int)>();

        // Add start and end times to the list with count +1 for start and -1 for end
        foreach (int[] interval in intervals)
        {
            time.Add((interval[0], 1));
            time.Add((interval[1], -1));
        }

        // Sort the list based on time and count
        time.Sort((a, b) =>
        {
            if (a.Item1 != b.Item1)
                return a.Item1.CompareTo(b.Item1);
            else
                return a.Item2.CompareTo(b.Item2);
        });

        int count = 0;
        int maxCount = 0;

        // Iterate through the sorted list
        foreach ((int t, int countChange) in time)
        {
            count += countChange;
            maxCount = Math.Max(maxCount, count);
        }

        return maxCount;
    }
}

public static class _919MeetingRoomsII {

    public static void Test() {
        
        Solution solution = new Solution();
        int[][] intervals = new int[][] { new int[] { 0, 30 }, new int[] { 5, 10 }, new int[] { 15, 20 } };
        Console.WriteLine(solution.MinMeetingRooms(intervals));
    }
}