namespace LeetCode.Solution0201_0300
{
    public class Solution0222
    {
        public int CountNodes(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var left = root.left;
            var leftDepth = 0;
            var right = root.right;
            var rightDepth = 0;

            while (left != null)
            {
                leftDepth++;
                left = left.left;
            }

            while (right != null)
            {
                rightDepth++;
                right = right.right;
            }

            if (leftDepth == rightDepth)
            {
                return ((int)Math.Pow(2, leftDepth) - 1) * 2 + 1;
            }

            return CountNodes(root.left) + CountNodes(root.right) + 1;
        }
        
        // 一路往最左和最右, 計算高度,
        //   如果兩邊高度一樣, 即可計算節點個數, 子樹節點: 2^(高度)-1 + 子樹節點: 2^(高度)-1 + (父節點)1
        //   如果兩邊高度不一樣, 分別遞迴到左邊子節點和右邊子節點, 直到邊子節點或右邊子節點是 complete binary tree 為止
        
        // Time: O(log(N) * log(N)), 高度最高 log(N) 且每層都可能呼叫 CountNodes
        // Space: O(log(N))
    }
}