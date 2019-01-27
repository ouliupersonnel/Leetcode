// 112ms, 36.36%, 5m, 1t
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if (root == null)
            return null;
        var t = root.right;
        root.right = root.left;
        root.left = t;
        InvertTree(root.left);
        InvertTree(root.right);
        return root;
    }
}