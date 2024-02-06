namespace leetcode.challenges.TwoPointers._167TwoSumII;

// array is sorted
public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0, right = numbers.Length - 1;

        while (left < right)
        {
            int currentSum = numbers[left] + numbers[right];

            if (currentSum > target)
            {
                right--;
            }
            else if (currentSum < target)
            {
                left++;
            }
            else
            {
                return new int[] { left + 1, right + 1 };
            }
        }

        return new int[0];
    }
}

public static class _167TwoSumII {

    public static void Test() {
        // array is sorted
        int[] numbers = [2, 3, 4];
        int target = 6;
        int[] result = new Solution().TwoSum(numbers, target);

        if (result.Length > 0)
        {
            Console.WriteLine($"Indices of the two numbers {string.Join(',',numbers)} whose sum is equal to the target ({target}): [{result[0]}, {result[1]}]");
        }
        else
        {
            Console.WriteLine("No such indices found.");
        }
    }
}