namespace leetcode.challenges.LinkedList._206ReverseLinkedList;

using System;
using System.Collections.Generic;

public class ListNode {
    public int val;
    public ListNode next;
    
    public ListNode(int val = 0, ListNode next = null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode ReverseList(ListNode head) {
        // Iterative approach
        ListNode prev = null;
        ListNode curr = head;
        
        while (curr != null) {
            ListNode nextNode = curr.next;
            curr.next = prev;
            prev = curr;
            curr = nextNode;
        }
        
        return prev;
    }
}


public static class _206ReverseLinkedList {

    public static void Test() {
        ListNode head = new ListNode(0);
        head.next = new ListNode(1);
        head.next.next = new ListNode(2);
        head.next.next.next = new ListNode(3);
        
        Console.WriteLine("Original LinkedList:");
        ListNode current = head;
        while (current != null) {
            Console.Write(current.val + " ");
            current = current.next;
        }
        
        Solution solution = new Solution();
        ListNode reversedHead = solution.ReverseList(head);
        
        Console.WriteLine("\nReversed LinkedList:");
        current = reversedHead;
        while (current != null) {
            Console.Write(current.val + " ");
            current = current.next;
        }
    }
}