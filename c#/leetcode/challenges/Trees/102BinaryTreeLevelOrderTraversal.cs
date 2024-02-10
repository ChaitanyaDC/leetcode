namespace leetcode.challenges.Trees._102BinaryTreeLevelOrderTraversal;

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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> res = new List<IList<int>>();
        if (root == null) return res;

        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);

        while (q.Count > 0)
        {
            int levelSize = q.Count;
            IList<int> level = new List<int>();
            for (int i = 0; i < levelSize; i++)
            {
                TreeNode node = q.Dequeue();
                level.Add(node.val);
                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
            }
            res.Add(level);
        }
        return res;
    }
}
public static class _102BinaryTreeLevelOrderTraversal {

    public static void Test() {
        TreeNode root = new TreeNode(3);
        root.left = new TreeNode(9);
        root.right = new TreeNode(20);
        root.right.left = new TreeNode(15);
        root.right.right = new TreeNode(7);

        Solution sol = new Solution();
        IList<IList<int>> result = sol.LevelOrder(root);
        Console.WriteLine("Level Order Traversal:");
        foreach (IList<int> level in result)
        {
            foreach (int val in level)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();
        }
    }
}