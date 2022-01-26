using System;

namespace LeetCode.Solution0101_0200
{
    public class Solution0106
    {
        public TreeNode BuildTree(int[] inorder,
            int[] postorder)
        {
            var result = BuildTree(inorder,
                0,
                inorder.Length - 1,
                postorder,
                0,
                postorder.Length - 1);

            return result;
        }

        private TreeNode BuildTree(int[] inorder,
            int inorderBegin,
            int inorderEnd,
            int[] postorder,
            int postorderBegin,
            int postorderEnd)
        {
            var root = new TreeNode(postorder[postorderEnd]);

            if (postorderBegin == postorderEnd)
            {
                return root;
            }

            var inorderRootIndex = Array.IndexOf(inorder,
                root.val);
            if (inorderRootIndex > inorderBegin)
            {
                var leftLength = (inorderRootIndex - 1) - inorderBegin + 1;
                root.left = BuildTree(inorder,
                    inorderBegin,
                    inorderRootIndex - 1,
                    postorder,
                    postorderBegin,
                    postorderBegin + leftLength - 1);
            }

            if (inorderEnd > inorderRootIndex)
            {
                var rightLength = inorderEnd - (inorderRootIndex + 1) + 1;
                root.right = BuildTree(inorder,
                    inorderRootIndex + 1,
                    inorderEnd,
                    postorder,
                    postorderEnd - 1 - rightLength + 1,
                    postorderEnd - 1);
            }

            return root;
        }
    }
}