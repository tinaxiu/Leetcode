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
    class _103
    {
        public void runCode()
        {
            TreeNode node = new TreeNode(3);
            node.left = new TreeNode(9);
            node.right = new TreeNode(20);
            node.left.left = new TreeNode(2);
            node.left.right = new TreeNode(1);
            node.right.right = new TreeNode(15);
            node.right.left = new TreeNode(7);

            ZigzagLevelOrder(node);
        }
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            IList<IList<int>> list = new List<IList<int>>();
            if (root == null) return list;
            TreeNode node;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            int level = 0;

            while(q.Count >0)
            {
                list.Add(new List<int>());
                int level_length = q.Count;

                for(int i =0; i< level_length; i++)
                {
                    node = q.Dequeue();
                    if (level % 2 == 1) list[level].Insert(0, node.val);
                    else list[level].Add(node.val);

                    if (node.left != null) q.Enqueue(node.left);
                    if (node.right != null) q.Enqueue(node.right);
                }

                level++;                   
            }

            return list;
        }
    }
}
