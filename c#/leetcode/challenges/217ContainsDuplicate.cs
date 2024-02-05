namespace leetcode.challenges._217ContainsDuplicate;

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> dictNum = new HashSet<int>();
        foreach (int i in nums) {
            if (dictNum.Contains(i)) {
                return true;
            }
            dictNum.Add(i);
        }
        return false;
    }
}

public static class _217ContainsDuplicate {

    public static void Test() {
        var nums = new int[4]{1,2,3,1};
        var sol = new Solution();
        var res = sol.ContainsDuplicate(nums);
        Console.WriteLine(res);
    }
}