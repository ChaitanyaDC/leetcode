namespace leetcode.challenges.SlidingWindow._76MinimumWindowSubstring;

using System;
using System.Collections.Generic;

public class Solution {
    public string MinWindow(string s, string t) {
        if (t == "")
            return "";

        Dictionary<char, int> countT = new Dictionary<char, int>();
        Dictionary<char, int> window = new Dictionary<char, int>();
        foreach (char c in t)
        {
            if (countT.ContainsKey(c))
                countT[c]++;
            else
                countT[c] = 1;
        }

        int have = 0;
        int need = countT.Count;
        int[] res = new int[] { -1, -1 };
        int resLen = int.MaxValue;

        int l = 0;
        for (int r = 0; r < s.Length; r++)
        {
            char c = s[r];
            if (window.ContainsKey(c))
                window[c]++;
            else
                window[c] = 1;

            if (countT.ContainsKey(c) && window[c] == countT[c])
                have++;

            while (have == need)
            {
                if (r - l + 1 < resLen)
                {
                    res[0] = l;
                    res[1] = r;
                    resLen = r - l + 1;
                }

                window[s[l]]--;
                if (countT.ContainsKey(s[l]) && window[s[l]] < countT[s[l]])
                    have--;

                l++;
            }
        }

        int left = res[0], right = res[1];
        return (resLen != int.MaxValue) ? s.Substring(left, right - left + 1) : "";
    }
}


public static class _76MinimumWindowSubstring {

    public static void Test() {
        Solution solution = new Solution();
        // string s = "a";
        // string t = "aa";
        string s = "ADOBECODEBANC";
        string t = "ABC";
        Console.WriteLine(solution.MinWindow(s, t));
    }
}