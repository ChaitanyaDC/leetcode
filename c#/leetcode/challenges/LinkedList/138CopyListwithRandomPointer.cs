namespace leetcode.challenges.LinkedList._138CopyListwithRandomPointer;

using System;
using System.Collections.Generic;

public class Node {
    public int val;
    public Node next;
    public Node random;

    public Node(int val = 0, Node next = null, Node random = null) {
        this.val = val;
        this.next = next;
        this.random = random;
    }
}

public class Solution {
    public Node CopyRandomList(Node head) {
        if (head == null) {
            return null;
        }

        Dictionary<Node, Node> oldToNew = new Dictionary<Node, Node>();
        
        Node curr = head;
        while (curr != null) {
            oldToNew[curr] = new Node(curr.val);
            curr = curr.next;
        }
        
        curr = head;
        while (curr != null) {
            oldToNew[curr].next = curr.next != null ? oldToNew[curr.next] : null;
            oldToNew[curr].random = curr.random != null ? oldToNew[curr.random] : null;
            curr = curr.next;
        }
        
        return oldToNew[head];
    }
}


public static class _138CopyListwithRandomPointer {

    public static void Test() {
        // Input data
        int[][] input = new int[][] {
            new int[] { 7, -1 },
            new int[] { 13, 0 },
            new int[] { 11, 4 },
            new int[] { 10, 2 },
            new int[] { 1, 0 }
        };

        // Construct the linked list from the input
        Node[] nodes = new Node[input.Length];
        for (int i = 0; i < input.Length; i++) {
            nodes[i] = new Node(input[i][0]);
        }

        for (int i = 0; i < input.Length; i++) {
            int[] pair = input[i];
            if (pair[1] != -1) {
                nodes[i].random = nodes[pair[1]];
            }
            if (i < input.Length - 1) {
                nodes[i].next = nodes[i + 1];
            }
        }

        // Create an instance of Solution class
        Solution solution = new Solution();
        
        // Call the method to copy the linked list
        Node copiedList = solution.CopyRandomList(nodes[0]);

        // Output the copied list for verification
        while (copiedList != null) {
            Console.Write($"[{copiedList.val}, {(copiedList.random != null ? copiedList.random.val.ToString() : "null")}] ");
            copiedList = copiedList.next;
        }
    }
}