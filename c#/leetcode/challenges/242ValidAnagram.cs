namespace leetcode.challenges._242ValidAnagram;

public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        Dictionary<char, int> dictS = new Dictionary<char, int>();
        Dictionary<char, int> dictT = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++) {
            if (dictS.ContainsKey(s[i])) {
                dictS[s[i]]++;
            } else {
                dictS[s[i]] = 1;
            }
            
            if (dictT.ContainsKey(t[i])) {
                dictT[t[i]]++;
            } else {
                dictT[t[i]] = 1;
            }
        }
        foreach (var chs in dictS.Keys) {
            if (!dictT.ContainsKey(chs) || dictS[chs] != dictT[chs]) {
                return false;
            }
        }
        return true;
    }
}

public static class _242ValidAnagram {

    public static void Test() {
        // string s = "anagram";
        // string t = "nagaram";
        string s = "car";
        string t = "rat";
        Solution sol = new();
        bool res = sol.IsAnagram(s, t);
        Console.WriteLine(res);
    }
}