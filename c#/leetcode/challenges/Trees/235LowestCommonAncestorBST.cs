namespace leetcode.challenges.Trees._235LowestCommonAncestorBST;

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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
         TreeNode curr = root;
        while (curr != null)
        {
            if (p.val < curr.val && q.val < curr.val)
                curr = curr.left;
            else if (p.val > curr.val && q.val > curr.val)
                curr = curr.right;
            else
                return curr;
        }
        return null;
    }
}
public static class _235LowestCommonAncestorBST {

    public static void Test() {
         TreeNode root = new TreeNode(6);
        root.left = new TreeNode(2);
        root.right = new TreeNode(8);
        root.left.left = new TreeNode(0);
        root.left.right = new TreeNode(4);
        root.left.right.left = new TreeNode(3);
        root.left.right.right = new TreeNode(5);
        root.right.left = new TreeNode(7);
        root.right.right = new TreeNode(9);

        TreeNode p = root.left;
        TreeNode q = root.right;

        Solution sol = new Solution();
        TreeNode lca = sol.LowestCommonAncestor(root, p, q);
        Console.WriteLine("Lowest Common Ancestor of " + p.val + " and " + q.val + " is: " + lca.val);
    }
}