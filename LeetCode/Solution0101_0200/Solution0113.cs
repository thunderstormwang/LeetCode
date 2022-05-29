using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solution0101_0200
{
    public class Solution0113
    {
        public IList<IList<int>> PathSum_Recursive(TreeNode root, int targetSum)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
            {
                return result;
            }

            DepthFirstSearch(root, targetSum, new List<int>(), result);

            return result;
        }

        public IList<IList<int>> PathSum_Iterative(TreeNode root, int targetSum)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
            {
                return result;
            }

            var stack = new Stack<(TreeNode Node, int TargetSum, List<int> CurrPath)>();

            stack.Push((root, targetSum, new List<int>()));
            while (stack.Count != 0)
            {
                var item = stack.Pop();
                item.TargetSum -= item.Node.val;
                item.CurrPath.Add(item.Node.val);
                if (item.Node.left == null && item.Node.right == null && item.TargetSum == 0)
                {
                    result.Add(item.CurrPath);
                    continue;
                }

                if (item.Node.right != null)
                {
                    stack.Push((item.Node.right, item.TargetSum, new List<int>(item.CurrPath.ToArray())));
                }

                if (item.Node.left != null)
                {
                    stack.Push((item.Node.left, item.TargetSum, new List<int>(item.CurrPath.ToArray())));
                }
            }

            return result;
        }

        private void DepthFirstSearch(TreeNode root, int targetSum, IList<int> currPath, IList<IList<int>> allPaths)
        {
            targetSum -= root.val;
            currPath.Add(root.val);
            if (root.left == null && root.right == null && targetSum == 0)
            {
                allPaths.Add(currPath.ToArray());
                currPath.RemoveAt(currPath.Count - 1);
                return;
            }

            if (root.left != null)
            {
                DepthFirstSearch(root.left,
                    targetSum,
                    currPath,
                    allPaths);
            }

            if (root.right != null)
            {
                DepthFirstSearch(root.right,
                    targetSum,
                    currPath,
                    allPaths);
            }

            currPath.RemoveAt(currPath.Count - 1);
        }
    }
    
    // Time: O(N)
    // Space: O(log(N))
}