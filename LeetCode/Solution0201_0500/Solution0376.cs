namespace LeetCode.Solution0201_0500;

public class Solution0376
{
    public int WiggleMaxLength(int[] nums)
    {
        if (nums.Length <= 1)
        {
            return nums.Length;
        }

        var result = 1;
        var preDiff = 0;

        for (var i = 1; i < nums.Length; i++)
        {
            var currDiff = nums[i] - nums[i - 1];
            if ((currDiff < 0 && preDiff >= 0) || (currDiff > 0 && preDiff <= 0))
            {
                preDiff = currDiff;
                result++;
            }
        }

        return result;
    }
    
    // 這題題目我看不懂...
    //
    // 碰壁了幾次才發現沒看清楚題目, 
    // 一、
    // 可以刪除元素, 意思就是我們可以在波峰的路段上一直刪元素, 直到開始遇到波谷
    // 例: {1, 2, 3, 4, 5, 1} 就是刪到 {1, 2, 1} 或是 {1, 5, 1}, 答案都是 2
    // 反之若現在往波谷的路上, 就是一直刪元素直到開始遇到波鋒
    //
    // 二、
    // 還有另一點我沒從題目看出來的是 {2 ,2} 答案是 1, {2 ,2, 2} 答案都是 1, 
    //
    // 綜合以上幾點
    // 當陣列長度 <= 1, 輸出陣列長度
    // 當陣列長度 >= 2,
    //   設定 result 起始值為 1, preDiff 起始為 0
    //   從 index = 1 開始跑迴圈
    //     currDiff 為當前元素減去前個元素
    //     當 currDiff, preDiff 為同正負號, 代表同為波鋒或波谷, 不增加 result 以摸擬刪去元素
    //     當 currDiff, preDiff 為不同正負號, 代表遇到轉折, result 可以 + 1
    //     然後將 currDiff 指派給 preDiff
    //     再開始下一輸迴圈
    //
    // 最後回傳 
    
    // DP 解法: 待補...
    
    // Time: O(N)
    // Memory: O(1)
}