namespace leetcode.challenges.TwoPointers._11ContainerWithMostWater;

public class Solution {
    public int MaxArea(int[] height) {
        int maxArea = 0;
        int left = 0, right = height.Length - 1;

        while (left < right)
        {
            int h = Math.Min(height[left], height[right]);
            int w = right - left;
            int area = h * w;

            maxArea = Math.Max(maxArea, area);

            if (height[left] < height[right])
            {
                left++;
            }
            else if (height[left] > height[right])
            {
                right--;
            }
            else
            {
                // Either shift the left or right pointer if heights are the same
                // left++;
                right--;
            }
        }

        return maxArea; 
    }
}

public static class _11ContainerWithMostWater {

    public static void Test() {
        int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

        int result = new Solution().MaxArea(height);
        Console.WriteLine($"Max area of water for inpur {string.Join(",", height)}: " + result);
    }
}