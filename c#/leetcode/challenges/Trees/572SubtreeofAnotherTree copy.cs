namespace leetcode.challenges.Trees._572SubtreeofAnotherTree;

using System;
using System.Collections.Generic;

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
public class Solution {
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if (subRoot == null) return true;
        if (root == null) return false;
        if (IsSameTree(root, subRoot))
            return true;
        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }

    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
            return true;
        if (p != null && q != null && p.val == q.val)
            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        return false;
    }
}

public static class _572SubtreeofAnotherTree {

    public static void Test() {
        TreeNode root = new TreeNode(3);
        root.left = new TreeNode(4);
        root.right = new TreeNode(5);
        root.left.left = new TreeNode(1);
        root.left.right = new TreeNode(2);

        TreeNode subRoot = new TreeNode(4);
        subRoot.left = new TreeNode(1);
        subRoot.right = new TreeNode(2);

        Solution sol = new Solution();
        Console.WriteLine("Is subRoot a subtree of root? " + sol.IsSubtree(root, subRoot));
    }
}