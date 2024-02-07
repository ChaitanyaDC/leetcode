namespace leetcode.challenges.LinkedList._23MergekSortedLists;

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
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists == null || lists.Length == 0) {
            return null;
        }

        while (lists.Length > 1) {
            List<ListNode> listRes = new List<ListNode>();
            for (int i = 0; i < lists.Length; i += 2) {
                ListNode l1 = lists[i];
                ListNode l2 = (i + 1 < lists.Length) ? lists[i + 1] : null;
                listRes.Add(MergeTwoLists(l1, l2));
            }
            lists = listRes.ToArray();
        }
        return lists[0];
    }

    private ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode();
        ListNode tail = dummy;
        while (l1 != null && l2 != null) {
            if (l1.val < l2.val) {
                tail.next = l1;
                l1 = l1.next;
            } else {
                tail.next = l2;
                l2 = l2.next;
            }
            tail = tail.next;
        }

        if (l1 != null) {
            tail.next = l1;
        } else {
            tail.next = l2;
        }
        return dummy.next;
    }
}


public static class _23MergekSortedLists {

    public static void Test() {
        Solution solution = new Solution();
        // Example usage
        ListNode[] lists = new ListNode[] {
            new ListNode(1, new ListNode(4, new ListNode(5))),
            new ListNode(1, new ListNode(3, new ListNode(4))),
            new ListNode(2, new ListNode(6))
        };
        ListNode result = solution.MergeKLists(lists);
        while (result != null) {
            Console.Write(result.val + " ");
            result = result.next;
        }
    }
}