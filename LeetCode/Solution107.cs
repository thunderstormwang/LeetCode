using System.Collections.Generic;

namespace LeetCode
{
    public class Solution107
    {
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            if (root == null)
            {
                return new List<IList<int>>();
            }

            IList<IList<int>> result = new List<IList<int>>();
            result = Depth(root, result, 1);
            return result;
        }

        private IList<IList<int>> Depth(TreeNode root, IList<IList<int>> list, int depth)
        {
            if (root == null)
            {
                return list;
            }

            if (list.Count < depth)
            {
                list.Insert(0, new List<int>());
                list[0].Add(root.val);
            }
            else
            {
                list[depth - 1].Add(root.val);
            }

            list = Depth(root.left, list, depth + 1);
            list = Depth(root.right, list, depth + 1);

            return list;
        }

        public IList<IList<int>> LevelOrderBottomOLD(TreeNode root)
        {
            if (root == null)
            {
                return new List<IList<int>>();
            }

            IList<IList<int>> result = new List<IList<int>>();
            result = Depth(root, result, 1);
            (result as List<IList<int>>).Reverse();
            return result;
        }

        private IList<IList<int>> DepthOLD(TreeNode root, IList<IList<int>> list, int depth)
        {
            if (root == null)
            {
                return list;
            }

            if (list.Count < depth)
            {
                list.Add(new List<int>());
            }

            list = Depth(root.left, list, depth + 1);
            list = Depth(root.right, list, depth + 1);

            list[depth - 1].Add(root.val);

            return list;
        }
    }
}