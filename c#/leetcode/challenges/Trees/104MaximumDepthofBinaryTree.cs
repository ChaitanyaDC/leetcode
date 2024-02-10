namespace leetcode.challenges.Trees._104MaximumDepthofBinaryTree;

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
    public int MaxDepth(TreeNode root) {
        if (root == null)
            return 0;
        
        int level = 0;
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        
        while (q.Count > 0)
        {
            int levelSize = q.Count;
            for (int i = 0; i < levelSize; i++)
            {
                TreeNode node = q.Dequeue();
                if (node.left != null)
                    q.Enqueue(node.left);
                if (node.right != null)
                    q.Enqueue(node.right);
            }
            level++;
        }
        
        return level;
    }
}
public static class _104MaximumDepthofBinaryTree {

    public static void Test() {
        TreeNode root = new TreeNode(3);
        root.left = new TreeNode(9);
        root.right = new TreeNode(20);
        root.right.left = new TreeNode(15);
        root.right.right = new TreeNode(7);

        Solution sol = new Solution();
        Console.WriteLine("Max depth of the binary tree: " + sol.MaxDepth(root));
    }
}