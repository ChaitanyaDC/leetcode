namespace leetcode.challenges.Tries._212WordSearchII;

using System;
using System.Collections.Generic;

public class TrieNode
{
    public Dictionary<char, TrieNode> Children { get; private set; }
    public bool EndOfWord { get; set; }

    public TrieNode()
    {
        Children = new Dictionary<char, TrieNode>();
        EndOfWord = false;
    }

    public void AddWord(string word)
    {
        TrieNode current = this;
        foreach (char c in word)
        {
            if (!current.Children.ContainsKey(c))
                current.Children[c] = new TrieNode();
            current = current.Children[c];
        }
        current.EndOfWord = true;
    }
}
public class Solution {
    public IList<string> FindWords(char[][] board, string[] words) {
        TrieNode root = new TrieNode();
        foreach (string word in words)
        {
            root.AddWord(word);
        }

        int rows = board.Length;
        int columns = board[0].Length;

        HashSet<string> result = new HashSet<string>();
        HashSet<(int, int)> visited = new HashSet<(int, int)>();

        void DFS(int r, int c, TrieNode node, string word)
        {
            if (r < 0 || c < 0 || r == rows || c == columns || !node.Children.ContainsKey(board[r][c]) || visited.Contains((r, c)))
                return;

            visited.Add((r, c));
            node = node.Children[board[r][c]];
            word += board[r][c];

            if (node.EndOfWord)
                result.Add(word);

            DFS(r + 1, c, node, word);
            DFS(r - 1, c, node, word);
            DFS(r, c + 1, node, word);
            DFS(r, c - 1, node, word);

            visited.Remove((r, c));
        }

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < columns; c++)
            {
                DFS(r, c, root, "");
            }
        }

        return new List<string>(result);
    }
}



public static class _212WordSearchII {

    public static void Test() {
        
       char[][] board = {
            new char[] { 'o', 'a', 'a', 'n' },
            new char[] { 'e', 't', 'a', 'e' },
            new char[] { 'i', 'h', 'k', 'r' },
            new char[] { 'i', 'f', 'l', 'v' }
        };

        string[] words = { "oath", "pea", "eat", "rain" };

        Solution solution = new Solution();
        IList<string> result = solution.FindWords(board, words);

        Console.WriteLine("Found words:");
        foreach (string word in result)
        {
            Console.WriteLine(word);
        }
    }
}