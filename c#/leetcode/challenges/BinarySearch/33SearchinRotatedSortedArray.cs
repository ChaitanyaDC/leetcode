namespace leetcode.challenges.BinarySearch._33SearchinRotatedSortedArray;

using System;
using System.Collections.Generic;

public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0;
        int r = nums.Length - 1;

        while (l <= r) {
            int mid = (l + r) / 2;

            if (nums[mid] == target) {
                return mid;
            }

            // Left sorted portion
            if (nums[l] <= nums[mid]) {
                if (target > nums[mid] || target < nums[l]) {
                    l = mid + 1;
                } else {
                    r = mid - 1;
                }
            }
            // Right sorted portion
            else {
                if (target < nums[mid] || target > nums[r]) {
                    r = mid - 1;
                } else {
                    l = mid + 1;
                }
            }
        }

        return -1;
    }
}


public static class _33SearchinRotatedSortedArray {

    public static void Test() {
        Solution solution = new Solution();
        // int[] nums = [4,5,6,7,0,1,2];
        // int target = 3;
        int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
        int target = 0;
        int result = solution.Search(nums, target);
        Console.WriteLine("Index of target: " + result);
    }
}