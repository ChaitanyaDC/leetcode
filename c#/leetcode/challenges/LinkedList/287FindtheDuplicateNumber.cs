namespace leetcode.challenges.LinkedList._287FindtheDuplicateNumber;

using System;
using System.Collections.Generic;

public class Solution {
    public int FindDuplicate(int[] nums) {
        int slow = 0;
        int fast = 0;
        // Move fast and slow
        while (true) {
            slow = nums[slow];
            fast = nums[nums[fast]];
            // Break on intersection
            if (slow == fast) {
                break;
            }
        }
        // Initialize another slow pointer for the start of the array
        int slow2 = 0;
        // Return on intersection
        while (true) {
            slow = nums[slow];
            slow2 = nums[slow2];
            if (slow == slow2) {
                return slow;
            }
        }
    }
}


public static class _287FindtheDuplicateNumber {

    public static void Test() {
        int[] nums = {1, 3, 4, 2, 2};
        Solution solution = new Solution();
        int result = solution.FindDuplicate(nums);
        Console.WriteLine(result);
    }
}