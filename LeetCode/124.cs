using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _124
    {
        int max_sum = Int32.MinValue;

        public void runCode()
        {
            TreeNode head = new TreeNode(-10);
            //TreeNode node = head;
            //node.left = new TreeNode(9);
            //node.right = new TreeNode(20);
            //node = node.right;
            //node.left = new TreeNode(15);
            //node.right = new TreeNode(7);
            //node.right.left = new TreeNode(7);

            MaxPathSum(head);
        }

        public int MaxPathSum(TreeNode root)
        {
            max_gain(root);
            return max_sum;

        }

        int max_gain(TreeNode node)
        {
            if (node == null) return 0;
            int left = Math.Max(max_gain(node.left),0) ;
            int right = Math.Max(max_gain(node.right), 0);

            int price_newpath = node.val + left + right;
            max_sum = Math.Max(max_sum, price_newpath);

            return node.val + Math.Max(left, right);
        }
    }
}
