namespace leetcode.challenges.BinarySearch._4MedianofTwoSortedArrays;

using System;
using System.Collections.Generic;

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] A, B;
        int total = nums1.Length + nums2.Length;
        int half = total / 2;

        if (nums2.Length < nums1.Length) {
            A = nums2;
            B = nums1;
        } else {
            A = nums1;
            B = nums2;
        }

        int l = 0, r = A.Length - 1;
        while (true) {
            int i = (l + r) / 2;
            int j = half - i - 2;

            int Aleft = i >= 0 ? A[i] : int.MinValue;
            int Aright = (i + 1) < A.Length ? A[i + 1] : int.MaxValue;
            int Bleft = j >= 0 ? B[j] : int.MinValue;
            int Bright = (j + 1) < B.Length ? B[j + 1] : int.MaxValue;

            if (Aleft <= Bright && Bleft <= Aright) {
                if (total % 2 != 0) {
                    return Math.Min(Aright, Bright);
                } else {
                    return (Math.Max(Aleft, Bleft) + Math.Min(Aright, Bright)) / 2.0;
                }
            } else if (Aleft > Bright) {
                r = i - 1;
            } else {
                l = i + 1;
            }
        }
    }
}


public static class _4MedianofTwoSortedArrays {

    public static void Test() {
        Solution solution = new Solution();
        int[] nums1 = { 1, 3 };
        int[] nums2 = { 2 };
        double result = solution.FindMedianSortedArrays(nums1, nums2);
        Console.WriteLine("Median: " + result);
    }
}