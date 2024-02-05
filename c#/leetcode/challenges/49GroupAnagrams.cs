namespace leetcode.challenges._49GroupAnagrams;
using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, IList<string>> res = new();
        foreach (var s in strs) {
            int[] count = new int[26];
            foreach (var c in s) {
                count[c - 'a']++;
            }
            string key = string.Join(",", count);
            if (!res.ContainsKey(key)) {
                res[key] = new List<string>();
            }
            res[key].Add(s);
        }
        return [.. res.Values];
    }
}

public static class _49GroupAnagrams {

    public static void Test() {

        string[] strs = ["eat","tea","tan","ate","nat","bat"];


        Solution sol = new();
        IList<IList<string>> res = sol.GroupAnagrams(strs);
        foreach(var r in res){
            string s = string.Join(",", r);
            Console.WriteLine(s);
        }
    }
}