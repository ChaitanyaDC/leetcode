namespace leetcode.challenges.Stacks._20ValidParentheses;

using System;
using System.Collections.Generic;

public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> closeToOpen = new Dictionary<char, char>
        {
            {')', '('},
            {'}', '{'},
            {']', '['}
        };

        foreach (char ch in s)
        {
            if (closeToOpen.ContainsKey(ch))
            {
                if (stack.Count > 0 && stack.Peek() == closeToOpen[ch])
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                stack.Push(ch);
            }
        }

        return stack.Count == 0;
    }
}

public static class _20ValidParentheses {

    public static void Test() {
        // string s = "()";
        string s = "(]";
        // string s = "()[]{}";
        bool result = new Solution().IsValid(s);
        Console.WriteLine($"Is the string \"{string.Join(",", s)}\" valid : " + result);
    }
}