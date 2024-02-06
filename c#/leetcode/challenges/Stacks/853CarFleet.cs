namespace leetcode.challenges.Stacks._853CarFleet;

using System;
using System.Collections.Generic;

public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int fleetCount = 0;
        double prevArrivalTime = 0;

        // Create pairs of position and speed, then sort them based on position (in descending order)
        List<Tuple<int, int>> pairs = new List<Tuple<int, int>>();
        for (int i = 0; i < position.Length; i++)
        {
            pairs.Add(new Tuple<int, int>(position[i], speed[i]));
        }
        pairs.Sort((x, y) => y.Item1.CompareTo(x.Item1)); // Sort in descending order of position

        foreach (Tuple<int, int> pair in pairs)
        {
            double arrivalTime = (double)(target - pair.Item1) / pair.Item2; // Time to arrive at target
            if (prevArrivalTime < arrivalTime)
            {
                fleetCount++;
                prevArrivalTime = arrivalTime;
            }
        }

        return fleetCount;
    }
}

public static class _853CarFleet {

    public static void Test() {
        Solution solution = new Solution();
        // int target = 12;
        // int[] position = { 10, 8, 0, 5, 3 };
        // int[] speed = { 2, 4, 1, 1, 3 };
        int target = 100; 
        int[] position = [0,2,4];
        int[] speed = [4,2,1];
        int result = solution.CarFleet(target, position, speed);
        Console.WriteLine("Number of car fleets: " + result);
    }
}