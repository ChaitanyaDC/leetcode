namespace leetcode.challenges.SlidingWindow._424LongestRepeatingCharacterReplacement;

using System;
using System.Collections.Generic;

public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> count = new Dictionary<char, int>();
        int l = 0;
        int maxf = 0;

        for (int r = 0; r < s.Length; r++)
        {
            count[s[r]] = 1 + (count.ContainsKey(s[r]) ? count[s[r]] : 0);
            maxf = Math.Max(maxf, count[s[r]]);

            if ((r - l + 1) - maxf > k)
            {
                count[s[l]]--;
                l++;
            }
        }

        return (s.Length - l);
    }
}

public static class _424LongestRepeatingCharacterReplacement {

    public static void Test() {
        Solution solution = new Solution();
        string s = "AABABBA";
        int k = 1;
        Console.WriteLine(solution.CharacterReplacement(s, k));
    }
}