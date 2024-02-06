namespace leetcode.challenges.TwoPointers._153Sum;

// array is sorted
public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            int left = i + 1, right = nums.Length - 1;

            while (left < right)
            {
                int threeSum = nums[i] + nums[left] + nums[right];

                if (threeSum > 0)
                {
                    right--;
                }
                else if (threeSum < 0)
                {
                    left++;
                }
                else
                {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });

                    left++;

                    while (left < right && nums[left] == nums[left - 1])
                    {
                        left++;
                    }
                }
            }
        }

        return result;
    }
}

public static class _153Sum {

    public static void Test() {
        int[] nums = nums = [-1,0,1,2,-1,-4];
        // int[] nums = { 0, 0, 0 };
        IList<IList<int>> result = new Solution().ThreeSum(nums);

        Console.WriteLine($"Three sum combinations for {string.Join(",",nums)}:");
        foreach (var triplet in result)
        {
            Console.WriteLine($"[{string.Join(", ", triplet)}]");
        }
    }
}