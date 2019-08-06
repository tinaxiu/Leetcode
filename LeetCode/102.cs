using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _102
    {
        public void runCode()
        {
            TreeNode node = new TreeNode(2);
            node.left = new TreeNode(1);
            node.right = new TreeNode(3);
            //node.right.left = new TreeNode(7);

            LevelOrder(node);
        }

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> list = new List<IList<int>>();
            Queue<TreeNode> q = new Queue<TreeNode>();
            int level = 0;
            if(root != null)
                q.Enqueue(root);
            TreeNode node = root;
            while (q.Count != 0)
            {
                list.Add(new List<int>());
                int level_length = q.Count;

                for (int i =0; i< level_length; i++)
                {
                    node = q.Dequeue();
                    list[level].Add(node.val);

                    if(node.left != null)
                        q.Enqueue(node.left);
                    if(node.right != null)
                        q.Enqueue(node.right);
                }
                level++;
            }
            return list;
        }
    }
}
