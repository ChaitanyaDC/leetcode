namespace leetcode.challenges.Tries._208ImplementTrie;

using System;
using System.Collections.Generic;

public class TrieNode {
    public Dictionary<char, TrieNode> Children;
    public bool EndOfWord ;

    public TrieNode() {
        Children = new Dictionary<char, TrieNode>();
        EndOfWord = false;
    }
}

public class Trie {
    private TrieNode root;

    public Trie() {
        root = new TrieNode();
    }

    public void Insert(string word) {
        TrieNode current = root;
        foreach (char c in word) {
            if (!current.Children.ContainsKey(c)) {
                current.Children[c] = new TrieNode();
            }
            current = current.Children[c];
        }
        current.EndOfWord = true;
    }

    public bool Search(string word) {
        TrieNode current = root;
        foreach (char c in word) {
            if (!current.Children.ContainsKey(c)) {
                return false;
            }
            current = current.Children[c];
        }
        return current.EndOfWord;
    }

    public bool StartsWith(string prefix) {
        TrieNode current = root;
        foreach (char c in prefix) {
            if (!current.Children.ContainsKey(c)) {
                return false;
            }
            current = current.Children[c];
        }
        return true;
    }
}

public static class _208ImplementTrie {

    public static void Test() {
        
        Trie trie = new Trie();
        trie.Insert("apple");
        Console.WriteLine(trie.Search("apple"));   // return True
        Console.WriteLine(trie.Search("app"));     // return False
        Console.WriteLine(trie.StartsWith("app")); // return True
        trie.Insert("app");
        Console.WriteLine(trie.Search("app"));     
    }
}