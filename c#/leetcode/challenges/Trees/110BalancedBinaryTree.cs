namespace leetcode.challenges.Trees._110BalancedBinaryTree;

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
    public bool IsBalanced(TreeNode root) {
        (bool balanced, int height) Dfs(TreeNode node)
        {
            if (node == null)
                return (true, 0);

            var left = Dfs(node.left);
            var right = Dfs(node.right);
            var balanced = (left.balanced && right.balanced) && (Math.Abs(left.height - right.height) <= 1);
            var height = 1 + Math.Max(left.height, right.height);
            return (balanced, height);
        }

        return Dfs(root).balanced;
    }
}
public static class _110BalancedBinaryTree {

    public static void Test() {
        TreeNode root = new TreeNode(3);
        root.left = new TreeNode(9);
        root.right = new TreeNode(20);
        root.right.left = new TreeNode(15);
        root.right.right = new TreeNode(7);

        Solution sol = new Solution();
        Console.WriteLine("Is the binary tree balanced? " + sol.IsBalanced(root));
    }
}