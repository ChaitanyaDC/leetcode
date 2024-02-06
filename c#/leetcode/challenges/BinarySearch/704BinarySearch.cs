namespace leetcode.challenges.BinarySearch._704BinarySearch;

using System;
using System.Collections.Generic;

public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                return mid; // Target found
            }
            else if (nums[mid] < target)
            {
                left = mid + 1; // Search right half
            }
            else
            {
                right = mid - 1; // Search left half
            }
        }

        return -1;
    }
}

public static class _704BinarySearch {

    public static void Test() {
        Solution solution = new Solution();
        // int[] nums = { -1, 0, 3, 5, 9, 12 };
        // int target = 9;
        int[] nums = [-1,0,3,5,9,12];
        int target = 2;
        int result = solution.Search(nums, target);
        Console.WriteLine("Index of target: " + result);
    }
}