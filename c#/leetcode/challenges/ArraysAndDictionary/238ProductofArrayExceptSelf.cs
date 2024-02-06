namespace leetcode.challenges.ArraysAndDictionary._238ProductofArrayExceptSelf;

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
       int[] res = new int[nums.Length];
        Array.Fill(res, 1);
        int prefix = 1;
        for (int i = 0; i < nums.Length; i++) {
            res[i] = prefix;
            prefix *= nums[i];
        }
        int postfix = 1;
        for (int j = nums.Length - 1; j >= 0; j--) {
            res[j] *= postfix;
            postfix *= nums[j];
        }
        return res; 
    }
}

public static class _238ProductofArrayExceptSelf {

    public static void Test() {

        // int[] nums = [1,2,3,4];
        int[] nums = [-1,1,0,-3,3];
        Solution sol = new();
        int[] res = sol.ProductExceptSelf(nums);
        Console.WriteLine($"Input:{string.Join(",", nums)}");
        Console.WriteLine($"Output:{string.Join(",", res)}");
    }
}