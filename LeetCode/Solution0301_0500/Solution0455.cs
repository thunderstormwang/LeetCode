namespace LeetCode.Solution0301_0500;

public class Solution0455
{
    public int FindContentChildren(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);

        var content = 0;
        var index = s.Length - 1;
        for (var i = g.Length - 1; i >= 0 && index >= 0; i--)
        {
            if (g[i] > s[index])
            {
                continue;
            }

            content++;
            index--;
        }

        return content;
    }
    
    // 這題我一開始想用遞迴解, 這是想太多而且會超時
    // 題目只要求找一個最大解, 並不是要求找出所有解, 那就不必用到遞迴
    // 因為 g: {3,4,5,6}, s: {8,9}, 把 s 的兩塊餅乾 {8,9} 拿去餵 {3,4} 或 {5,6}
    // 得到的解都是 2
    
    // Time: O(g * log(g)) + O(s * log(s)) --
    // 陣列 g 排序: O(g * log(g)) + 陣列 s 排序: O(s * log(s)) + 迴圈 g: O(g), 只留最大項
    
    // Memory: O(1)
}