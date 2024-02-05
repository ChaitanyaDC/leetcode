namespace leetcode.challenges._347TopKFrequentElements;
public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dictCount = new Dictionary<int, int>();
        List<List<int>> freq = new(new List<int>[nums.Length + 1]);
        
        foreach (int num in nums) {
            if (dictCount.ContainsKey(num)) {
                dictCount[num]++;
            } else {
                dictCount[num] = 1;
            }
        }
        
        foreach (var pair in dictCount) {
            int count = pair.Value;
            if (freq[count] == null) {
                freq[count] = new List<int>();
            }
            freq[count].Add(pair.Key);
        }
        
        List<int> res = new List<int>();
        for (int i = freq.Count - 1; i > 0 ; i--) {
            if (freq[i] != null) {
                foreach (int num in freq[i]) {
                    res.Add(num);
                    if (res.Count == k) {
                        return [.. res];
                    }
                }
            }
        }
        
        return [.. res];
    }
}

public static class _347TopKFrequentElements {

    public static void Test() {
        int[] nums = [1,1,1,2,2,3];
        int k = 2;
        // int[] nums = [1];
        // int k = 1;

        Solution sol = new();
        int[] res = sol.TopKFrequent(nums, k);
        Console.WriteLine(string.Join(",", res));
    }
}