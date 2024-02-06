namespace leetcode.challenges.Stacks._22GenerateParentheses;

using System;
using System.Collections.Generic;

public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        IList<string> res = new List<string>();
        GenerateParenthesisHelper(n, 0, 0, new char[2 * n], 0, res);
        return res;
    }

    private void GenerateParenthesisHelper(int n, int open, int close, char[] current, int pos, IList<string> res)
    {
        if (pos == current.Length)
        {
            res.Add(new string(current));
            return;
        }

        if (open < n)
        {
            current[pos] = '(';
            GenerateParenthesisHelper(n, open + 1, close, current, pos + 1, res);
        }

        if (close < open)
        {
            current[pos] = ')';
            GenerateParenthesisHelper(n, open, close + 1, current, pos + 1, res);
        }
    }
    
    
}
public static class _22GenerateParentheses {

    public static void Test() {
        
       Solution solution = new Solution();
        int n = 3;
        IList<string> result = solution.GenerateParenthesis(n);
        foreach (string str in result)
        {
            Console.WriteLine(str);
        }
    }
}