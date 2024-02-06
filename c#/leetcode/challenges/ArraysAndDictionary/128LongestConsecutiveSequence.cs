namespace leetcode.challenges.ArraysAndDictionary._128LongestConsecutiveSequence;
public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numSet = new HashSet<int>(nums);
        int count = 0;

        foreach (int n in nums)
        {
            if (!numSet.Contains(n - 1))
            {
                int length = 0;
                while (numSet.Contains(n + length))
                {
                    length++;
                }
                count = Math.Max(count, length);
            }
        }

        return count;
    }
}
public static class _128LongestConsecutiveSequence {

    public static void Test() {
        // int[] nums = [100, 4, 200, 1, 3, 2];
        int[] nums = nums = [0,3,7,2,5,8,4,6,0,1];
        int result = new Solution().LongestConsecutive(nums);
        Console.WriteLine("The length of the longest consecutive sequence is: " + result);
    }
}
