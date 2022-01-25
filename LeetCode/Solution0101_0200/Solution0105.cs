using System;

namespace LeetCode.Solution0101_0200
{
    public class Solution0105
    {
        public TreeNode BuildTree(int[] preorder,
            int[] inorder)
        {
            var result = BuildTree(preorder,
                0,
                preorder.Length - 1,
                inorder,
                0,
                inorder.Length - 1);

            return result;
        }

        private TreeNode BuildTree(int[] preorder,
            int preorderBegin,
            int preorderEnd,
            int[] inorder,
            int inorderBegin,
            int inorderEnd)
        {
            var root = new TreeNode(preorder[preorderBegin]);
            
            if (preorderBegin == preorderEnd)
            {
                return root;
            }

            var inorderRoot = Array.IndexOf(inorder,
                root.val);
            if (inorderRoot > inorderBegin)
            {
                var leftLength = (inorderRoot - 1) - inorderBegin + 1;
                root.left = BuildTree(preorder,
                    preorderBegin + 1,
                    preorderBegin + 1 + leftLength - 1,
                    inorder,
                    inorderBegin,
                    inorderRoot - 1);
            }

            if (inorderEnd > inorderRoot)
            {
                var rightLength = inorderEnd - (inorderRoot + 1) + 1;
                root.right = BuildTree(preorder,
                    preorderEnd - rightLength + 1,
                    preorderEnd,
                    inorder,
                    inorderRoot + 1,
                    inorderEnd);
            }

            return root;
        }

        // new int[] { 1, 2, 4, 5, 3, 6, 7 },
        // new int[] { 4, 2, 5, 1, 6, 3, 7 },
        // new int?[] { 1, 2, 4, 5, 3, 6, 7 }
    }
}