namespace LeetCode.Solution0501_9999;

public class Solution0968
{
    private int _result = 0;
    
    public int MinCameraCover(TreeNode root)
    {
        var traverse = Traverse(root);
        if (traverse == 0)
        {
            _result++;
        }

        return _result;
    }

    /// <summary>
    /// 空節點視作 2。
    /// <br/>兩個子節點皆為 2, 父節點不需要攝影機, 避免浪費, 但須回傳 0 讓上層節點有攝影機。
    /// <br/>兩個子節點任一為 0, 父節點需要攝影機, 所以計數加 1, 並回傳 1。
    /// <br/>其它餘餘情況, 父節點被子節點的攝影機覆蓋到, 所以並回傳 2。
    /// </summary>
    /// <param name="node"></param>
    /// <returns>
    /// 0: 該節點沒被攝影機覆蓋到
    /// <br/>1: 該節點有攝影機
    /// <br/>2: 該節點有被攝影機覆蓋到
    /// </returns>
    private int Traverse(TreeNode node)
    {
        if (node == null)
        {
            return 2;
        }

        var left = Traverse(node.left);
        var right = Traverse(node.right);

        if (left == 2 && right == 2)
        {
            return 0;
        }

        if (left == 0 || right == 0)
        {
            _result++;
            return 1;
        }

        return 2;
    }
}