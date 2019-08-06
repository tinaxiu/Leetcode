using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _101
    {
        public void runCode()
        {
            TreeNode node = new TreeNode(2);
            node.left = new TreeNode(1);
            node.right = new TreeNode(1);
            //node.right.left = new TreeNode(7);

            IsSymmetric(node);
        }
        public bool IsSymmetric(TreeNode root)
        {
            if( root != null)
            {
              return  recursive(root.left, root.right);
            }
            return true;
        }

        bool recursive(TreeNode left, TreeNode right)
        {
            bool res;
            if (left == null && right != null) return false;
            else if (left != null && right == null) return false;
            else if (left == null && right == null) return true;
            else
            {
                if (left.val == right.val)
                {
                    if (recursive(left.left, right.right) == false) return false;

                    if (recursive(left.right, right.left) == false) return false;

                    return true;
                }

                else return false;
            }

        }

    }
}
