﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /**
* Definition for a binary tree node.

*/

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    class merge_two_binary_trees
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            TreeNode node = new TreeNode(-1);
            if (t1 != null && t2 != null)
            {
                node.val = t1.val + t2.val;
                node.left = MergeTrees(t1.left, t2.right);
                node.right = MergeTrees(t1.right, t2.right);
            }
            else if (t2 != null)
            {
                node.val = t2.val;
                node.left = MergeTrees(null, t2.left);
                node.right = MergeTrees(null, t2.right);
            }
            else if (t1 != null)
            {
                node.val = t1.val;
                node.left = MergeTrees(t1.left,null);
                node.right = MergeTrees(t1.right,null);
            }

            return node;

            
        }
    }
}
