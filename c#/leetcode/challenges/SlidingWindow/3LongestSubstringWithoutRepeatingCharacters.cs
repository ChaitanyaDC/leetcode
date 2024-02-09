namespace leetcode.challenges.SlidingWindow._3LongestSubstringWithoutRepeatingCharacters;

using System;
using System.Collections.Generic;

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> charSet = new HashSet<char>();
        int l = 0, res = 0;
        for (int r = 0; r < s.Length; r++)
        {
            while (charSet.Contains(s[r]))
            {
                charSet.Remove(s[l]);
                l++;
            }
            charSet.Add(s[r]);
            res = Math.Max(res, r - l + 1);
        }
        return res;
    }
}
public static class _3LongestSubstringWithoutRepeatingCharacters {

    public static void Test() {
        Solution solution = new Solution();
        // string s = "abcbcbb";
        string s = "pwwkew";
        Console.WriteLine(solution.LengthOfLongestSubstring(s));
    }
}