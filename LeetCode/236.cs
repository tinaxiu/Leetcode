using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _236
    {
        public void runCode()
        {
            TreeNode node = new TreeNode(3);
            node.left = new TreeNode(5);
            node.right = new TreeNode(1);
            node.left.left = new TreeNode(6);

            LowestCommonAncestor(node, node.right,node.left.left);
        }

        TreeNode ancestor = null;
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            dfs(root, p, q);

            return ancestor;
        }

        bool dfs(TreeNode root, TreeNode p , TreeNode q)
        {
            if (root == null) return false;

            int left = dfs(root.left, p, q) ? 1 : 0;

            int right = dfs(root.right, p, q) ? 1 : 0;

            int mid = (root == p || root == q) ? 1 : 0;

            if (mid + left + right >= 2) ancestor = root;

            return (mid + left + right > 0);
        }
    }
}
