namespace leetcode.challenges.TwoPointers._42TrappingRainWater;

public class Solution {
    public int Trap(int[] height) {
        if (height == null || height.Length == 0)
        {
            return 0;
        }

        int left = 0, right = height.Length - 1;
        int leftMax = height[left], rightMax = height[right];
        int trappedWater = 0;

        while (left < right)
        {
            if (leftMax < rightMax)
            {
                left++;
                leftMax = Math.Max(leftMax, height[left]);
                trappedWater += leftMax - height[left];
            }
            else
            {
                right--;
                rightMax = Math.Max(rightMax, height[right]);
                trappedWater += rightMax - height[right];
            }
        }

        return trappedWater;
    }
}

public static class _42TrappingRainWater {

    public static void Test() {
        int[] height = height = [0,1,0,2,1,0,1,3,2,1,2,1];
        // int[] height = { 4, 2, 0, 3, 2, 5 };
        int result = new Solution().Trap(height);
        Console.WriteLine($"Total trapped water for {string.Join(",", height)}: \n" + result);
    }
}

