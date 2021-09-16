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

            var result = new List<IList<int>>();
            result = Depth(root, result, 1);
            (result as List<IList<int>>).Reverse();
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
                list.Add(new List<int>());
            }

            list = Depth(root.left, list, depth + 1);
            list = Depth(root.right, list, depth + 1);

            list[depth - 1].Add(root.val);

            return list;
        }
    }
}