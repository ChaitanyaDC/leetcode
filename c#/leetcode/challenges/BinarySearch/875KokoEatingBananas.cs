namespace leetcode.challenges.BinarySearch._875KokoEatingBananas;

using System;
using System.Collections.Generic;
public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l = 1;
        int r = piles.Max();

        while (l < r)
        {
            int mid = (l + r) / 2;
            int c = 0;

            foreach (int j in piles)
            {
                // j-1 for 6/3 which is 2
                //  this is incorrect as we are adding one to the op
                //  so minus one to get answer 1 and then we add 1 which makes it 2
                c += (j - 1) / mid + 1;
            }

            if (c > h)
            {
                l = mid + 1;
            }
            else
            {
                r = mid;
            }
        }

        return l;
    }
}
public static class _875KokoEatingBananas {

    public static void Test() {
        Solution solution = new Solution();
        // int[] piles = { 3, 6, 7, 11 };
        // int h = 8;
        int[] piles = [30,11,23,4,20];
        int h = 6;
        int result = solution.MinEatingSpeed(piles, h);
        Console.WriteLine("Minimum eating speed: " + result);
    }
}