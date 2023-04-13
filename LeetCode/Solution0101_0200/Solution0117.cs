using System.Collections.Generic;
using LeetCode.Models;

namespace LeetCode.Solution0101_0200
{
    public class Solution0117
    {
        public TreeNodeV2 Connect_BFS(TreeNodeV2 root)
        {
            var queue = new Queue<TreeNodeV2>();

            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                var nodeNumberInCurrLevel = queue.Count;
                TreeNodeV2 pre = null;
                while (nodeNumberInCurrLevel > 0)
                {
                    var node = queue.Dequeue();
                    if (node == null)
                    {
                        nodeNumberInCurrLevel--;
                        continue;
                    }

                    if (pre != null)
                    {
                        pre.next = node;
                    }

                    pre = node;
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                    nodeNumberInCurrLevel--;
                }
            }

            return root;
        }

        public TreeNodeV2 Connect_DFS(TreeNodeV2 root)
        {
            if (root == null)
            {
                return root;
            }

            var temp = root.next;
            TreeNodeV2 nextNodeDownLevel = null;
            while (temp != null)
            {
                if (temp.left != null)
                {
                    nextNodeDownLevel = temp.left;
                    break;
                }

                if (temp.right != null)
                {
                    nextNodeDownLevel = temp.right;
                    break;
                }

                temp = temp.next;
            }

            if (root.left != null)
            {
                root.left.next = root.right ?? nextNodeDownLevel;
            }
            
            if (root.right != null)
            {
                root.right.next = nextNodeDownLevel;
            }

            Connect_DFS(root.right);
            Connect_DFS(root.left);

            return root;
        }
    }
    
    // 用 BFS
    // 做法跟 116 一樣, 沒難度
    
    // =====
    
    // 用 DFS
    // 很難想, 題目限定 constant space, 一開始只想到先做一次 DFS
    // 把每層的節點用 list 存起來, 再作串連, 但這就不符題意的 constant space 了
    // 看了解答才知道可以在一次 DFS 就解決, 且因為這不是 perfect binary tree, 
    // 要先做右邊再做左邊
    
    // Time: O(N)
    // Space: O(1)
}