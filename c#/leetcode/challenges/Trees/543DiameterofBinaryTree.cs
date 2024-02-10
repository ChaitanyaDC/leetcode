namespace leetcode.challenges.Trees._543DiameterofBinaryTree;

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
    public int DiameterOfBinaryTree(TreeNode root) {
        int[] res = new int[1];

        int Dfs(TreeNode node)
        {
            if (node == null)
                return -1;

            int left = Dfs(node.left);
            int right = Dfs(node.right);
            res[0] = Math.Max(res[0], 2 + left + right);

            return 1 + Math.Max(left, right);
        }

        Dfs(root);
        return res[0];
    }
}

public static class _543DiameterofBinaryTree {

    public static void Test() {
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.left.left = new TreeNode(4);
        root.left.right = new TreeNode(5);

        Solution sol = new Solution();
        Console.WriteLine("Diameter of the binary tree: " + sol.DiameterOfBinaryTree(root));
    }
}