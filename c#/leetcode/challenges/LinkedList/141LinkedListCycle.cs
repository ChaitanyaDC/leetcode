namespace leetcode.challenges.LinkedList._141LinkedListCycle;

using System;
using System.Collections.Generic;

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) {
        val = x;
        next = null;
    }
}

public class Solution {
    public bool HasCycle(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
        // Check if fast and fast.next are not null to handle edge cases
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast) {
                return true;
            }
        }
        return false;
    }
}

public static class _141LinkedListCycle {

    public static void Test() {
        ListNode head = new ListNode(3);
        head.next = new ListNode(2);
        head.next.next = new ListNode(0);
        head.next.next.next = new ListNode(4);

        ListNode right = head;
        while (right.next != null) {
            right = right.next;
        }
        Console.WriteLine(right.val);
        
        int n = 1;
        ListNode left = head;
        while (n > 0) {
            left = left.next;
            n--;
        }
        Console.WriteLine(left.val);

        right.next = left;
        Console.WriteLine(head.val);

        Solution solution = new Solution();
        bool result = solution.HasCycle(head);
        Console.WriteLine(result);
    }
}