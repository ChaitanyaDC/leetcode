namespace leetcode.challenges.Trees._InvertTree;

using System;
using System.Collections.Generic;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
public class Solution {
    public void InvertTree(TreeNode root)
    {
        if (root == null)
            return;

        // Swap the left and right children of the current node
        TreeNode temp = root.left;
        root.left = root.right;
        root.right = temp;

        // Recursively invert the left subtree
        InvertTree(root.left);

        // Recursively invert the right subtree
        InvertTree(root.right);
    }
}
public static class _InvertTree {

    public static void Test() {
        Solution solution = new Solution();
        TreeNode root = new TreeNode(4);

        // Create the left child of the root node
        root.left = new TreeNode(2);

        // Create the right child of the root node
        root.right = new TreeNode(7);

        // Create the left child of the left child of the root node
        root.left.left = new TreeNode(1);

        // Create the right child of the left child of the root node
        root.left.right = new TreeNode(3);

        // Create the left child of the right child of the root node
        root.right.left = new TreeNode(6);

        // Create the right child of the right child of the root node
        root.right.right = new TreeNode(9);

        Console.WriteLine("Original Tree:");
        PrintTree(root);
        Console.WriteLine("\n");

        solution.InvertTree(root);

        Console.WriteLine("Inverted Tree:");
        PrintTree(root);
    }
    public static void PrintTree(TreeNode node)
    {
        if (node == null)
            return;

        // In-order traversal to print the tree
        PrintTree(node.left);
        Console.Write(node.val + " ");
        PrintTree(node.right);
    }
}