﻿using System;

namespace LeetCode.Solution0101_0200
{
    public class Solution0105
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            var result = BuildTree(preorder, 0, preorder.Length - 1, inorder, 0, inorder.Length - 1);

            return result;
        }

        private TreeNode BuildTree(int[] preorder, int preorderBegin, int preorderEnd, int[] inorder, int inorderBegin, int inorderEnd)
        {
            var root = new TreeNode(preorder[preorderBegin]);

            if (preorderBegin == preorderEnd)
            {
                return root;
            }

            var inorderRootIndex = Array.IndexOf(inorder,
                root.val);
            if (inorderRootIndex > inorderBegin)
            {
                var leftLength = (inorderRootIndex - 1) - inorderBegin + 1;
                root.left = BuildTree(preorder, preorderBegin + 1, preorderBegin + 1 + leftLength - 1, inorder, inorderBegin, inorderRootIndex - 1);
            }

            if (inorderEnd > inorderRootIndex)
            {
                var rightLength = inorderEnd - (inorderRootIndex + 1) + 1;
                root.right = BuildTree(preorder, preorderEnd - rightLength + 1, preorderEnd, inorder, inorderRootIndex + 1, inorderEnd);
            }

            return root;
        }
    }

    // Time: O(N)
    // Space: O(1)
}