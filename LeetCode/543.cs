using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _543
    {
        int res = 0;

        public void runCode()
        {
            TreeNode node = new TreeNode(1);
            node.left = new TreeNode(2);
            node.right = new TreeNode(3);
            node.left.left = new TreeNode(4);
            node.left.right = new TreeNode(5);

            DiameterOfBinaryTree(node);
        }

        public int DiameterOfBinaryTree(TreeNode root)
        {
            dfs(root);
            return res;
        }

        int dfs(TreeNode root)
        {
            if (root == null) return 0;
            int L = dfs(root.left);
            int R = dfs(root.right);
            res = Math.Max(res, L + R);
            return Math.Max(L, R) + 1;                         
        }
    }

}
