namespace leetcode.challenges.Stacks._155MinStack;

using System;
using System.Collections.Generic;

public class MinStack
{
    Stack<int> stack;
    Stack<int> minStack;

    public MinStack()
    {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }

    public void Push(int val)
    {
        stack.Push(val);

        if (minStack.Count > 0)
        {
            val = Math.Min(val, minStack.Peek());
        }

        minStack.Push(val);
    }

    public void Pop()
    {
        stack.Pop();
        minStack.Pop();
    }

    public int Top()
    {
        Console.WriteLine(stack.Peek());
        return stack.Peek();
    }

    public int GetMin()
    {
        Console.WriteLine(minStack.Peek());
        return minStack.Peek();
    }
}


public static class _155MinStack {

    public static void Test() {
        
        MinStack obj = new MinStack();
        obj.Push(-2);
        obj.Push(4);
        obj.Pop();
        /////
        ///
        int topValue = obj.Top();
        int minValue = obj.GetMin();

        Console.WriteLine("Top value: " + topValue);
        Console.WriteLine("Min value: " + minValue);
    }
}