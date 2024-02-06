namespace leetcode.challenges.BinarySearch._981TimeBasedKeyValueStore;

using System;
using System.Collections.Generic;

public class TimeMap
{
    private Dictionary<string, List<Tuple<string, int>>> store;

    public TimeMap()
    {
        store = new Dictionary<string, List<Tuple<string, int>>>();
    }

    public void Set(string key, string value, int timestamp)
    {
        if (!store.ContainsKey(key))
        {
            store[key] = new List<Tuple<string, int>>();
        }
        store[key].Add(new Tuple<string, int>(value, timestamp));
    }

    public string Get(string key, int timestamp)
    {
        if (!store.ContainsKey(key))
        {
            return "";
        }

        List<Tuple<string, int>> values = store[key];
        int l = 0;
        int r = values.Count - 1;
        string res = "";

        // Binary search
        while (l <= r)
        {
            int m = (l + r) / 2;
            if (values[m].Item2 <= timestamp)
            {
                res = values[m].Item1;
                l = m + 1;
            }
            else
            {
                r = m - 1;
            }
        }

        return res;
    }
}


public static class _981TimeBasedKeyValueStore {

    public static void Test() {
        TimeMap timeMap = new TimeMap();
        timeMap.Set("foo", "bar", 1);
        Console.WriteLine(timeMap.Get("foo", 1)); // Output: bar
        Console.WriteLine(timeMap.Get("foo", 3)); // Output: bar
        timeMap.Set("foo", "bar2", 4);
        Console.WriteLine(timeMap.Get("foo", 4)); // Output: bar2
        Console.WriteLine(timeMap.Get("foo", 5)); // Output:
    }
}