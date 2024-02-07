namespace leetcode.challenges.LinkedList._146LRUCache;

using System;
using System.Collections.Generic;

public class LRUCache {
    private int capacity;
    private Dictionary<int, Node> cache;
    private Node left;
    private Node right;

    public LRUCache(int capacity) {
        this.capacity = capacity;
        this.cache = new Dictionary<int, Node>();
        this.left = new Node(0, 0);
        this.right = new Node(0, 0);
        this.left.next = this.right;
        this.right.prev = this.left;
    }

    private void Remove(Node node) {
        node.prev.next = node.next;
        node.next.prev = node.prev;
    }

    private void Insert(Node node) {
        node.prev = this.right.prev;
        node.next = this.right;
        this.right.prev.next = node;
        this.right.prev = node;
    }

    public int Get(int key) {
        if (this.cache.ContainsKey(key)) {
            Node node = this.cache[key];
            this.Remove(node);
            this.Insert(node);
            return node.val;
        }
        return -1;
    }

    public void Put(int key, int value) {
        if (this.cache.ContainsKey(key)) {
            Node node = this.cache[key];
            node.val = value;
            this.Remove(node);
            this.Insert(node);
        } else {
            if (this.cache.Count >= this.capacity) {
                Node lru = this.left.next;
                this.Remove(lru);
                this.cache.Remove(lru.key);
            }
            Node newNode = new Node(key, value);
            this.cache[key] = newNode;
            this.Insert(newNode);
        }
    }
}

public class Node {
    public int key;
    public int val;
    public Node prev;
    public Node next;

    public Node(int key, int val) {
        this.key = key;
        this.val = val;
    }
}
public static class _146LRUCache {

    public static void Test() {
        LRUCache lru = new LRUCache(2);
        lru.Put(1, 1);
        lru.Put(2, 2);
        Console.WriteLine(lru.Get(1)); // Output: 1
        lru.Put(3, 3);
        Console.WriteLine(lru.Get(2)); // Output: -1
        lru.Put(4, 4);
        Console.WriteLine(lru.Get(1)); // Output: -1
        Console.WriteLine(lru.Get(3)); // Output: 3
        Console.WriteLine(lru.Get(4)); // Output: 4
    }
}