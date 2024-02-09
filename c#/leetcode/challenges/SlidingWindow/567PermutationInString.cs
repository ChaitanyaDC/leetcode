namespace leetcode.challenges.SlidingWindow._567PermutationInString;

using System;
using System.Collections.Generic;

public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length)
            return false;

        int[] s1Count = new int[26];
        int[] s2Count = new int[26];

        for (int i = 0; i < s1.Length; i++)
        {
            s1Count[s1[i] - 'a']++;
            s2Count[s2[i] - 'a']++;
        }

        int matches = 0;
        for (int i = 0; i < 26; i++)
        {
            matches += (s1Count[i] == s2Count[i]) ? 1 : 0;
        }

        int l = 0;
        for (int r = s1.Length; r < s2.Length; r++)
        {
            if (matches == 26)
                return true;

            int index = s2[r] - 'a';
            s2Count[index]++;

            if (s1Count[index] == s2Count[index])
                matches++;
            else if (s1Count[index] + 1 == s2Count[index])
                matches--;

            index = s2[l] - 'a';
            s2Count[index]--;

            if (s1Count[index] == s2Count[index])
                matches++;
            else if (s1Count[index] - 1 == s2Count[index])
                matches--;

            l++;
        }

        return matches == 26;
    }
}
public static class _567PermutationInString {

    public static void Test() {
        Solution solution = new Solution();
        // string s1 = "ab";
        // string s2 = "eidboaooo";
        string s1 = "ab";
        string s2 = "eidboaoo";
        Console.WriteLine(solution.CheckInclusion(s1, s2));
    }
}