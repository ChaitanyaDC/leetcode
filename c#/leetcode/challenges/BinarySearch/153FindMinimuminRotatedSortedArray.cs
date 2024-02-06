namespace leetcode.challenges.BinarySearch._153FindMinimuminRotatedSortedArray;

using System;
using System.Collections.Generic;

public class Solution {
    public int FindMin(int[] nums) {
        int l = 0;
        int r = nums.Length - 1;
        int res = nums[0]; // Set the initial result to the first element

        while (l <= r)
        {
            // If the array is sorted, return the leftmost element
            if (nums[l] < nums[r])
            {
                res = Math.Min(res, nums[l]);
                break;
            }

            int m = (l + r) / 2;

            // Update the result with the middle element
            res = Math.Min(res, nums[m]);

            // If the middle element is greater than or equal to the leftmost element,
            // search in the right half
            if (nums[m] >= nums[l])
            {
                l = m + 1;
            }
            // Otherwise, search in the left half
            else
            {
                r = m - 1;
            }
        }

        return res;
    }
}


public static class _153FindMinimuminRotatedSortedArray {

    public static void Test() {
        Solution solution = new Solution();
        int[] nums = { 3, 4, 5, 0, 1, 2 };
        int result = solution.FindMin(nums);
        Console.WriteLine("Minimum element: " + result);
    }
}