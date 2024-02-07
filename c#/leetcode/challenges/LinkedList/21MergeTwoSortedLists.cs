namespace leetcode.challenges.LinkedList._21MergeTwoSortedLists;

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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode dummy = new ListNode();
        ListNode tail = dummy;
        
        while (list1 != null && list2 != null) {
            if (list1.val < list2.val) {
                tail.next = list1;
                list1 = list1.next;
            } else {
                tail.next = list2;
                list2 = list2.next;
            }
            tail = tail.next;
        }
        
        if (list1 != null) {
            tail.next = list1;
        } else if (list2 != null) {
            tail.next = list2;
        }
        
        return dummy.next;
    }
}



public static class _21MergeTwoSortedLists {

    public static void Test() {
        ListNode list1 = new ListNode(1);
        list1.next = new ListNode(2);
        list1.next.next = new ListNode(4);
        
        Console.WriteLine("List1:");
        ListNode current1 = list1;
        while (current1 != null) {
            Console.Write(current1.val + " ");
            current1 = current1.next;
        }
        
        ListNode list2 = new ListNode(1);
        list2.next = new ListNode(3);
        list2.next.next = new ListNode(4);
        
        Console.WriteLine("\nList2:");
        ListNode current2 = list2;
        while (current2 != null) {
            Console.Write(current2.val + " ");
            current2 = current2.next;
        }
        
        Solution solution = new Solution();
        ListNode result = solution.MergeTwoLists(list1, list2);
        
        Console.WriteLine("\nMerged List:");
        ListNode current = result;
        while (current != null) {
            Console.Write(current.val + " ");
            current = current.next;
        }
    }
}