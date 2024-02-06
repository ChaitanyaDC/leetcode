namespace leetcode.challenges.Stacks._739DailyTemperatures;

using System;
using System.Collections.Generic;

public class Solution {
    public int EvalRPN(string[] tokens) {
         Stack<int> stack = new Stack<int>();

        foreach (string token in tokens)
        {
            if (token == "+")
            {
                int res = stack.Pop() + stack.Pop();
                stack.Push(res);
            }
            else if (token == "-")
            {
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push(b - a);
            }
            else if (token == "*")
            {
                int res = stack.Pop() * stack.Pop();
                stack.Push(res);
            }
            else if (token == "/")
            {
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push(b / a);
            }
            else
            {
                stack.Push(int.Parse(token));
            }
        }

        return stack.Pop();
    }
}

public static class _739DailyTemperatures {

    public static void Test() {
        
        Solution solution = new Solution();
        // string[] tokens = { "4", "13", "5", "/", "+" };
        string[] tokens = ["2","1","+","3","*"];
        int result = solution.EvalRPN(tokens);
        Console.WriteLine("Result: " + result);
    }
}