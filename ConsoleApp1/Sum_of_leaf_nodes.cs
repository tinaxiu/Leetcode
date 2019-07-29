using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Sum_of_leaf_nodes
    {
        
        public class TreeNode
        {
            public int val;
            public TreeNode left, right;
            public TreeNode(int val)
            {
                this.val = val;
                this.left = this.right = null;
                }
        }

        public void RunCode()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            TreeNode node = root.right;
            node.left = new TreeNode(15);
            node.right = new TreeNode(7);

            SumOfLeftLeaves(root);
        }
        public int SumOfLeftLeaves(TreeNode root)
        {
            int sum = 0;
            if(root == null)
            {
                return sum;
            }
            TreeNode cur = root;

            while(cur != null)
            {
                if(cur.left == null && cur.right == null)
                {
                    sum += cur.val;
                }
                if(cur.left == null)
                {
                    cur = cur.right;
                }
                else
                {
                    TreeNode temp = cur.left;
                    while (temp.right != null  && temp.right !=cur)
                    {
                        temp = temp.right;
                    }
                    if(temp.right == null && temp.left == null)
                    {
                        sum += temp.val;
                    }
                    if(temp.right == null)
                    {
                        temp.right = cur;
                        cur = cur.left;
                    }
                    else
                    {
                        temp.right = null;
                        cur = cur.right;
                    }
                }
            }
            return sum;

        }
    }
}
