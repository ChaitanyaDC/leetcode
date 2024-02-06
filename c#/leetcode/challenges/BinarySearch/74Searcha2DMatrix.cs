namespace leetcode.challenges.BinarySearch._74Searcha2DMatrix;

using System;
using System.Collections.Generic;

public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        if (matrix == null || matrix.Length == 0)
            return false;

        int m = matrix.Length;
        int n = matrix[0].Length;
        int left = 0;
        int right = m * n - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int midRow = mid / n;
            int midCol = mid % n;

            if (matrix[midRow][midCol] == target)
            {
                return true;
            }
            else if (matrix[midRow][midCol] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return false;
    }
}
public static class _74Searcha2DMatrix {

    public static void Test() {
        Solution solution = new Solution();
        // int[][] matrix = new int[][]
        // {
        //     new int[] { 1, 3, 5, 7 },
        //     new int[] { 10, 11, 16, 20 },
        //     new int[] { 23, 30, 34, 60 }
        // };
        // int target = 3;
        int[][] matrix = new int[][]
        {
            new int[] { 1, 3, 5, 7 },
            new int[] { 10, 11, 16, 20 },
            new int[] { 23, 30, 34, 60 }
        };
        int target = 13;
        bool result = solution.SearchMatrix(matrix, target);
        Console.WriteLine("Target found: " + result);
    }
}