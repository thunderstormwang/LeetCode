using LeetCode.Models;

namespace LeetCode.Solution0101_0150;

public class Solution0105
{
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        var result = PreorderSearch(preorder, 0, preorder.Length - 1, inorder, 0, inorder.Length - 1);

        return result;
    }

    private TreeNode PreorderSearch(int[] preorder, int preorderStart, int preorderEnd, int[] inorder, int inorderStart, int inorderEnd)
    {
        if (preorderStart > preorderEnd)
        {
            return null;
        }

        var root = new TreeNode(preorder[preorderStart]);
        var center = Array.IndexOf(inorder, root.val, inorderStart);
        
        var leftLength = center - inorderStart;
        root.left = PreorderSearch(preorder, preorderStart + 1, preorderStart + 1 + leftLength - 1, inorder, inorderStart, center - 1);
        
        var rightLength = inorderEnd - center;
        root.right = PreorderSearch(preorder, preorderEnd - rightLength + 1, preorderEnd, inorder, center + 1, inorderEnd);

        return root;
    }
}