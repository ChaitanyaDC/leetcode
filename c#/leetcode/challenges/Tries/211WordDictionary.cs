namespace leetcode.challenges.Tries._211WordDictionary;

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
}

public class WordDictionary
{
    private TrieNode root;

    public WordDictionary()
    {
        root = new TrieNode();
    }

    public void AddWord(string word)
    {
        TrieNode current = root;
        foreach (char c in word)
        {
            if (!current.Children.ContainsKey(c))
                current.Children[c] = new TrieNode();
            current = current.Children[c];
        }
        current.EndOfWord = true;
    }

    public bool Search(string word)
    {
        return DFS(word, root);
    }

    private bool DFS(string word, TrieNode node)
    {
        TrieNode current = node;
        foreach (char c in word)
        {
            if (c == '.')
            {
                foreach (TrieNode child in current.Children.Values)
                {
                    if (DFS(word.Substring(word.IndexOf(c) + 1), child))
                        return true;
                }
                return false;
            }
            else
            {
                if (!current.Children.ContainsKey(c))
                    return false;
                current = current.Children[c];
            }
        }
        return current.EndOfWord;
    }
}


public static class _211WordDictionary {

    public static void Test() {
        
       WordDictionary wordDictionary = new WordDictionary();

        // Add words to the dictionary
        wordDictionary.AddWord("bad");
        wordDictionary.AddWord("dad");
        wordDictionary.AddWord("mad");

        // Search for words in the dictionary
        Console.WriteLine(wordDictionary.Search("pad")); // Output: False
        Console.WriteLine(wordDictionary.Search("bad")); // Output: True
        Console.WriteLine(wordDictionary.Search(".ad")); // Output: True
        Console.WriteLine(wordDictionary.Search("b..")); //   
    }
}