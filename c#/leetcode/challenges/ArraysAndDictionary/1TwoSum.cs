namespace leetcode.challenges.ArraysAndDictionary._1TwoSum;
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numsDict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int diff = target - nums[i];
            if (numsDict.ContainsKey(diff)) {
                return [numsDict[diff], i];
            } else {
                numsDict[nums[i]] = i;
            }
        }
        return [];
    }
}

public static class _1TwoSum {

    public static void Test() {
        // int[] nums = [2,7,11,15];
        // int target = 9;

        int[] nums = [3,2,4];
        int target = 6;
        // int[] nums = [3,3];
        // int[] target = 6;

        Solution sol = new();
        int[] res = sol.TwoSum(nums, target);
        Console.WriteLine(string.Join(",", res));
    }
}