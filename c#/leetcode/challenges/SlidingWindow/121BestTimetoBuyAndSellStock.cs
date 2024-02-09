namespace leetcode.challenges.SlidingWindow._121BestTimetoBuyAndSellStock;

using System;
using System.Collections.Generic;

public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0, r = 1;
        int maxP = 0;

        while (r < prices.Length)
        {
            // Check if the current price is less than the next price
            if (prices[l] < prices[r])
            {
                int profit = prices[r] - prices[l];
                maxP = Math.Max(maxP, profit);
            }
            else
            {
                // Update the left pointer to the current position (i.e., skip the non-profitable interval)
                l = r;
            }
            r++;
        }
        return maxP;
    }
}

public static class _121BestTimetoBuyAndSellStock {

    public static void Test() {
        Solution solution = new Solution();
        // int[] prices = { 7, 1, 5, 3, 6, 4 };
        int[] prices = [7,6,4,3,1];
        Console.WriteLine(solution.MaxProfit(prices));
    }
}