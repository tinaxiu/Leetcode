using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    /**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
    class _98
    {
        public void runCode()
        {
            TreeNode node = new TreeNode(2);
            node.left = new TreeNode(1);
            node.right = new TreeNode(3);
            //node.right.left = new TreeNode(7);

            IsValidBST(node);
        }
        public bool IsValidBST(TreeNode root)
        {
            Stack<TreeNode> q = new Stack<TreeNode>();
            double number = -  double.MaxValue;

            while (root != null || q.Count != 0)
            {
                
                while (root != null)
                {
                    q.Push(root);
                    root = root.left;
                }

                root = q.Pop();
                if (root.val <= number) return false;

                number = root.val;
                root = root.right;
            }
            return true;

            
        }



            
                
        
    }
}
