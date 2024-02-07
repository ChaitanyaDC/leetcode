namespace leetcode.challenges.LinkedList._19RemoveNthNodeFromEndofList;

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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode dummy = new ListNode(0, head);
        ListNode left = dummy;
        ListNode right = head;
        
        while (n > 0 && right != null) {
            right = right.next;
            n--;
        }
        
        while (right != null) {
            left = left.next;
            right = right.next;
        }
        
        left.next = left.next.next;
        return dummy.next;
    }
}



public static class _19RemoveNthNodeFromEndofList {

    public static void Test() {
        int[] arr = {1, 2, 3, 4, 5};
        int n = 2;

        ListNode head = ArrayToLinkedList(arr);

        Solution solution = new Solution();
        ListNode resultHead = solution.RemoveNthFromEnd(head, n);
        int[] resultArr = LinkedListToArray(resultHead);
        Console.WriteLine("Input array [" + string.Join(", ", arr) + "] for n =" + n.ToString());
        Console.WriteLine("Resulting array: [" + string.Join(", ", resultArr) + "]");
    }

    public static ListNode ArrayToLinkedList(int[] arr) {
        if (arr == null || arr.Length == 0) {
            return null;
        }
        ListNode head = new ListNode(arr[0]);
        ListNode current = head;
        for (int i = 1; i < arr.Length; i++) {
            current.next = new ListNode(arr[i]);
            current = current.next;
        }
        return head;
    }

    public static int[] LinkedListToArray(ListNode head) {
        List<int> result = new List<int>();
        ListNode current = head;
        while (current != null) {
            result.Add(current.val);
            current = current.next;
        }
        return result.ToArray();
    }
}