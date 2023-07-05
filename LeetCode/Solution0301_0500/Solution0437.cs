using LeetCode.Models;

namespace LeetCode.Solution0301_0500;

public class Solution0437
{
    public int PathSum_Ver1(TreeNode root, int targetSum)
    {
        return InorderSearch(root, targetSum);
    }

    public object PathSum_Ver2(TreeNode root, int targetSum)
    {
        var dict = new Dictionary<long, int>();
        dict.Add(0, 1);
        return FindPathSum_Ver2(root, targetSum, 0, dict);
    }

    private int InorderSearch(TreeNode root, long targetSum)
    {
        if (root == null)
        {
            return 0;
        }

        var result = FindPathSum_Ver1(root, targetSum);

        result += InorderSearch(root.left, targetSum);
        result += InorderSearch(root.right, targetSum);
        return result;
    }

    private int FindPathSum_Ver1(TreeNode root, long targetSum)
    {
        if (root == null)
        {
            return 0;
        }

        var result = 0;
        targetSum -= root.val;
        if (targetSum == 0)
        {
            result += 1;
        }

        result += FindPathSum_Ver1(root.left, targetSum);
        result += FindPathSum_Ver1(root.right, targetSum);
        return result;
    }
    
    private int FindPathSum_Ver2(TreeNode root, int targetSum, long currSum, Dictionary<long, int> dict)
    {
        if(root == null)
        {
            return 0;
        }

        var result = 0;
        currSum += root.val;
        if(dict.ContainsKey(currSum - targetSum))
        {
            result += dict[currSum - targetSum];
        }

        if(!dict.ContainsKey(currSum))
        {
            dict.Add(currSum, 0);
        }
        dict[currSum] += 1;

        result += FindPathSum_Ver2(root.left, targetSum, currSum, dict);
        result += FindPathSum_Ver2(root.right, targetSum, currSum, dict);

        dict[currSum] -= 1;

        return result;
    }
}