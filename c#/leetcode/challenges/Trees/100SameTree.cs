namespace leetcode.challenges.Trees._100SameTree;

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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if (p == null && q == null)
            return true;
        
        if (p == null || q == null || p.val != q.val)
            return false;
        
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}

public static class _100SameTree {

    public static void Test() {
        TreeNode p = new TreeNode(1);
        p.left = new TreeNode(2);
        p.right = new TreeNode(3);

        TreeNode q = new TreeNode(1);
        q.left = new TreeNode(2);
        q.right = new TreeNode(3);

        Solution sol = new Solution();
        Console.WriteLine("Are the two trees same? " + sol.IsSameTree(p, q));
    }
}