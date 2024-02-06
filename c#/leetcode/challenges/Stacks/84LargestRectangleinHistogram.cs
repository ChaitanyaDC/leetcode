namespace leetcode.challenges.Stacks._84LargestRectangleinHistogram;

using System;
using System.Collections.Generic;

public class Solution {
    public int LargestRectangleArea(int[] heights) {
      int maxArea = 0;
        Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>(); // Pair: (index, height)

        for (int i = 0; i < heights.Length; i++)
        {
            int start = i;
            while (stack.Count > 0 && stack.Peek().Item2 > heights[i])
            {
                Tuple<int, int> item = stack.Pop();
                maxArea = Math.Max(maxArea, item.Item2 * (i - item.Item1));
                start = item.Item1;
            }
            stack.Push(new Tuple<int, int>(start, heights[i]));
        }

        foreach (Tuple<int, int> item in stack)
        {
            maxArea = Math.Max(maxArea, item.Item2 * (heights.Length - item.Item1));
        }

        return maxArea;  
    }
}

public static class _84LargestRectangleinHistogram {

    public static void Test() {
        Solution solution = new Solution();
        int[] heights = { 2, 1, 5, 6, 2, 3 };
        // int[] heights = [2,4];
        int result = solution.LargestRectangleArea(heights);
        Console.WriteLine("Largest Rectangle Area: " + result);
    }
}